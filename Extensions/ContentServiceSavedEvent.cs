using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Events;
using Umbraco.Core.Models;
using Umbraco.Core.Publishing;
using Umbraco.Core.Services;
using Umbraco.Core;

namespace BlogSiteWithUmbraco.Extensions
{
    public class ContentServiceSavedEvent : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            ContentService.Saved += ContentServiceSaved;
        }

        private void ContentServiceSaved(IContentService sender, SaveEventArgs<IContent> e)
        {
            foreach (var node in e.SavedEntities)
            {
                if (node.ContentType.Alias == "contactForm")
                {
                    var reply = node.Properties.First(x => x.Alias == "reply").Value;
                    if (reply != null)
                    {
                        var email = node.Properties.First(x => x.Alias == "email").Value.ToString();
                        SendEmail.SendSync(email, "Contact Reply", reply.ToString());
                    }
                }
            }
        }
    }
}