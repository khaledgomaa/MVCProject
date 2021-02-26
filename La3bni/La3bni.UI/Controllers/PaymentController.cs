﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Stripe;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La3bni.UI.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IConfiguration configuration;

        public PaymentController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Charge()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Charge(int usdCurrency = 5)
        {
            var domain = configuration["Domain"];
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                  "card",
                },
                LineItems = new List<SessionLineItemOptions>
                {
                  new SessionLineItemOptions
                  {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                      UnitAmount = 100*usdCurrency,
                      Currency = "usd",
                      ProductData = new SessionLineItemPriceDataProductDataOptions
                      {
                        Name = "Stubborn Attachments",
                      },
                    },
                    Quantity = 1,
                  },
                },
                Mode = "payment",
                SuccessUrl = domain + "/Payment/OrderSuccess?session_id={CHECKOUT_SESSION_ID}",
                CancelUrl = domain + "/Payment/Index",
            };
            var service = new SessionService();
            Session session = service.Create(options);
            return Json(new { id = session.Id });
        }

        [HttpGet]
        public ActionResult OrderSuccess([FromQuery] string session_id)
        {
            var sessionService = new SessionService();
            Session session = sessionService.Get(session_id);

            var customerService = new CustomerService();
            Customer customer = customerService.Get(session.CustomerId);

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Cancel()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Pay(string stripeEmail, string stripeToken)
        //{
        //    var customers = new CustomerService();
        //    var charges = new ChargeService();
        //    var customer = customers.Create(new CustomerCreateOptions
        //    {
        //        Email = stripeEmail,
        //        Source = stripeToken
        //    });
        //    var charge = charges.Create(new ChargeCreateOptions
        //    {
        //        Amount = 500,
        //        Currency = "usd",
        //        Customer = customer.Id,
        //        ReceiptEmail = stripeEmail
        //    });

        //    if (charge.Status == "succeeded")
        //    {
        //        string transId = charge.BalanceTransactionId;
        //        return View();
        //    }

        //    return View();
        //}
    }
}