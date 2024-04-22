using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using cmsyasix.Core.Convertors;
using cmsyasix.Core.DTOs;
using cmsyasix.Core.Generator;
using cmsyasix.Core.Security;
using cmsyasix.Core.Senders;
using cmsyasix.Core.Services.Interfaces;
using cmsyasix.Data.Entities.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;

namespace cmsyasix.web.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        private IViewRenderService _viewRender;
        public AccountController(IUserService userService,IViewRenderService viewRenderService)
        {
            _userService = userService;
            _viewRender = viewRenderService;
        }

        #region Register

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }
            if (_userService.IsExistUserName(register.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری معتبر نمی باشد");
                return View(register);
            }
            if (_userService.IsExistEmail(FixedText.FixEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل معتبر نمی باشد");
                return View(register);
            }
            User user = new User()
            {
                ActiveCode = NameGenerator.GenerateUniqCode(),
                Email = FixedText.FixEmail(register.Email),
                IsActive = false,
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                RegisterDate = DateTime.Now,
                UserAvatar = "Default.jpg",
                UserName = register.UserName
            };
            _userService.AddUser(user);
            #region Send Activation Email
            string body = _viewRender.RenderToStringAsync("_ActiveEmail", user);
            SendEmail.Send(user.Email, "فعالسازی", body);
            #endregion
            return View("SuccessRegister",user);
        }
        #endregion

        #region Login
        [Route("Login")]
        public IActionResult Login(bool EditProfile=false)
        {
            ViewBag.EditProfile = EditProfile;
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login,string ReturnUrl="/")
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            var user = _userService.LoginUser(login);
            if (user != null)
            {
                if (user.IsActive)
                {
                    var claims = new List<Claim>() {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.UserName)
                    };
                    var identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);
                    var properties = new AuthenticationProperties {
                        IsPersistent = login.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);

                    ViewBag.IsSuccess = true;
                    if (ReturnUrl != "/")
                    {
                        return Redirect(ReturnUrl);
                    }
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری شما فعال نمی باشد");
                }
            }
            ModelState.AddModelError("Email", "کاربری با مشخصات وارد شده یافت نشد");
            return View();
        }
        #endregion

        #region Active Account
        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userService.ActiveAccount(id);
            return View();
        }
        #endregion

        #region Logout
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login");
        }
        #endregion

        #region Forgot Password
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [Route("ForgotPassword")]
        public IActionResult ForgotPassword(ForgotPasswordViewModel forgot)
        {
            if (!ModelState.IsValid)
            {
                return View(forgot);
            }
            string fiexedemail = FixedText.FixEmail(forgot.Email);
            var user = _userService.GetUserByEmail(fiexedemail);
            if(user == null)
            {
                ModelState.AddModelError("Email","کاربری یافت نشد");
                return View(forgot);
            }
            string BodyEmail = _viewRender.RenderToStringAsync("_ForgotPassword", user);
            SendEmail.Send(user.Email, "بازیابی حساب کاربری",BodyEmail);
            ViewBag.IsSuccess = true;
            return View();
        }
        #endregion

        #region Reset Password
        public IActionResult ResetPassword(string id)
        {
            return View(new ResetPasswordViewModel()
            {
                ActiveCode = id
            });
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel reset)
        {
            if (!ModelState.IsValid)
                return View(reset);
            var user = _userService.GetUserByActiveCode(reset.ActiveCode);
            if (user == null)
            {
                return NotFound();
            }
            string hasspass = PasswordHelper.EncodePasswordMd5(reset.Password);
            user.Password = hasspass;
            _userService.UpdateUser(user);
            return Redirect("/Login");
        }
        #endregion
    }
}