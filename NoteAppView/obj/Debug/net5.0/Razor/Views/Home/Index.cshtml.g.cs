#pragma checksum "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5a28b83f80e1ba8664567b5ad8c7fa5a87772bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\_ViewImports.cshtml"
using NoteAppView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\_ViewImports.cshtml"
using NoteAppView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a28b83f80e1ba8664567b5ad8c7fa5a87772bb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d43e8d3a26e54bfdb5b55bfeb225da036b348e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Note.Entities.Note>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container mt-3"">
    <table class=""table table-bordered table-hover"">
        <thead style=""background-color: orange;"">
        <tr>
            <th>ID</th>
            <th>Başlık</th>
            <th>Durumu</th>
        </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 17 "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\Home\Index.cshtml"
         foreach (var note in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\Home\Index.cshtml"
               Write(note.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\Home\Index.cshtml"
               Write(note.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\Home\Index.cshtml"
               Write(note.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "C:\Users\Mert\source\repos\MertcanDursunFinalExam\NoteAppView\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Note.Entities.Note>> Html { get; private set; }
    }
}
#pragma warning restore 1591
