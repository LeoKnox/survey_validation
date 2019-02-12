using System;
using Microsoft.AspNetCore.Mvc;
using survey_validation.Models;

namespace survey_validation
{
    public class HelloController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Valid(User user)
        {
            if(ModelState.IsValid)
            {
                return View("Result", user);
            }
            else
            {
                return View("Index");
            }
        }
    }
}