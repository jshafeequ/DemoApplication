#pragma checksum "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dd8fbbd0940efd22235e229d77cc44238ddde37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\_ViewImports.cshtml"
using example_empty;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\_ViewImports.cshtml"
using example_empty.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1dd8fbbd0940efd22235e229d77cc44238ddde37", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"849fa94d40bd66a564cb45783bf76c8f4bdb5a6d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<example_empty.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px;height:80px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 40 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Default";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"divdetails\">\r\n\r\n    <table class=\"table table-sm table-bordered table-striped\" id=\"table1\">\r\n        <thead>\r\n            <tr>\r\n");
            WriteLiteral(@"                <th style=""display:none;""></th>
                <th>Name</th>
                <th>Email</th>
                <th>Department</th>
                <th>Image</th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 60 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
              int RowNo = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
             foreach (var Emp in Model)
            {
                var tm = "#myModal" + Emp.Id;
                var mid = "myModal" + Emp.Id;
                var did = Emp.Id;
                var AddPhotopath = "~/images/" + (Emp.AddPhotopath ?? "noimage.jpg");


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n");
            WriteLiteral("                    <td class=\"ID\" style=\"display:none;\">\r\n                        <span>");
#nullable restore
#line 73 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
                         Write(Emp.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 75 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
                   Write(Emp.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 76 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
                   Write(Emp.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 77 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
                   Write(Emp.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1dd8fbbd0940efd22235e229d77cc44238ddde377967", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
                     WriteLiteral(AddPhotopath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 78 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 2239, "\"", 2300, 1);
#nullable restore
#line 80 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
WriteAttributeValue("", 2246, Url.Action("Details","Home",new {id=Emp.EncryptedId}), 2246, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\" id=\"View\">View</a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd8fbbd0940efd22235e229d77cc44238ddde3710668", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
                                                                    WriteLiteral(Emp.EncryptedId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <button type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", "  onclick=\"", 2556, "\"", 2582, 3);
            WriteAttributeValue("", 2567, "deleteemp(", 2567, 10, true);
#nullable restore
#line 82 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
WriteAttributeValue("", 2577, did, 2577, 4, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2581, ")", 2581, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >\r\n                            Delete\r\n                        </button>\r\n\r\n");
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 105 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        function deleteemp(id) {\r\n          \r\n             var url1 = \'");
#nullable restore
#line 115 "D:\EmpiricalEdgeInc\Projects\Demo application\example_empty\example_empty\Views\Home\Index.cshtml"
                    Write(Url.Action("Delete", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
              

            var data = { id: JSON.stringify(id) };
               $.ajax({
                  url: url1,
                  type: ""post"",
                  contentType: 'application/x-www-form-urlencoded',
                  data: data,
                  success: function (result) {
                          if (result == 1) {
                              location.reload();
                          }
                  }
              });
        }
    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<example_empty.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591