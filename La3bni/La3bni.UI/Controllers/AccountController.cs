using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La3bni.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly ImageManager imageManager;

        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //public AccountController(  ImageManager _imageManager)
        //{
        //    imageManager = _imageManager;
        //    //_signInManager = signInManager;
        //    //_userManager = userManager;
        //}

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, ImageManager _imageManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            imageManager = _imageManager;
            //_signInManager = signInManager;
            //_userManager = userManager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(ApplicationUser user)
        {
            var x = 0;

            if (ModelState.IsValid)
            {
                imageManager.UploadFile(user.ImageFile, "AppImages");
                var pp = Request.Form["password"];
                var created = await userManager.CreateAsync(user, pp);
                if (created.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("myProfile");
                }
                foreach (var err in created.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return RedirectToAction("Register");
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
