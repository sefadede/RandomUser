using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RandomUser.Context;
using RandomUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RandomUser.Controllers
{
    public class HomeController : Controller
    {
        List<User> persons=new List<User>();

        TableContext context = new TableContext();
        public async Task<IActionResult> Index()
        {
            //return View(context.Users.ToList());

            string url = "https://randomuser.me/api/?format=json";
            WebClient client = new WebClient();
            var data = client.DownloadString(url);
            var json = JsonConvert.DeserializeObject<Root>(data);
            foreach (var item in json.results)
            {
                persons.Add(item);
            }
            return View(persons);
        }

        public ViewResult GetUser() => View();

        [HttpPost]
        public async Task<IActionResult> GetUser(int id)
        {
            
            //User user = new User();
            //string url = "https://randomuser.me/api/?format=json" + id;
            //WebClient client = new WebClient();
            //var data = client.DownloadString(url);
            //var json = JsonConvert.DeserializeObject<Root>(data);
            //user = json.results[0];
            
            return View(context.Users.ToList().FirstOrDefault());
        }
        public ViewResult AddUser() => View();

        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {

            context.Users.Add(user);
            context.SaveChanges();


            return View("Index");

            //User myUser = new User();
            //using (var httpClient = new HttpClient())
            //{
            //    StringContent content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

            //    using (var response = await httpClient.PostAsync("https://randomuser.me/api/?format=json", content))
            //    {
            //        string apiResponse = await response.Content.ReadAsStringAsync();
            //        myUser = JsonConvert.DeserializeObject<User>(apiResponse);
            //    }
            //}
            //return View(myUser);
        }

    }
}
