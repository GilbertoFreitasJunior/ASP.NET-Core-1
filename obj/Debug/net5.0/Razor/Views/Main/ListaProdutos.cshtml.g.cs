#pragma checksum "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\Main\ListaProdutos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1c82bfea5bdb2047caacaed698d5a5669ee4271"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_ListaProdutos), @"mvc.1.0.view", @"/Views/Main/ListaProdutos.cshtml")]
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
#line 1 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\_ViewImports.cshtml"
using AppExemplo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\_ViewImports.cshtml"
using AppExemplo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1c82bfea5bdb2047caacaed698d5a5669ee4271", @"/Views/Main/ListaProdutos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e5748f56f37147a065d9e40cd789a23f8f39c01", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_ListaProdutos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\Main\ListaProdutos.cshtml"
  
    ViewData["Title"] = "Lista Produtos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 6 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\Main\ListaProdutos.cshtml"
  
    var csv = new CsvHandler();

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\Main\ListaProdutos.cshtml"
 foreach (var produto in csv.ListarProdutos())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row mb-3\">\n    <div class=\"col-4 themed-grid-col\">ID: ");
#nullable restore
#line 12 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\Main\ListaProdutos.cshtml"
                                      Write(produto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div class=\"col-4 themed-grid-col\">Nome: ");
#nullable restore
#line 13 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\Main\ListaProdutos.cshtml"
                                        Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <div class=\"col-4 themed-grid-col\">Pre??o: ");
#nullable restore
#line 14 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\Main\ListaProdutos.cshtml"
                                         Write(produto.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n</div>\n");
#nullable restore
#line 16 "C:\Users\mytef\source\repos\New folder\ASP.NET-Core-1-main\Views\Main\ListaProdutos.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
