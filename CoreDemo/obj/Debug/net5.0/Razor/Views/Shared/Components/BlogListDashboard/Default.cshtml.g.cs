#pragma checksum "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aba17b2d0c03573962a618098dccb12b09931487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
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
#nullable restore
#line 4 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba17b2d0c03573962a618098dccb12b09931487", @"/Views/Shared/Components/BlogListDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f33039d47efbf86f0686833dd0d216dada1e8708", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_BlogListDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
	<div class=""col-12 grid-margin"">
		<div class=""card"">
			<div class=""card-body"">
				<h4 class=""card-title"">Son 5 Bloq</h4>
				<div class=""table-responsive"">
					<table class=""table"">
						<thead>
							<tr>
								<th> # </th>
								<th> Başlıq </th>
								<th> Kateqoriya </th>
								<th> Tarix </th>
								<th> Ətraflı </th>
							</tr>
						</thead>
						<tbody>
");
#nullable restore
#line 20 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                             foreach (var item in Model.OrderByDescending(x=>x.BlogCreateDate).Take(5))
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 577, "\"", 598, 1);
#nullable restore
#line 24 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 583, item.BlogImage, 583, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\" alt=\"image\">\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 27 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                   Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td>\r\n\t\t\t\t\t\t\t\t\t\t<label class=\"badge badge-gradient-success\">");
#nullable restore
#line 30 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                                                               Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td> ");
#nullable restore
#line 32 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
                                     Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\t\t\t\t\t\t\t\t\t<td> <a");
            BeginWriteAttribute("href", " href=\"", 919, "\"", 956, 2);
            WriteAttributeValue("", 926, "/Blog/BlogReadAll/", 926, 18, true);
#nullable restore
#line 33 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
WriteAttributeValue("", 944, item.BlogID, 944, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Detallar</a> </td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 35 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\BlogListDashboard\Default.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>");
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
