#pragma checksum "D:\Coding dojo\codingdojo_csharp\Curd\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "148f84b338bc07487cc75d8007a4d6560eca6beb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
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
#line 1 "D:\Coding dojo\codingdojo_csharp\Curd\Views\_ViewImports.cshtml"
using Curd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding dojo\codingdojo_csharp\Curd\Views\_ViewImports.cshtml"
using Curd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"148f84b338bc07487cc75d8007a4d6560eca6beb", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"481779978355e79c45056fd08076acc6e4e37171", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"text-center\">\r\n<h1>");
#nullable restore
#line 5 "D:\Coding dojo\codingdojo_csharp\Curd\Views\Home\Info.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h1>");
#nullable restore
#line 6 "D:\Coding dojo\codingdojo_csharp\Curd\Views\Home\Info.cshtml"
Write(Model.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n</div>\r\n<P><a href=\"/\">Home</a></P>\r\n\r\n<p>");
#nullable restore
#line 11 "D:\Coding dojo\codingdojo_csharp\Curd\Views\Home\Info.cshtml"
Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Calories :");
#nullable restore
#line 12 "D:\Coding dojo\codingdojo_csharp\Curd\Views\Home\Info.cshtml"
        Write(Model.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Tastiness :");
#nullable restore
#line 13 "D:\Coding dojo\codingdojo_csharp\Curd\Views\Home\Info.cshtml"
         Write(Model.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 230, "\"", 258, 3);
            WriteAttributeValue("", 237, "/", 237, 1, true);
#nullable restore
#line 15 "D:\Coding dojo\codingdojo_csharp\Curd\Views\Home\Info.cshtml"
WriteAttributeValue("", 238, Model.DishId, 238, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 251, "/delete", 251, 7, true);
            EndWriteAttribute();
            WriteLiteral("><button>Delete</button></a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 291, "\"", 317, 3);
            WriteAttributeValue("", 298, "/", 298, 1, true);
#nullable restore
#line 16 "D:\Coding dojo\codingdojo_csharp\Curd\Views\Home\Info.cshtml"
WriteAttributeValue("", 299, Model.DishId, 299, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 312, "/edit", 312, 5, true);
            EndWriteAttribute();
            WriteLiteral("><button>Edit</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
