
using Ganss.XSS;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;

namespace MyGovCMS.Core.Extensions

{
    public static class HtmlExtensions
    {
        public static IHtmlString GetGridHtml(this HtmlHelper html, IPublishedContent contentItem, string framework, string propertyAlias, bool fluidImages)
        {
            HtmlSanitizer obj = new HtmlSanitizer();
            
            if (fluidImages)
            {
                return html.Raw(obj.Sanitize(html.GetGridHtml(contentItem, framework, propertyAlias).ToString().Replace("<img ", "<img class=\"img-fluid\" ")));
                //return html.Raw(html.GetGridHtml(contentItem, framework, propertyAlias).ToString().Replace("script", " ").Replace("onerror=", " ").Replace("onmouseover=", " ").Replace("alert", " ").Replace("<img ", "<img class=\"img-fluid\" "));
            }
            else
            {
                return html.GetGridHtml(contentItem,propertyAlias, framework);
            }
        }
    }
}