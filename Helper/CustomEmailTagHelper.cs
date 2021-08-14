using Microsoft.AspNetCore.Razor.TagHelpers;

namespace BookStore.Helper
{
    public class CustomEmailTagHelper : TagHelper
    {
      public override void Process(TagHelperContext context,TagHelperOutput output)
      {
         output.TagName="a";
         output.Attributes.SetAttribute("href","mailto:lokeshdotg1@gmail.com");
         output.Attributes.Add("id","my-email-id");
         output.Content.SetContent("my-email");
      } 
    }
}