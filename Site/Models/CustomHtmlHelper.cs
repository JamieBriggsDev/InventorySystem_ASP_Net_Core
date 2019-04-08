using System.Text;

namespace System.Web.Mvc
{
    public static class CustomHtmlHelper
    {
        public static MvcHtmlString SubmitButton(this HtmlHelper helper, string buttonText, object htmlAttributes = null)
        {
            StringBuilder html = new StringBuilder();
            html.AppendFormat("<input type = 'submit' value = '{0}' ", buttonText);
            //{ class = btn btn-default, id = create-button }
            var attributes = helper.AttributeEncode(htmlAttributes);
            if (!string.IsNullOrEmpty(attributes))
            {
                attributes = attributes.Trim('{', '}');
                var attrValuePairs = attributes.Split(',');
                foreach (var attrValuePair in attrValuePairs)
                {
                    var equalIndex = attrValuePair.IndexOf('=');
                    var attrValue = attrValuePair.Split('=');
                    html.AppendFormat("{0}='{1}' ", attrValuePair.Substring(0, equalIndex).Trim(), attrValuePair.Substring(equalIndex + 1).Trim());
                }
            }
            html.Append("/>");
            return new MvcHtmlString(html.ToString());
        }
    }
}