#pragma checksum "/Users/dominiqueyoumans/Desktop/PierreGoesBigtime/VendorTracker/Views/Vendors/New.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f9aaca08b720090f2581511927d472b50100228"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_New), @"mvc.1.0.view", @"/Views/Vendors/New.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/New.cshtml", typeof(AspNetCore.Views_Vendors_New))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f9aaca08b720090f2581511927d472b50100228", @"/Views/Vendors/New.cshtml")]
    public class Views_Vendors_New : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/dominiqueyoumans/Desktop/PierreGoesBigtime/VendorTracker/Views/Vendors/New.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 288, true);
            WriteLiteral(@"
<h1>Add a new vendor!</h1>
<p>Please fill out new vendors form below:</p>

<form action=""/vendors"" method=""post"">
  <input id =""vendorName"" name=""vendorName"" type=""text"">
  <button type=""submit"">Add</button>
</form>

<p><a href=""/"">Home</a></p>
<p><a href=""/vendors"">All Vendors</a></p>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591