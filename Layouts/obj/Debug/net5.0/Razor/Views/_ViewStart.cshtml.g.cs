#pragma checksum "C:\Users\Usuario\Desktop\.NetCore\CodeStack\Proyectos\CodeStackCursoAsp.NetCore\Layouts\Views\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dff77717557bdc732895e2f47ca2a8b04111bf56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__ViewStart), @"mvc.1.0.view", @"/Views/_ViewStart.cshtml")]
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
#line 1 "C:\Users\Usuario\Desktop\.NetCore\CodeStack\Proyectos\CodeStackCursoAsp.NetCore\Layouts\Views\_ViewImports.cshtml"
using Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\Desktop\.NetCore\CodeStack\Proyectos\CodeStackCursoAsp.NetCore\Layouts\Views\_ViewImports.cshtml"
using Layouts.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff77717557bdc732895e2f47ca2a8b04111bf56", @"/Views/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a40967c6a3b10cbf370f6a09cd57350c5f98e571", @"/Views/_ViewImports.cshtml")]
    public class Views__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!--Dice que hay una varibale global que es donde se va adefinir\r\nQue diseño va tener la pagina y le dice que se dirija a layout-->\r\n");
#nullable restore
#line 4 "C:\Users\Usuario\Desktop\.NetCore\CodeStack\Proyectos\CodeStackCursoAsp.NetCore\Layouts\Views\_ViewStart.cshtml"
  
    Layout = "_Layout";
    //el busca en views/shared o en pages/shared o en views/home 

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
