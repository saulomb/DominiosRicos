#pragma checksum "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46b5b50c1d5f3569edeaa7bd0dc033f422bdf17a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vitrine_Index), @"mvc.1.0.view", @"/Views/Vitrine/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vitrine/Index.cshtml", typeof(AspNetCore.Views_Vitrine_Index))]
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
#line 1 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#line 2 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b5b50c1d5f3569edeaa7bd0dc033f422bdf17a", @"/Views/Vitrine/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"483c27f6c0b0cb9ac93a4d13b9dbf20a87791be1", @"/Views/_ViewImports.cshtml")]
    public class Views_Vitrine_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel >>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Vitrine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdutoDetalhe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 8, true);
            WriteLiteral("    \r\n\r\n");
            EndContext();
#line 4 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
      
        ViewData["Title"] = "Vitrine";
    

#line default
#line hidden
            BeginContext(144, 722, true);
            WriteLiteral(@"    <style>
        h4 {
            font-weight: 600;
        }

        p {
            font-size: 12px;
            margin-top: 5px;
        }

        .price {
            font-size: 30px;
            margin: 0 auto;
            color: #333;
        }

        .right {
            float: right;
            border-bottom: 2px solid #4B8E4B;
        }

        .thumbnail {
            opacity: 0.70;
            -webkit-transition: all 0.5s;
            transition: all 0.5s;
        }

            .thumbnail:hover {
                opacity: 1.00;
                box-shadow: 0px 0px 10px #4bc6ff;
            }

        .line {
            margin-bottom: 5px;
        }

        ");
            EndContext();
            BeginContext(867, 592, true);
            WriteLiteral(@"@media screen and (max-width: 770px) {
            .right {
                float: left;
                width: 100%;
            }
        }

        .product_view .modal-dialog {
            max-width: 800px;
            width: 100%;
        }

        .pre-cost {
            text-decoration: line-through;
            color: #a5a5a5;
        }

        .space-ten {
            padding: 10px 0;
        }
    </style>
    <div class=""container"">

        <h1>Vitrine de Produtos</h1>
        <br />
        <div class=""row"">
            <!-- BEGIN PRODUCTS -->
");
            EndContext();
#line 70 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
              
                foreach (var produto in Model.OrderBy(p => p.CategoriaId))
                {

#line default
#line hidden
            BeginContext(1570, 131, true);
            WriteLiteral("                    <div class=\"col-md-3 col-sm-6\">\r\n                        <span class=\"thumbnail\">\r\n                            ");
            EndContext();
            BeginContext(1701, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46b5b50c1d5f3569edeaa7bd0dc033f422bdf17a7143", async() => {
                BeginContext(1784, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46b5b50c1d5f3569edeaa7bd0dc033f422bdf17a7407", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1819, "~/Images/", 1819, 9, true);
#line 75 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
AddHtmlAttributeValue("", 1828, produto.Imagem, 1828, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                                                                                      WriteLiteral(produto.Id);

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
            BeginContext(1851, 34, true);
            WriteLiteral("\r\n                            <h4>");
            EndContext();
            BeginContext(1886, 12, false);
#line 76 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                           Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1898, 45, true);
            WriteLiteral("</h4>\r\n                            <p>Apenas ");
            EndContext();
            BeginContext(1944, 25, false);
#line 77 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                                 Write(produto.QuantidadeEstoque);

#line default
#line hidden
            EndContext();
            BeginContext(1969, 49, true);
            WriteLiteral(" em estoque!</p>\r\n                            <p>");
            EndContext();
            BeginContext(2019, 17, false);
#line 78 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                          Write(produto.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2036, 218, true);
            WriteLiteral("</p>\r\n                            <hr class=\"line\">\r\n                            <div class=\"row\">\r\n                                <div class=\"col-md-6 col-sm-6\">\r\n                                    <p class=\"price\">");
            EndContext();
            BeginContext(2255, 27, false);
#line 82 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                                                Write(produto.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2282, 143, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n                        </span>\r\n                    </div>\r\n");
            EndContext();
#line 87 "C:\Dev\Desenvolvedor.IO\Modelagem de Domínios Ricos\source-saga\NerdStore\src\NerdStore.WebApp.MVC\Views\Vitrine\Index.cshtml"
                }
            

#line default
#line hidden
            BeginContext(2459, 67, true);
            WriteLiteral("\r\n            <!-- END PRODUCTS -->\r\n        </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NerdStore.Catalogo.Application.ViewModels.ProdutoViewModel >> Html { get; private set; }
    }
}
#pragma warning restore 1591
