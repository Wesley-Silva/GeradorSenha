#pragma checksum "C:\dev\GeradorSenha\GeradorSenha\Views\Home\GerarSenha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67afdc9d69a2f0a9ab7448151443f4a8679e4f40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GerarSenha), @"mvc.1.0.view", @"/Views/Home/GerarSenha.cshtml")]
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
#line 1 "C:\dev\GeradorSenha\GeradorSenha\Views\_ViewImports.cshtml"
using GeradorSenha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\GeradorSenha\GeradorSenha\Views\_ViewImports.cshtml"
using GeradorSenha.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67afdc9d69a2f0a9ab7448151443f4a8679e4f40", @"/Views/Home/GerarSenha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9c77cc58a0ed13f614e5ae608de1cafe933756c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_GerarSenha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeradorSenha.Models.GerarSenhaViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GerarSenha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\dev\GeradorSenha\GeradorSenha\Views\Home\GerarSenha.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
            WriteLiteral(@"
    <div class=""row"">
        <div class=""col-sm-7"" style=""border: solid 1px #e3e6e8; border-radius: 1em"">
            <br />
            <label class=""form-label"" for=""form2Example1"">Lista de senhas geradas</label><br />
            <label class=""form-label"" for=""form2Example1"">............</label><br />
            <label class=""form-label"" for=""form2Example1"">............</label><br />
            <label class=""form-label"" for=""form2Example1"">............</label><br />
            <label class=""form-label"" for=""form2Example1"">............</label>
        </div>
        <div class=""col-sm-4"" style=""border: solid 1px #e3e6e8; border-radius: 1em; margin-left:10px;"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67afdc9d69a2f0a9ab7448151443f4a8679e4f404866", async() => {
                WriteLiteral(@"
                <br />
                <!-- Email input -->
                <div class=""form-outline mb-4"">
                    <input type=""email"" id=""form2Example1"" class=""form-control"" />
                    <label class=""form-label"" for=""form2Example1"">Numero de chars</label>
                </div>

                <!-- 2 column grid layout for inline styling -->
                <div class=""row mb-4"">
                    <div class=""col d-flex justify-content-center"">
                        <!-- Checkbox -->
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1682, "\"", 1690, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""form2Example34"" />
                            <label class=""form-check-label"" for=""form2Example34""> Utilizar maiúsculas </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 1985, "\"", 1993, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""form2Example34"" />
                            <label class=""form-check-label"" for=""form2Example34""> Utilizar algarismos </label>
                        </div>
                        <div class=""form-check"">
                            <input class=""form-check-input"" type=""checkbox""");
                BeginWriteAttribute("value", " value=\"", 2288, "\"", 2296, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""form2Example34"" />
                            <label class=""form-check-label"" for=""form2Example34""> Utilizar simbolos </label>
                        </div>
                    </div>
                </div>

                <!-- Submit button -->
                <button type=""submit"" class=""btn btn-primary btn-block mb-4"">Gerar</button>               
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeradorSenha.Models.GerarSenhaViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
