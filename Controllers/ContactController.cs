using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using BlogSiteWithUmbraco.Models;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Services;
using Umbraco.Web;

namespace BlogSiteWithUmbraco.Controllers
{
    public class ContactController : SurfaceController
    {
        //private IEntityService _entityService;
        //public ContactController(IEntityService entityService)
        //{
        //    _entityService = entityService;
        //}

        [HttpGet]
        public ActionResult GetContact(int CurrentPage)
        {
            ViewData["CurrentPage"] = CurrentPage;
            return PartialView("ContactForm/PartialContact");
        }

        [HttpPost]
        public ActionResult PostContact(ContactModel contactModel, int CurrentPage)
        {
            var contact = Services.ContentService.CreateContent(
                    String.Format("{0} {1} - {2}", contactModel.FirstName, contactModel.LastName, contactModel.Phone),
                    CurrentPage,
                    "contactForm"
                );
            contact.SetValue("firstName", contactModel.FirstName);
            contact.SetValue("lastName", contactModel.LastName);
            contact.SetValue("phone", contactModel.Phone);
            contact.SetValue("email", contactModel.Email);
            contact.SetValue("message", contactModel.Message);
            Services.ContentService.SaveAndPublishWithStatus(contact);
            return RedirectToUmbracoPage(CurrentPage);
        }
    }
}
