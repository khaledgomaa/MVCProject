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
                    PhoneNumber = user.PhoneNumber
                    
               
               };
               
                var created = await userManager.CreateAsync(Appuser, user.Password);
                if (created.Succeeded)
                {
                    Appuser.ImagePath = imageManager.UploadFile(user.ImageFile, "AppImages");

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

       
        public IActionResult myProfile()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(Playground playground)
        //{
        //    imageManager.UploadFile(playground.ImageFile, "Playgrounds");
        //    return View();
        //}



        //// POST: AccountRegController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: AccountRegController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: AccountRegController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
