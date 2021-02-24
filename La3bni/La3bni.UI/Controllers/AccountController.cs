using IdentityModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La3bni.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly ImageManager imageManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ImageManager _imageManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            imageManager = _imageManager;
            
        }
        [AcceptVerbs("Get","Post")]
        public async Task<IActionResult> Email_Unique(string  email)
        {

              var created = await userManager.FindByEmailAsync(email);
            if (created is null)
            {
                return Json(true);
            }
            else return Json(false);
        }
        [AcceptVerbs("Get", "Post")]
        public async Task<IActionResult> Name_Unique(string Username)
        {

            var created = await userManager.FindByNameAsync(Username);
            if (created is null)
            {
                return Json(true);
            }
            else return Json(false);
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
      
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
          

            if (ModelState.IsValid)
            {

                var Appuser = new ApplicationUser {
                    UserName = user.Username,
                    Email = user.Email,
                    gender = user.Gender,
                    city = user.City,
                    PhoneNumber = user.PhoneNumber,
                    ImagePath=""
               
               };

                string P = (imageManager.UploadFile(user.ImageFile, "AppImages"));

                Appuser.ImagePath = P;
                var created = await userManager.CreateAsync(Appuser, user.Password);
                if (created.Succeeded)
                {
                    await signInManager.SignInAsync(Appuser, isPersistent: false);
                  
                  
                    return RedirectToAction("myProfile");
                }
                foreach (var err in created.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return View(user);
        }



        [HttpGet]
        public IActionResult login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> login(LogIN user)
        {
            if (ModelState.IsValid)
            {
                var Appuser = new ApplicationUser();
                
                if (user.Email.Contains("@"))
                    Appuser = await userManager.FindByEmailAsync(user.Email);
                else
                    Appuser = await userManager.FindByNameAsync(user.Email);

                if (!(Appuser is null))
                {
                    var result = await signInManager.PasswordSignInAsync(Appuser.UserName, user.Password, user.rememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("myProfile", Appuser);
                    }

                    ModelState.AddModelError("", "Not correct data");
                }
                else
                {
                    ModelState.AddModelError("", "Not correct data");
                    return View(user);
                }
                
            }
            return View(user);
        }


        public async Task<IActionResult> myProfileAsync(ApplicationUser current)
        {
            var user = await userManager.GetUserAsync(User);
            return View(user);
        }
        public IActionResult Profile_Playgrounds(List<Playground> pgs)
        {
            return View(pgs);
        }
        
        public async Task<IActionResult> logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }






    }
}
