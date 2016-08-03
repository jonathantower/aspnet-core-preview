using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace Samples.TagHelpers
{
	[HtmlTargetElement("email")]
	public class EmailTagHelper : TagHelper
	{
		private const string EmailDomain = "contoso.com";

		// Can be passed via <email mail-to="..." />. 
		// Pascal case gets translated into lower-kebab-case.
		public string MailTo { get; set; }

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "a";    // Replaces <email> with <a> tag

			var address = MailTo + "@" + EmailDomain;
			output.Attributes.SetAttribute("href", "mailto:" + address);
			output.Content.SetContent(address);
		}
	}
}