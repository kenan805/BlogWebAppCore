#pragma checksum "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3beef99b17fec326c2c42ede0d9a971257a592f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3beef99b17fec326c2c42ede0d9a971257a592f", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca0fc599d5f51e519f75ff6712b592ffabce4a7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
	ViewData["Title"] = "BlogListByWriter";
	Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Yazarin bloqlari</h1>\r\n\r\n<table class=\"table table-bordered\">\r\n\t<tr>\r\n\t\t<th>#</th>\r\n\t\t<th>Bloq başlığı</th>\r\n\t\t<th>Yaranma tarixi</th>\r\n\t\t<th>Categoriya</th>\r\n\t\t<th>Vəziyyət</th>\r\n\t\t<th>Sil</th>\r\n\t\t<th>Redaktə et</th>\r\n\t</tr>\r\n");
#nullable restore
#line 20 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\t\t\t<th>");
#nullable restore
#line 23 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t<td>");
#nullable restore
#line 24 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 25 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
            Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 26 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 27 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
             if (item.BlogStatus)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<td class=\"badge badge-success\">Active</td>\r\n");
#nullable restore
#line 30 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<td class=\"badge badge-secondary\">Passive</td>\r\n");
#nullable restore
#line 34 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<td>\r\n\t\t\t<td><a href=\"#\" class=\"btn btn-danger\">Sil</a></td>\r\n\t\t\t<td><a href=\"#\" class=\"btn btn-warning\">Redaktə et</a></td>\r\n\t\t</tr>\r\n");
#nullable restore
#line 39 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"#\" class=\"btn btn-primary\">Yeni Bloq yarat</a>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
