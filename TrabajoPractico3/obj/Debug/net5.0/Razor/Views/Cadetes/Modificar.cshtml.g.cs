#pragma checksum "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdda501d1e4f1a496bd8e76682c36df79bf35d08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadetes_Modificar), @"mvc.1.0.view", @"/Views/Cadetes/Modificar.cshtml")]
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
#line 1 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\_ViewImports.cshtml"
using TrabajoPractico3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\_ViewImports.cshtml"
using TrabajoPractico3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdda501d1e4f1a496bd8e76682c36df79bf35d08", @"/Views/Cadetes/Modificar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bf839e85248c1092b178863b92830b0709ac1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadetes_Modificar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrabajoPractico3.Models.Cadete>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto form-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cadetes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModificarCadete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml"
   
    ViewData["Title"] = "Modificar Cadete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"section-padding mx-auto seccion-form\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdda501d1e4f1a496bd8e76682c36df79bf35d084841", async() => {
                WriteLiteral("\r\n        <h2 class=\"mb-5 text-center\">Modificar Cadete</h2>\r\n        <div class=\"input-group\">\r\n            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 385, "\"", 402, 1);
#nullable restore
#line 10 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml"
WriteAttributeValue("", 393, Model.Id, 393, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" required>\r\n        </div>\r\n        <div class=\"input-group\">\r\n            <span class=\"input-group-text\" id=\"basic-addon1\"><i class=\"fas fa-user\">Nombre Completo</i></span>\r\n            <input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 639, "\"", 660, 1);
#nullable restore
#line 14 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml"
WriteAttributeValue("", 647, Model.Nombre, 647, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 661, "\"", 688, 1);
#nullable restore
#line 14 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml"
WriteAttributeValue("", 675, Model.Nombre, 675, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" aria-describedby=""basic-addon1"" name=""nombre"" required>
        </div>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""far fa-address-card"">Direccion</i></span>
            <input type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 968, "\"", 992, 1);
#nullable restore
#line 18 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml"
WriteAttributeValue("", 976, Model.Direccion, 976, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 993, "\"", 1023, 1);
#nullable restore
#line 18 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml"
WriteAttributeValue("", 1007, Model.Direccion, 1007, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" aria-describedby=""basic-addon1"" name=""direccion"" required>
        </div>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""fas fa-mobile-alt"">Telefono</i></span>
            <input type=""text"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 1303, "\"", 1326, 1);
#nullable restore
#line 22 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml"
WriteAttributeValue("", 1311, Model.Telefono, 1311, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1327, "\"", 1356, 1);
#nullable restore
#line 22 "C:\Users\Alumno\Desktop\Tp- taller2\Tp4\TrabajoPractico3\Views\Cadetes\Modificar.cshtml"
WriteAttributeValue("", 1341, Model.Telefono, 1341, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" aria-describedby=\"basic-addon1\" name=\"telefono\" required>\r\n        </div>\r\n        <button class=\"btn btn-primary w-100 mt-4\" type=\"submit\">Modificar</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrabajoPractico3.Models.Cadete> Html { get; private set; }
    }
}
#pragma warning restore 1591
