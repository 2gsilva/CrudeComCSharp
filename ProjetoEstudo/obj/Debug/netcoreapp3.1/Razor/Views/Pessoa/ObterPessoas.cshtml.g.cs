#pragma checksum "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1ee8622bf4409270edece1148953ab50213682e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_ObterPessoas), @"mvc.1.0.view", @"/Views/Pessoa/ObterPessoas.cshtml")]
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
#line 1 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\_ViewImports.cshtml"
using ProjetoEstudo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
using ProjetoEstudo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1ee8622bf4409270edece1148953ab50213682e", @"/Views/Pessoa/ObterPessoas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf79571be9bdd18ff022a3b07fc4fa6fe460cf0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_ObterPessoas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pessoa>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
  
    ViewData["Title"] = "Consultar Pessoa";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<text align=""center"">
    <h2>Relação de pessoas </h2>
</text>
<br>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Nome</th>
            <th scope=""col"">Sobrenome</th>
            <th scope=""col"">Data de Nascimento</th>
        </tr>
    </thead>
    <tbody>

");
#nullable restore
#line 27 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
         foreach (var pessoa in Model)
        {
  

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
               Write(pessoa.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
               Write(pessoa.Sobrenome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
               Write(pessoa.DataNasc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ee8622bf4409270edece1148953ab50213682e4980", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 702, "~/Pessoa/Excluir/", 702, 17, true);
#nullable restore
#line 34 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
AddHtmlAttributeValue("", 719, pessoa.Id, 719, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </td>\r\n            </tr>\r\n");
#nullable restore
#line 36 "C:\RepoPessoal\CrudeComCSharp\ProjetoEstudo\Views\Pessoa\ObterPessoas.cshtml"
  
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    -------------------------------\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
