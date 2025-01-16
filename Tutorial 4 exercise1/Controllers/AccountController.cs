using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tutorial_4_exercise1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        //Adding new Sellerregister method so i can use asp-action to be Sellerregister in the html page

        public IActionResult SellerRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(BuyerRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save buyer data (mock or database)
                return RedirectToAction("Login");
            }

            // Return form with validation errors
            return View(model);
        }
        [HttpPost]
        public IActionResult SellerRegister(SellerRegistrationViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Save buyer data (mock or database)
                return RedirectToAction("Login");
            }

            // Return form with validation errors
            return View(model);
        }

        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Mock authentication (you'll check credentials in a real app)
                // For now, just redirect after successful login
                return RedirectToAction("Dashboard");
            }

            // Return the form with validation errors if login fails
            return View(model);
        }

        // Dashboard Page - Redirect here after successful login
        public IActionResult Dashboard()
        {
            ViewBag.Message = "You have successfully logged in!";
            return View();
        }



    }
}