#pragma checksum "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d5ee84a7a127aa3b056e686a0d6a7d04b6f56fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_CreatePedido), @"mvc.1.0.view", @"/Views/Pedidos/CreatePedido.cshtml")]
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
#line 1 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\_ViewImports.cshtml"
using TrabajoPractico3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\_ViewImports.cshtml"
using TrabajoPractico3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d5ee84a7a127aa3b056e686a0d6a7d04b6f56fd", @"/Views/Pedidos/CreatePedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7bf839e85248c1092b178863b92830b0709ac1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_CreatePedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TrabajoPractico3.Models.Cadete>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mx-auto form-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pedidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AltaPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
  
    ViewData["Title"] = "Crear Pedido";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
 if(Model.Count() > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"section-padding mx-auto seccion-form\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5ee84a7a127aa3b056e686a0d6a7d04b6f56fd5278", async() => {
                WriteLiteral("\r\n        <h2 class=\"mb-5 text-center\"");
                BeginWriteAttribute("id", " id=\"", 329, "\"", 334, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nuevo Pedido</h2>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""far fa-address-card"">Observacion</i></span>
            <input type=""text"" class=""form-control"" placeholder=""Observacion"" aria-label=""Observacion"" aria-describedby=""basic-addon1"" name=""obs"" required>
        </div>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""fas fa-mobile-alt"">Estado</i></span>
            <select class=""form-control"" id=""estado"" name=""estado"" required>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5ee84a7a127aa3b056e686a0d6a7d04b6f56fd6347", async() => {
                    WriteLiteral("En camino");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
                   WriteLiteral(TrabajoPractico3.Models.TipoDeEstados.En_camino);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5ee84a7a127aa3b056e686a0d6a7d04b6f56fd8103", async() => {
                    WriteLiteral("Entregado");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
                   WriteLiteral(TrabajoPractico3.Models.TipoDeEstados.Entregado);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5ee84a7a127aa3b056e686a0d6a7d04b6f56fd9859", async() => {
                    WriteLiteral("No entregado");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
                   WriteLiteral(TrabajoPractico3.Models.TipoDeEstados.No_Entregado);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </select>
        </div><br />

        <label for=""formGroupExampleInput"">Datos del Cliente</label>
        <div class=""input-group"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""fas fa-user"">Nombre y apellido</i></span>
            <input type=""text"" class=""form-control"" placeholder=""Nombre"" aria-label=""Nombre del Cadete"" aria-describedby=""basic-addon1"" name=""nombre"" required>
        </div>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""far fa-address-card"">Dirección</i></span>
            <input type=""text"" class=""form-control"" placeholder=""Direccion"" aria-label=""Direccion"" aria-describedby=""basic-addon1"" name=""direccion"" required>
        </div>
        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""fas fa-mobile-alt"">Teléfono</i></span>
            <input type=""text"" class=""form-control"" placeholder=""Telefono"" aria-label=""Telefono"" ar");
                WriteLiteral(@"ia-describedby=""basic-addon1"" name=""telefono"" required>
        </div>

        <div class=""input-group mt-4"">
            <span class=""input-group-text"" id=""basic-addon1""><i class=""fas fa-mobile-alt"">Seleccione un cadete</i></span>
            <select class=""form-control"" id=""id_cadete"" name=""id_cadete"" required>
");
#nullable restore
#line 41 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d5ee84a7a127aa3b056e686a0d6a7d04b6f56fd13362", async() => {
#nullable restore
#line 43 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
                                        Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </select>\r\n        </div>\r\n        <button class=\"btn btn-primary w-100 mt-4\" type=\"submit\">Añadir Pedido</button>\r\n    ");
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
            WriteLiteral("\r\n</section>  ");
#nullable restore
#line 50 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
            }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>Debe crear al menos un cadete</p>\r\n");
#nullable restore
#line 54 "C:\Taller 2\Trabajos Practicos\tp032121-araasilva\TrabajoPractico3\Views\Pedidos\CreatePedido.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TrabajoPractico3.Models.Cadete>> Html { get; private set; }
    }
}
#pragma warning restore 1591
