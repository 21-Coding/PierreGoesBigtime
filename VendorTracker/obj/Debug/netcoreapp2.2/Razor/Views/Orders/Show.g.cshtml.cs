#pragma checksum "/Users/dominiqueyoumans/Desktop/hello/PierreGoesBigtime/VendorTracker/Views/Orders/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b38ec32b681cc9a53e31bd064dc2781a6f1da816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Show), @"mvc.1.0.view", @"/Views/Orders/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Show.cshtml", typeof(AspNetCore.Views_Orders_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b38ec32b681cc9a53e31bd064dc2781a6f1da816", @"/Views/Orders/Show.cshtml")]
    public class Views_Orders_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/dominiqueyoumans/Desktop/hello/PierreGoesBigtime/VendorTracker/Views/Orders/Show.cshtml"
  
  Layout = "_Layout";


#line default
#line hidden
            BeginContext(28, 13, true);
            WriteLiteral("\n<h2>Vendor: ");
            EndContext();
            BeginContext(42, 20, false);
#line 6 "/Users/dominiqueyoumans/Desktop/hello/PierreGoesBigtime/VendorTracker/Views/Orders/Show.cshtml"
       Write(Model["vendor"].Name);

#line default
#line hidden
            EndContext();
            BeginContext(62, 43, true);
            WriteLiteral("</h2>\n<h3>Order Info: </h3>\n\n<h3>Contents: ");
            EndContext();
            BeginContext(106, 19, false);
#line 9 "/Users/dominiqueyoumans/Desktop/hello/PierreGoesBigtime/VendorTracker/Views/Orders/Show.cshtml"
         Write(Model["order"].Info);

#line default
#line hidden
            EndContext();
            BeginContext(125, 16, true);
            WriteLiteral("</h3>\n<h3>Date: ");
            EndContext();
            BeginContext(142, 19, false);
#line 10 "/Users/dominiqueyoumans/Desktop/hello/PierreGoesBigtime/VendorTracker/Views/Orders/Show.cshtml"
     Write(Model["order"].Date);

#line default
#line hidden
            EndContext();
            BeginContext(161, 19, true);
            WriteLiteral("</h3>\n<h3>Payment: ");
            EndContext();
            BeginContext(181, 22, false);
#line 11 "/Users/dominiqueyoumans/Desktop/hello/PierreGoesBigtime/VendorTracker/Views/Orders/Show.cshtml"
        Write(Model["order"].Payment);

#line default
#line hidden
            EndContext();
            BeginContext(203, 20, true);
            WriteLiteral("</h3>\n<h3>Location: ");
            EndContext();
            BeginContext(224, 23, false);
#line 12 "/Users/dominiqueyoumans/Desktop/hello/PierreGoesBigtime/VendorTracker/Views/Orders/Show.cshtml"
         Write(Model["order"].Location);

#line default
#line hidden
            EndContext();
            BeginContext(247, 9, true);
            WriteLiteral("</h3>\n\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 256, "\'", 302, 3);
            WriteAttributeValue("", 263, "/vendors/", 263, 9, true);
#line 14 "/Users/dominiqueyoumans/Desktop/hello/PierreGoesBigtime/VendorTracker/Views/Orders/Show.cshtml"
WriteAttributeValue("", 272, Model["vendor"].Id, 272, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 291, "/orders/new", 291, 11, true);
            EndWriteAttribute();
            BeginContext(303, 44, true);
            WriteLiteral(">Add</a>\n<a href=\'/vendors\'>All Vendors</a>\n");
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
