#pragma checksum "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d86450e8321e828a79055a234de38ae3d150ca2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TUsuarios_Details), @"mvc.1.0.view", @"/Views/TUsuarios/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TUsuarios/Details.cshtml", typeof(AspNetCore.Views_TUsuarios_Details))]
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
#line 1 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT;

#line default
#line hidden
#line 2 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86450e8321e828a79055a234de38ae3d150ca2a", @"/Views/TUsuarios/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca981b27afbd8e7d4aba29c8ce9b9955aebba5b", @"/Views/_ViewImports.cshtml")]
    public class Views_TUsuarios_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_SGIAMT.Models.TUsuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(63, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(92, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f53f756bc7f4434e8448ec5617626d2e", async() => {
                BeginContext(98, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(194, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(196, 1920, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0896f244e22a43f49428e6d8bd96b379", async() => {
                BeginContext(202, 104, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>TUsuario</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(307, 44, false);
#line 21 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VuNombre));

#line default
#line hidden
                EndContext();
                BeginContext(351, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(395, 40, false);
#line 24 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.VuNombre));

#line default
#line hidden
                EndContext();
                BeginContext(435, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(479, 46, false);
#line 27 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VuApaterno));

#line default
#line hidden
                EndContext();
                BeginContext(525, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(569, 42, false);
#line 30 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.VuApaterno));

#line default
#line hidden
                EndContext();
                BeginContext(611, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(655, 46, false);
#line 33 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VuAmaterno));

#line default
#line hidden
                EndContext();
                BeginContext(701, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(745, 42, false);
#line 36 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.VuAmaterno));

#line default
#line hidden
                EndContext();
                BeginContext(787, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(831, 53, false);
#line 39 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DuFechaNacimiento));

#line default
#line hidden
                EndContext();
                BeginContext(884, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(928, 49, false);
#line 42 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.DuFechaNacimiento));

#line default
#line hidden
                EndContext();
                BeginContext(977, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1021, 48, false);
#line 45 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VuContraseña));

#line default
#line hidden
                EndContext();
                BeginContext(1069, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1113, 44, false);
#line 48 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.VuContraseña));

#line default
#line hidden
                EndContext();
                BeginContext(1157, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1201, 42, false);
#line 51 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VuSexo));

#line default
#line hidden
                EndContext();
                BeginContext(1243, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1287, 38, false);
#line 54 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.VuSexo));

#line default
#line hidden
                EndContext();
                BeginContext(1325, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1369, 47, false);
#line 57 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VuNacademia));

#line default
#line hidden
                EndContext();
                BeginContext(1416, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1460, 43, false);
#line 60 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.VuNacademia));

#line default
#line hidden
                EndContext();
                BeginContext(1503, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1547, 62, false);
#line 63 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkItuTipoUsuarioNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(1609, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1653, 75, false);
#line 66 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkItuTipoUsuarioNavigation.PkItuTipoUsuario));

#line default
#line hidden
                EndContext();
                BeginContext(1728, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1772, 62, false);
#line 69 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuCodCategoriaNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(1834, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1878, 69, false);
#line 72 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIuCodCategoriaNavigation.PkIcCodCat));

#line default
#line hidden
                EndContext();
                BeginContext(1947, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(1994, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b371bd813ed4d9aa374b55661643d3d", async() => {
                    BeginContext(2045, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
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
#line 77 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarios\Details.cshtml"
                           WriteLiteral(Model.PkIuDni);

#line default
#line hidden
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
                EndContext();
                BeginContext(2053, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(2061, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadb828087164768a90dbf254bc2fb04", async() => {
                    BeginContext(2083, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2099, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2116, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_SGIAMT.Models.TUsuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
