#pragma checksum "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d25cc44e8b8a141a54d8d07136aca0e151dab4ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminRole_Edit), @"mvc.1.0.view", @"/Views/AdminRole/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminRole/Edit.cshtml", typeof(AspNetCore.Views_AdminRole_Edit))]
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
#line 1 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer;

#line default
#line hidden
#line 2 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\_ViewImports.cshtml"
using IdentityServer.Models;

#line default
#line hidden
#line 3 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d25cc44e8b8a141a54d8d07136aca0e151dab4ea", @"/Views/AdminRole/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af0e3306257a42c22138d31482dc27d991993fc2", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminRole_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(107, 77, true);
            WriteLiteral("<div class=\"bg-primary text-white p-1 m-1\">\r\n    <h2>Edit Role</h2>\r\n</div>\r\n");
            EndContext();
            BeginContext(184, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f73984d3ce1247f998612505c58c3223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 9 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(250, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(254, 1558, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2103d7958ca349d795be6440962c9106", async() => {
                BeginContext(292, 42, true);
                WriteLiteral("\r\n\r\n    <input type=\"hidden\" name=\"RoleId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 334, "\"", 356, 1);
#line 13 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 342, Model.Role.Id, 342, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(357, 45, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"RoleName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 402, "\"", 426, 1);
#line 14 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 410, Model.Role.Name, 410, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(427, 55, true);
                WriteLiteral(" />\r\n\r\n    <h6 class=\"p-1 text-white\">\r\n        Add to ");
                EndContext();
                BeginContext(483, 15, false);
#line 17 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
          Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(498, 64, true);
                WriteLiteral("\r\n    </h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 20 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
         if (Model.NonMembers.Count() == 0)
        {

#line default
#line hidden
                BeginContext(618, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">All User Are Members</td></tr>\r\n");
                EndContext();
#line 23 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 26 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
             foreach (var user in Model.NonMembers)
            {

#line default
#line hidden
                BeginContext(786, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(833, 13, false);
#line 29 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(846, 95, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToAdd\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 941, "\"", 957, 1);
#line 31 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 949, user.Id, 949, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(958, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 34 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
            }

#line default
#line hidden
#line 34 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1039, 69, true);
                WriteLiteral("    </table>\r\n\r\n\r\n    <h6 class=\"p-1 text-white\">\r\n        Delete to ");
                EndContext();
                BeginContext(1109, 15, false);
#line 40 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
             Write(Model.Role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1124, 64, true);
                WriteLiteral("\r\n    </h6>\r\n    <table class=\"table table-bordered table-sm\">\r\n");
                EndContext();
#line 43 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
         if (Model.Members.Count() == 0)
        {

#line default
#line hidden
                BeginContext(1241, 64, true);
                WriteLiteral("            <tr><td colspan=\"2\">No Users Are Members</td></tr>\r\n");
                EndContext();
#line 46 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 49 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
             foreach (var user in Model.Members)
            {

#line default
#line hidden
                BeginContext(1406, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1453, 13, false);
#line 52 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
                   Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1466, 98, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        <input type=\"checkbox\" name=\"IdsToDelete\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1564, "\"", 1580, 1);
#line 54 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
WriteAttributeValue("", 1572, user.Id, 1572, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1581, 55, true);
                WriteLiteral(" />\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 57 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
            }

#line default
#line hidden
#line 57 "C:\Users\Mustafa ALKAN\source\repos\IdentityServer\IdentityServer\Views\AdminRole\Edit.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1662, 83, true);
                WriteLiteral("    </table>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n    ");
                EndContext();
                BeginContext(1745, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a213545eca214cedbde4ee9eaa5c840d", async() => {
                    BeginContext(1793, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1803, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
