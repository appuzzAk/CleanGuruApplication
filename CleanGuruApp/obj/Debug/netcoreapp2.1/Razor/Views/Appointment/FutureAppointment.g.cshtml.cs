#pragma checksum "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a83805dbebe73f6d38dc2e47447068a5552582cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_FutureAppointment), @"mvc.1.0.view", @"/Views/Appointment/FutureAppointment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Appointment/FutureAppointment.cshtml", typeof(AspNetCore.Views_Appointment_FutureAppointment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83805dbebe73f6d38dc2e47447068a5552582cc", @"/Views/Appointment/FutureAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e78bb2e53c269b8b0948eed965478458913e880", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_FutureAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Appointment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 4 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
  
    ViewData["Title"] = "FutureAppointment";

#line default
#line hidden
            BeginContext(84, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 8 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
 if (ViewBag.typeUser == "Cu")
{

#line default
#line hidden
            BeginContext(118, 47, true);
            WriteLiteral("    <h2>Future Appointments for Customers</h2>\n");
            EndContext();
#line 11 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(174, 46, true);
            WriteLiteral("    <h2>Future Appointments for Cleaners</h2>\n");
            EndContext();
#line 15 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
}

#line default
#line hidden
            BeginContext(222, 82, true);
            WriteLiteral("\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(305, 49, false);
#line 22 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.IdAppointment));

#line default
#line hidden
            EndContext();
            BeginContext(354, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(407, 56, false);
#line 25 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.CtDateRequestService));

#line default
#line hidden
            EndContext();
            BeginContext(463, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(516, 43, false);
#line 28 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.Cleaner));

#line default
#line hidden
            EndContext();
            BeginContext(559, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(612, 45, false);
#line 31 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(657, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(710, 52, false);
#line 34 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.CtHoursRequested));

#line default
#line hidden
            EndContext();
            BeginContext(762, 20, true);
            WriteLiteral("\n            </th>\n\n");
            EndContext();
#line 37 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
             if (ViewBag.typeUser == "Cu")
            {

#line default
#line hidden
            BeginContext(839, 41, true);
            WriteLiteral("                <th>\n                    ");
            EndContext();
            BeginContext(881, 48, false);
#line 40 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayNameFor(model => model.ServicePrice));

#line default
#line hidden
            EndContext();
            BeginContext(929, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(994, 41, false);
#line 43 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1035, 23, true);
            WriteLiteral("\n                </th>\n");
            EndContext();
#line 45 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
            }

#line default
#line hidden
            BeginContext(1072, 33, true);
            WriteLiteral("            <th>\n                ");
            EndContext();
            BeginContext(1106, 44, false);
#line 47 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.Customer));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 53 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1277, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1336, 44, false);
#line 57 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayFor(model => item.IdAppointment));

#line default
#line hidden
            EndContext();
            BeginContext(1380, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1445, 55, false);
#line 60 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayFor(modelItem => item.CtDateRequestService));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1565, 55, false);
#line 63 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cleaner.FCleanerName));

#line default
#line hidden
            EndContext();
            BeginContext(1620, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(1642, 55, false);
#line 64 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cleaner.LCleanerName));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1762, 44, false);
#line 67 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(1806, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1871, 51, false);
#line 70 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayFor(modelItem => item.CtHoursRequested));

#line default
#line hidden
            EndContext();
            BeginContext(1922, 23, true);
            WriteLiteral("\n                </td>\n");
            EndContext();
#line 72 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                 if (ViewBag.typeUser == "Cu")
                {

#line default
#line hidden
            BeginContext(2010, 49, true);
            WriteLiteral("                    <td>\n                        ");
            EndContext();
            BeginContext(2060, 65, false);
#line 75 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ServicePrice.ServicePriceDescr));

#line default
#line hidden
            EndContext();
            BeginContext(2125, 26, true);
            WriteLiteral("\n                        (");
            EndContext();
            BeginContext(2152, 60, false);
#line 76 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                    Write(Html.DisplayFor(modelItem => item.ServicePrice.CtAmountHour));

#line default
#line hidden
            EndContext();
            BeginContext(2212, 87, true);
            WriteLiteral(" per hour)\n\n                    </td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(2300, 40, false);
#line 80 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 28, true);
            WriteLiteral("\n\n                    </td>\n");
            EndContext();
#line 83 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                }

#line default
#line hidden
            BeginContext(2386, 41, true);
            WriteLiteral("                <td>\n                    ");
            EndContext();
            BeginContext(2428, 57, false);
#line 85 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer.FCustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(2485, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2507, 57, false);
#line 86 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
               Write(Html.DisplayFor(modelItem => item.Customer.LCustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(2564, 24, true);
            WriteLiteral("\n\n                </td>\n");
            EndContext();
#line 89 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                 if (ViewBag.typeUser == "Cu")
                {

#line default
#line hidden
            BeginContext(2653, 49, true);
            WriteLiteral("                    <td>\n                        ");
            EndContext();
            BeginContext(2702, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ff72e6fb5c947a2bee5601b47ac1fd8", async() => {
                BeginContext(2787, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 92 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                                                                            WriteLiteral(item.IdAppointment);

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
            BeginContext(2795, 27, true);
            WriteLiteral(" |\n                        ");
            EndContext();
            BeginContext(2822, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "77300eab4f1f4287bdb71a746dac16f5", async() => {
                BeginContext(2910, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 93 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                                                                               WriteLiteral(item.IdAppointment);

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
            BeginContext(2921, 27, true);
            WriteLiteral(" |\n                        ");
            EndContext();
            BeginContext(2948, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "890b47bc09fe4818bf7f4be81f1d44e4", async() => {
                BeginContext(3035, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                                                                              WriteLiteral(item.IdAppointment);

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
            BeginContext(3045, 27, true);
            WriteLiteral("\n                    </td>\n");
            EndContext();
#line 96 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
                }

#line default
#line hidden
            BeginContext(3090, 18, true);
            WriteLiteral("            </tr>\n");
            EndContext();
#line 98 "C:\Users\Owner\Desktop\Cleangaroo-master\CleanGuruApp\CleanGuruApp\Views\Appointment\FutureAppointment.cshtml"
        }

#line default
#line hidden
            BeginContext(3118, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
