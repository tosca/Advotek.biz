using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Advotek.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HPproducts()
        {
            return View();
        }

        public ActionResult HPprinters()
        {
            return View();
        }

        public ActionResult HPprinterFinder()
        {
            return View();
        }

        public ActionResult HPsuppliesFinder()
        {
            return View();
        }

       // public ActionResult Contact()
       // {
       //     return View();
       // }

        public ActionResult HPbusinessUpgradeTool()
        {
            return View();
        }
        public ActionResult HPeliteBookFamily()
        {
            return View();
        }
        public ActionResult HPenterpriseGroup()
        {
            return View();
        }
        public ActionResult HPhelpdesk()
        {
            return View();
        }
        public ActionResult HPimagePrintPromo()
        {
            return View();
        }
        public ActionResult HPK12Education()
        {
            return View();
        }
        public ActionResult HPmobility()
        {
            return View();
        }
        public ActionResult HPofficeProFamily()
        {
            return View();
        }
        public ActionResult HPPCupgradetool()
        {
            return View();
        }
        public ActionResult HPPrintImageCarePack()
        {
            return View();
        }
        public ActionResult HPproFamily()
        {
            return View();
        }
        public ActionResult HPscanJetScanners()
        {
            return View();
        }       

        public ActionResult HPwindows10()
        {
            return View();
        }
        public ActionResult HPworkstationFamily()
        {
            return View();
        }
        public ActionResult originalHPsupplies()
        {
            return View();
        }


        [HttpGet]
        public ActionResult ContactForm()
        {
            ViewBag.Message = "Your contact page.";

            return View(new ContactInfo());
        }
        [HttpPost]
        public ActionResult Contact(ContactInfo contact)
        {

            var Name = contact.Name;
            var contactEmail = contact.ContactEmail;
            var contactPhone = contact.ContactPhone;
            var contactMessage = contact.ContactMessage;
            SendEmail(Name, contactEmail, contactPhone, contactMessage);
            return RedirectToAction("Index");
        }

        public ActionResult ContactSubmited()
        {

            var result = new FilePathResult("~/Views/Home/Index.html", "text/html");
            return result;

        }


        public void SendEmail(string Name, string contactEmail, string contactPhone, string contactMessage)
        {
            string mailgunKey = System.Configuration.ConfigurationManager.AppSettings["MAILGUN_API_KEY"];
            if (String.IsNullOrEmpty(mailgunKey))
            {
                throw new Exception("Mailgun api key missing");
            }
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                    new HttpBasicAuthenticator("api",
                                               mailgunKey);

            RestRequest request = new RestRequest();
            request.AddParameter("domain",
                                 System.Configuration.ConfigurationManager.AppSettings["MAILGUN_DOMAIN"],
                                 ParameterType.UrlSegment);
            request.Resource = "{domain}/messages";
            request.AddParameter("from", "Paula - inquiry <mailgun@mailgun.org>");
            request.AddParameter("to", "tosca.ragnini@gmail.com, paula@advotek.biz");
            request.AddParameter("subject", "Advotek - Contact Request");
            request.AddParameter("text", "Name : " + Name);
            request.AddParameter("text", "ContactEmail : " + contactEmail);
            request.AddParameter("text", "ContactPhone : " + contactPhone);
            request.AddParameter("text", "ContactMessage : " + contactMessage);
            request.Method = Method.POST;
            var result = client.Execute(request);
            return;
        }


    }


    public class ContactInfo
    {
        public string Name { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMessage { get; set; }

    }

}

