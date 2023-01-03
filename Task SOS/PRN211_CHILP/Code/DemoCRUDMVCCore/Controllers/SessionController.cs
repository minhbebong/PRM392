using DemoCRUDMVCCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCRUDMVCCore.Controllers
{
    public class SessionController : Controller
    {
        public string SetSession()
        {
            HttpContext.Session.SetInt32("id", 12);
            HttpContext.Session.SetString("user", "hoangnv");
            Course c = new Course();
            c.CourseId = 1;
            c.CourseCode = "PRN211";
            c.CourseDescription = "C# & .NET";
            string jsonStr = JsonConvert.SerializeObject(c);
            HttpContext.Session.SetString("course", jsonStr);

            Dictionary<int, int> cart = new Dictionary<int, int>();
            cart.Add(1, 1);
            cart.Add(2, 1);
            cart.Add(3, 10);
            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cart));
            return $"Set session";
        }

        public string ShowSession()
        {
            int? id = HttpContext.Session.GetInt32("id");
            string? user = HttpContext.Session.GetString("user");
            string jsonStr = HttpContext.Session.GetString("course");
            Course c;
            if (jsonStr is null) c = new Course();
            else c = JsonConvert.DeserializeObject<Course>(jsonStr);

            string cartStr = HttpContext.Session.GetString("cart");
            Dictionary<int, int> cart = new Dictionary<int, int>();
            if (cartStr != null)
                cart = JsonConvert.DeserializeObject<Dictionary<int, int>>(cartStr);
            string s = "";
            
            foreach (int key in cart.Keys)
                s += $"{key}: {cart[key]}" + Environment.NewLine;

            return $"Id: {id} User: {user}" + Environment.NewLine + 
                $"Course: {c.CourseId} {c.CourseCode} {c.CourseDescription}" + Environment.NewLine +
                $"Cart:{s}" ;
        }
    }
}
