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
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public async Task<IActionResult> logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home"); 
        }


        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
          

            if (ModelState.IsValid)
            {

                var Appuser = new ApplicationUser {
                    UserName = user.UserName,
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
            return View();
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


                var result = await signInManager.PasswordSignInAsync(Appuser.UserName, user.Password, user.rememberMe,false);

                if (result.Succeeded)
                {
                    return RedirectToAction("myProfile");
                }
                
                    ModelState.AddModelError("","Not correct data");
               
            }
            return View(user);
        }


        public IActionResult myProfile()
        {
            return View();
        }

    


        
    }
}
