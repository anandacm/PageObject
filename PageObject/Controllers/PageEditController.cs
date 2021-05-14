using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using PageObject.Models;
using RazorEngine.Templating;

namespace PageObject.Controllers
{
  
   
    public class PageEditController : Controller
    {
        // GET: PageEdit
        public ActionResult Index()
        {

            return View();
        }

        /// <summary>
        /// Create a PageObject and build view
        /// </summary>
        /// <returns></returns>
        [ValidateInput(false)]
        public ActionResult getpage()
        {
            PageObject.Models.PageObject  po = new PageObject.Models.PageObject();

          
            var rawComment = Request.Unvalidated().Form["content"];
            po.Content = rawComment;

            //var templateService = new TemplateService();
            //var emailHtmlBody = templateService.Parse(File.ReadAllText(welcomeEmailTemplatePath), stronglyTypedModel, null, null);

            string myParsedTemplate = RazorEngine.Engine.Razor.RunCompile(po.Content, "templateNameInTheCache", null, po);

         
       
            return View("Index",po);
  
        }
    }
}