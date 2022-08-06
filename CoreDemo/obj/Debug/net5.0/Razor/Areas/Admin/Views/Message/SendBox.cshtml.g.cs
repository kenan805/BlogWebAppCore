#pragma checksum "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Message\SendBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bc677038f2bc2c9a4196bac1e60a2c899cf4e1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Message_SendBox), @"mvc.1.0.view", @"/Areas/Admin/Views/Message/SendBox.cshtml")]
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
#nullable restore
#line 7 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\_ViewImports.cshtml"
using CoreDemo.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bc677038f2bc2c9a4196bac1e60a2c899cf4e1c", @"/Areas/Admin/Views/Message/SendBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95247a32f69834c6276ba81f6992bf19fc08d6c", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Message_SendBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message2>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right mail-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Message\SendBox.cshtml"
  
    ViewData["Title"] = "SendBox";
    Layout = "~/Areas/Admin/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bc677038f2bc2c9a4196bac1e60a2c899cf4e1c5985", async() => {
                WriteLiteral(@"
	<div class=""wrapper wrapper-content"">
		<div class=""row"">
			<div class=""col-lg-3"">
				<div class=""ibox "">
					<div class=""ibox-content mailbox-content"">
						<div class=""file-manager"">
							<a class=""btn btn-block btn-primary compose-mail"" href=""mail_compose.html"">Mesaj qutusu</a>
							<div class=""space-25""></div>
							<h5>Folders</h5>
							<ul class=""folder-list m-b-md"" style=""padding: 0"">
								<li><a href=""/Admin/Message/Inbox""> <i class=""fa fa-inbox ""></i> Gələn mesajlar <span class=""label label-warning float-right"">16</span> </a></li>
								<li><a href=""/Admin/Message/SendBox""> <i class=""fa fa-envelope-o""></i> Gedən mesajar </a></li>
								<li><a href=""mailbox.html""> <i class=""fa fa-certificate""></i> Vacib mesajlar</a></li>
								<li><a href=""mailbox.html""> <i class=""fa fa-file-text-o""></i> Drafts <span class=""label label-danger float-right"">2</span></a></li>
								<li><a href=""mailbox.html""> <i class=""fa fa-trash-o""></i> Trash</a></li>
							</ul>
							<h5>Cat");
                WriteLiteral(@"egories</h5>
							<ul class=""category-list"" style=""padding: 0"">
								<li><a href=""#""> <i class=""fa fa-circle text-navy""></i> Work </a></li>
								<li><a href=""#""> <i class=""fa fa-circle text-danger""></i> Documents</a></li>
								<li><a href=""#""> <i class=""fa fa-circle text-primary""></i> Social</a></li>
								<li><a href=""#""> <i class=""fa fa-circle text-info""></i> Advertising</a></li>
								<li><a href=""#""> <i class=""fa fa-circle text-warning""></i> Clients</a></li>
							</ul>

							<div class=""clearfix""></div>
						</div>
					</div>
				</div>
			</div>
			<div class=""col-lg-9 animated fadeInRight"">
				<div class=""mail-box-header"">

					");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bc677038f2bc2c9a4196bac1e60a2c899cf4e1c8058", async() => {
                    WriteLiteral(@"
						<div class=""input-group"">
							<input type=""text"" class=""form-control form-control-sm"" name=""search"" placeholder=""Search email"">
							<div class=""input-group-btn"">
								<button type=""submit"" class=""btn btn-sm btn-primary"">
									Axtar
								</button>
							</div>
						</div>
					");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
					<h2>
						Gedən qutusu (0)
					</h2>
					<div class=""mail-tools tooltip-demo m-t-md"">
						<div class=""btn-group float-right"">
							<button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-left""></i></button>
							<button class=""btn btn-white btn-sm""><i class=""fa fa-arrow-right""></i></button>

						</div>
						<button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""left"" title=""Yenilə""><i class=""fa fa-refresh""></i> Refresh</button>
						<button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Oxundu olaraq işarələ""><i class=""fa fa-eye""></i> </button>
						<button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Vacib olaraq işarələ""><i class=""fa fa-exclamation""></i> </button>
						<button class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Silindi olaraq işarələ""><i class=""fa fa-trash-o""></i> </button>

					</div>
				</div>
				<div class=""mail-box"">

					<table ");
                WriteLiteral("class=\"table table-hover table-mail\">\r\n\t\t\t\t\t\t<tbody>\r\n");
#nullable restore
#line 75 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Message\SendBox.cshtml"
                             foreach (var item in Model)
							{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t\t\t<tr class=\"unread\">\r\n\t\t\t\t\t\t\t\t\t<td class=\"check-mail\">\r\n\t\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" class=\"i-checks\">\r\n\t\t\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\t<td class=\"mail-ontact\"><a href=\"mail_detail.html\">");
#nullable restore
#line 81 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Message\SendBox.cshtml"
                                                                                  Write(item.ReceiverWriter.WriterName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\t\t\t\t\t\t\t\t\t<td class=\"mail-subject\"><a href=\"mail_detail.html\">");
#nullable restore
#line 82 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Message\SendBox.cshtml"
                                                                                   Write(item.Subject);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></td>\r\n\t\t\t\t\t\t\t\t\t<td class=\"text-right mail-date\">");
#nullable restore
#line 83 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Message\SendBox.cshtml"
                                                                Write(item.MessageDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n");
#nullable restore
#line 85 "C:\Users\user\source\repos\CoreDemo\CoreDemo\Areas\Admin\Views\Message\SendBox.cshtml"
							}

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t\t</tbody>\r\n\t\t\t\t\t</table>\r\n\r\n\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message2>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
