#pragma checksum "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d8cbb2f1c0dcd71ee5d56b9b45a0c05bbb29c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LandingPage), @"mvc.1.0.view", @"/Views/Home/LandingPage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\_ViewImports.cshtml"
using homecoming.webapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\_ViewImports.cshtml"
using homecoming.webapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
using homecoming.webapp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d8cbb2f1c0dcd71ee5d56b9b45a0c05bbb29c98", @"/Views/Home/LandingPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53b6caf8dd4338175d51ef9c15eacd1d128426b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LandingPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BusinessViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div>\r\n        <h5 class=\"acc\">Browse Accomodations</h5>\r\n");
#nullable restore
#line 10 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n");
#nullable restore
#line 13 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
             foreach (var item in Model)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card align-content-center\" style=\"display: inline-block; width: 18rem; margin: 2px; border-radius: 5px; margin-top: 5px\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 539, "\"", 618, 2);
            WriteAttributeValue("", 545, "https://fileblob20.blob.core.windows.net/cloud-upload/", 545, 54, true);
#nullable restore
#line 17 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
WriteAttributeValue("", 599, item.CoverPhotoUrl, 599, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"BusinessImage\" width=\"200\" height=\"200\" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
                                          Write(item.BusinessName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <hr />\r\n                        <div class=\"text-center\">\r\n                            ");
#nullable restore
#line 22 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
                       Write(Html.ActionLink("Browse Accomodation", "AccomodationsPage", "Home", new { id = item.BusinessId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>           \r\n");
#nullable restore
#line 26 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("             </div>\r\n");
#nullable restore
#line 28 "C:\Users\codeD\Desktop\Honours\Software Engineering Project\homecoming.ui\homecoming.webapp\Views\Home\LandingPage.cshtml"
        }       

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BusinessViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591