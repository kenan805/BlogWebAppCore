#pragma checksum "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f4b16c7e435cbce4fa7015fbc53b82dce7cf0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f4b16c7e435cbce4fa7015fbc53b82dce7cf0d", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce28585c9a8127438679c523d08e584c7039349a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
  
	ViewData["Title"] = "Index";
	Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>

<h1>Kateqoriya listi</h1>
<br />
<table class=""table table-bordered"">

	<tr>
		<th>#</th>
		<th>Kateqoriya</th>
		<th>Deaktiv et</th>
		<th>Aktiv et</th>
		<th>Redaktə et</th>
	</tr>
");
#nullable restore
#line 21 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
     foreach (var item in Model)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<tr>\r\n\t\t\t<td>");
#nullable restore
#line 24 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>");
#nullable restore
#line 25 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t<td>\r\n\t\t\t\t<p>\r\n\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 534, "\"", 588, 2);
            WriteAttributeValue("", 541, "/Admin/Category/CategoryDelete/", 541, 31, true);
#nullable restore
#line 28 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 572, item.CategoryID, 572, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmək istədiyinizə əminsiniz ?\')\" class=\"btn btn-secondary\">Deaktiv et</a>\r\n\t\t\t\t</p>\r\n\t\t\t</td>\r\n\t\t\t<td><a href=\"#\" class=\"btn btn-info\">Aktiv et</a></td>\r\n\t\t\t<td><a href=\"#\" class=\"btn btn-success\">Redaktə et</a></td>\r\n\t\t</tr>\r\n");
#nullable restore
#line 34 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Admin/Category/AddCategory\" class=\"btn btn-primary\">Yeni kateqoriya</a>\r\n<br />\r\n");
#nullable restore
#line 38 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Category\Index.cshtml"
Write(Html.PagedListPager(Model, page=>Url.Action("Index", "Category", new { page })));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
