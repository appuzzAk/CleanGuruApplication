#pragma checksum "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf05c0045053cb114ca76bac3868bd33d1b04dca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ListOfCustomers), @"mvc.1.0.view", @"/Views/Customer/ListOfCustomers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/ListOfCustomers.cshtml", typeof(AspNetCore.Views_Customer_ListOfCustomers))]
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
#line 1 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\_ViewImports.cshtml"
using CleanGuruApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf05c0045053cb114ca76bac3868bd33d1b04dca", @"/Views/Customer/ListOfCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e78bb2e53c269b8b0948eed965478458913e880", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ListOfCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CleanGuruApp.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml"
  
    ViewData["Title"] = "Registerd Customer";

#line default
#line hidden
            BeginContext(101, 428, true);
            WriteLiteral(@"
<h2>List of Registered Customers</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>
                Customer's ID
            </th>
            <th>
                First Name
            </th>
            <th>
                Last Name
            </th>
            <th>
                Phone
            </th>
            <th>
                Email
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 30 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(576, 60, true);
            WriteLiteral("        <tr>\n            <td id=\"FullName\">\n                ");
            EndContext();
            BeginContext(637, 45, false);
#line 34 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCustomer));

#line default
#line hidden
            EndContext();
            BeginContext(682, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(735, 48, false);
#line 37 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.FCustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(783, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(836, 48, false);
#line 40 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.LCustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(884, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(937, 43, false);
#line 43 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.CtPhone1));

#line default
#line hidden
            EndContext();
            BeginContext(980, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1033, 42, false);
#line 46 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml"
           Write(Html.DisplayFor(modelItem => item.CtEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 49 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Customer\ListOfCustomers.cshtml"
        }

#line default
#line hidden
            BeginContext(1118, 23, true);
            WriteLiteral("    </tbody>\n\n\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CleanGuruApp.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
