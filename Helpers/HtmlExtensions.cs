using System.Web;
using System.Web.Mvc;

namespace ProjekatPsa.Helpers
{
    public static class HtmlExtensions
    {
        public static IHtmlString SectionTitle(this HtmlHelper html, string text)
        {
            var tag = new TagBuilder("h2");
            tag.AddCssClass("section-title");
            tag.SetInnerText(text);
            return new MvcHtmlString(tag.ToString());
        }
    }
}
