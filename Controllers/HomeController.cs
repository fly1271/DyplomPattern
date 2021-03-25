using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiplomProject.Models;
using DiplomProject.Domain;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace DiplomProject.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Checking()
        {

            return View();
        }

        public IActionResult Information()
        {
            return View();
        }
        public IActionResult Contact()
        {
            
            return View();
        }
        public HomeController(AppDbContext contex)
        {
            db = contex;
        }
        private AppDbContext db;

        [HttpPost]
        public IActionResult getting(InfoAp infoAp)
        {

        
            db.infoAps.Add(infoAp);
            db.SaveChanges();
            return View("Index");
            //return $" Полученная инфа услуга - {name} , описание - {info} , номер телефона - {phone}";
        }

        [HttpPost]
        public string checking(int num)
        {
            string wow = "";
            try
            {
                var res = db.infoAps.FromSql("SELECT *from infoAps where ID like {0}", num).ToList();
                if (res.Count > 0)
                {
                    foreach (var company in res)
                        wow = company.Info + " " + company.Adress + " "
                            + company.ID + " " + company.Phone;
                }
                else
                    wow = " Нет такого заказа!";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return $"{wow}";
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
