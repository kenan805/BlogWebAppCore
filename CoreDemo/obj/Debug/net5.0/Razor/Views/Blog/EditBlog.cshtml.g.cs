#pragma checksum "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a90ee8b73758cb8ba947e3bc8e7b0e94a2671cee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a90ee8b73758cb8ba947e3bc8e7b0e94a2671cee", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f33039d47efbf86f0686833dd0d216dada1e8708", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
  
	ViewData["Title"] = "EditBlog";
	Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Bloq redaktə səhifəsi</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
	

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Bloq Id"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogID, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n");
#nullable restore
#line 15 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Bloq Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogTitle, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n");
#nullable restore
#line 18 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Bloq Thumnail Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogThumbnailImage, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n");
#nullable restore
#line 21 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Bloq Şəkili"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x=>x.BlogImage, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n");
#nullable restore
#line 24 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Bloq Kateqoriyası"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x=>x.CategoryID, (List<SelectListItem>)ViewBag.categoryValues, "Kateqoriya seçin", new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n");
#nullable restore
#line 27 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Bloq Kontenti"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x=>x.BlogContent,10,3, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br />\r\n\t<button class=\"btn btn-success\">Yenilə</button>\r\n");
#nullable restore
#line 31 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Views\Blog\EditBlog.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
