#pragma checksum "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb8cd59fe9e9e334dbf6081db7271385f597aebe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesPerson_Index), @"mvc.1.0.view", @"/Views/SalesPerson/Index.cshtml")]
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
#line 1 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\_ViewImports.cshtml"
using XYZSports.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\_ViewImports.cshtml"
using XYZSports.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb8cd59fe9e9e334dbf6081db7271385f597aebe", @"/Views/SalesPerson/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"234ab92fa5dce5ce2cb1d251b969d3f4276dcdca", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesPerson_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<XYZSports.Models.Salesperson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml"
   
    ViewBag.Title = "Sales Team";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<h2>Sales Team</h2>
<table style=""border-spacing:1.5em;border-collapse:inherit"">
    <thead>
        <tr>
            <td> Name </td>
            <td> Email </td>
            <td> Orders </td>
            <td> State </td>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 16 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml"
         foreach (var person in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb8cd59fe9e9e334dbf6081db7271385f597aebe4204", async() => {
#nullable restore
#line 19 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml"
                                                               Write(person.FullName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml"
                                           WriteLiteral(person.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 20 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml"
                Write(person.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 21 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml"
                Write(person.Order.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 22 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml"
                Write(person.SalesGroupState);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\R2D2\software-architectures\XYZSports\XYZSports.Web\Views\SalesPerson\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<XYZSports.Models.Salesperson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
