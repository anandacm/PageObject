using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PageObject.Models
{

    public class PageObject
        {

        public string Title { get; set; } = "Untitled";
        [AllowHtml]
        public string Content { get; set; }

        }
}