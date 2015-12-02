using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WechatCloud.Debugging.ReverseProxy.Core;

namespace WechatCloud.Debugging.ReverseProxy.Controllers
{
    public class ReverseProxyController : Controller
    {
        public ActionResult Site(string siteBase64)
        {
            var encoding = Encoding.UTF8;
            var bytes = Convert.FromBase64String(siteBase64);
            var site = encoding.GetString(bytes);

            var proxyRequest = (HttpWebRequest)WebRequest.Create(site);
            Request.CopyTo(proxyRequest);

            var proxyResponse = proxyRequest.GetResponse();
            
            foreach (var headerKey in proxyResponse.Headers.AllKeys)
            {
                var header = proxyResponse.Headers[headerKey];
                Response.Headers[headerKey] = header;
            }
            var rs = proxyResponse.GetResponseStream();
            rs.CopyTo(Response.OutputStream);

            return new EmptyResult();
        }


    }

    
}