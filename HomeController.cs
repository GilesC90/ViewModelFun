using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;


namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            Paragraph someText = new Paragraph()
            {
                Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
            };
            return View("Index", someText);
        }
        [HttpGet("/numbers")]
        public IActionResult Numbers()
        {
            Numerals nums = new Numerals()
            {
                Nums = (1, 2, 3, 4, 5)
            };
            return View("Numerals", nums);
        }
        [HttpGet("/users")]
        public IActionResult Users()
        {
            Users list = new Users()
            {
                UserList = new List<string>()
            {
                new string("Moose Phillips"),            
                new string("Sarah"),            
                new string("Jerry"),            
                new string("Rene Ricky"),            
                new string("Barbarah")            
            }};
            // var message = string.Join(",", list);
            return View("Users", list);
        }
        [HttpGet("/user")]
        public IActionResult OneUser()
        {
            User user = new User()
            {
                OneUser = "Moose Phillips"
            };
            return View("User", user);
        }
    }
}