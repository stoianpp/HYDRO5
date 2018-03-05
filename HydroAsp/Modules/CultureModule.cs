using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace HydroAsp.Modules
{
    public class CultureModule : IHttpModule
    {
        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += this.BeginRequest_1;
            
        }

        private void BeginRequest_1(object sender, EventArgs e)
        {
            var path = System.Web.HttpContext.Current.Request.Url.ToString().Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            if (path.Length > 2)
            {
                switch (path[2])
                {
                    case "bg": Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG"); break;
                    case "en": Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-GB"); break;
                    default: ; break;
                }
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("bg-BG");
            }
        }
    }
}