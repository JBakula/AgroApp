#pragma checksum "C:\Users\DT User\source\repos\PI_projekt\PI_projekt\Views\Home\Profil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "453c2954be52c3cc47d1270ad6979af2a3ee44aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profil), @"mvc.1.0.view", @"/Views/Home/Profil.cshtml")]
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
#line 1 "C:\Users\DT User\source\repos\PI_projekt\PI_projekt\Views\_ViewImports.cshtml"
using PI_projekt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DT User\source\repos\PI_projekt\PI_projekt\Views\_ViewImports.cshtml"
using PI_projekt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"453c2954be52c3cc47d1270ad6979af2a3ee44aa", @"/Views/Home/Profil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d55edf91359e5c201edb2bde7b59aa19c2dee28", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PI_projekt.Models.Korisnik>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Dobro došao ");
#nullable restore
#line 3 "C:\Users\DT User\source\repos\PI_projekt\PI_projekt\Views\Home\Profil.cshtml"
           Write(Html.DisplayFor(model => Model.ImePrezime));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</h1>
<table class=""table mt-5"">
        <tr>
            <th>
                ID/Oznaka korisnika
            </th>
            <th>
                Ime i prezime
            </th>
            <th>
                Email
            </th>
            <th>
                Lozinka
            </th>
        </tr>
        <tr>
            <td>
                ");
#nullable restore
#line 21 "C:\Users\DT User\source\repos\PI_projekt\PI_projekt\Views\Home\Profil.cshtml"
           Write(Html.DisplayFor(model => model.KorisnikId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\DT User\source\repos\PI_projekt\PI_projekt\Views\Home\Profil.cshtml"
           Write(Html.DisplayFor(model => model.ImePrezime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\DT User\source\repos\PI_projekt\PI_projekt\Views\Home\Profil.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\DT User\source\repos\PI_projekt\PI_projekt\Views\Home\Profil.cshtml"
           Write(Html.DisplayFor(model => model.Lozinka));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n</table>\r\n<!--\r\n    using Microsoft.AspNetCore.Http;\r\n    Welcome Context.Session.GetString(\"imePrezimeLogiranogKorisnika\")-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PI_projekt.Models.Korisnik> Html { get; private set; }
    }
}
#pragma warning restore 1591
