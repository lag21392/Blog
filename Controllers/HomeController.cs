using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspmvc.Models;
using System.Net;
using System.Net.Mail;
using System.Web;


namespace aspmvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Abaut()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public class enviarEmail
        {
            MailMessage m =new MailMessage();
            SmtpClient smtp =new SmtpClient();

            public bool enviarunemail(string to,string mensaje){
                try{
                    string from="";
                    string password="";
                    m.From=new MailAddress(from);
                    m.To.Add(new MailAddress(to));
                    m.Body=mensaje;
                    smtp.Host="smtp.gmail.com";
                    smtp.Port=587;
                    smtp.Credentials=new NetworkCredential(from,password);
                    smtp.EnableSsl=true;
                    smtp.Send(m);
                    return true;
                    
                }
                catch(Exception e){
                    Console.WriteLine(e.StackTrace);
                    return false;
                }
            }
        }
    }
}
