#pragma checksum "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe9d3fc708bd5a2653565dfc8d96239548d12d24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FaryvetLogisticSupport.Pages.Facturas.Pages_Facturas_Facturas), @"mvc.1.0.razor-page", @"/Pages/Facturas/Facturas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Facturas/Facturas.cshtml", typeof(FaryvetLogisticSupport.Pages.Facturas.Pages_Facturas_Facturas), null)]
namespace FaryvetLogisticSupport.Pages.Facturas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\_ViewImports.cshtml"
using FaryvetLogisticSupport;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9d3fc708bd5a2653565dfc8d96239548d12d24", @"/Pages/Facturas/Facturas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2520226a5328886ad2036c50c5645c446a94d7d5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Facturas_Facturas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
  
    ViewData["Title"] = "Facturas";

#line default
#line hidden
            BeginContext(111, 23, true);
            WriteLiteral("\r\n<h1>Facturas</h1>\r\n\r\n");
            EndContext();
            BeginContext(134, 2795, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9d3fc708bd5a2653565dfc8d96239548d12d244003", async() => {
                BeginContext(154, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 10 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
     if (Model.Facturas.Count() > 0)
    {

#line default
#line hidden
                BeginContext(201, 212, true);
                WriteLiteral("        <br />\r\n        <table id=\"tabla\" class=\"table table-striped border\" cellspacing=\"0\">\r\n            <thead>\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(414, 56, false);
#line 17 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Id));

#line default
#line hidden
                EndContext();
                BeginContext(470, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(550, 67, false);
#line 20 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().FormaDespacho));

#line default
#line hidden
                EndContext();
                BeginContext(617, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(697, 58, false);
#line 23 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Peso));

#line default
#line hidden
                EndContext();
                BeginContext(755, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(835, 64, false);
#line 26 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().FormaCobro));

#line default
#line hidden
                EndContext();
                BeginContext(899, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(979, 60, false);
#line 29 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Moneda));

#line default
#line hidden
                EndContext();
                BeginContext(1039, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1119, 61, false);
#line 32 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Cliente));

#line default
#line hidden
                EndContext();
                BeginContext(1180, 167, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Ubicación\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1348, 65, false);
#line 38 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Comentarios));

#line default
#line hidden
                EndContext();
                BeginContext(1413, 95, true);
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 43 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                 foreach (var item in Model.Facturas)
                {

#line default
#line hidden
                BeginContext(1582, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1667, 29, false);
#line 47 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1696, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1788, 40, false);
#line 50 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.FormaDespacho));

#line default
#line hidden
                EndContext();
                BeginContext(1828, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1920, 31, false);
#line 53 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.Peso));

#line default
#line hidden
                EndContext();
                BeginContext(1951, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2043, 37, false);
#line 56 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.FormaCobro));

#line default
#line hidden
                EndContext();
                BeginContext(2080, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2172, 33, false);
#line 59 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.Moneda));

#line default
#line hidden
                EndContext();
                BeginContext(2205, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2297, 34, false);
#line 62 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.Cliente));

#line default
#line hidden
                EndContext();
                BeginContext(2331, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2423, 36, false);
#line 65 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.Provincia));

#line default
#line hidden
                EndContext();
                BeginContext(2459, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2490, 33, false);
#line 66 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.Canton));

#line default
#line hidden
                EndContext();
                BeginContext(2523, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2554, 35, false);
#line 67 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.Distrito));

#line default
#line hidden
                EndContext();
                BeginContext(2589, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2681, 38, false);
#line 70 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                       Write(Html.DisplayFor(m => item.Comentarios));

#line default
#line hidden
                EndContext();
                BeginContext(2719, 60, true);
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 73 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                }

#line default
#line hidden
                BeginContext(2798, 42, true);
                WriteLiteral("            </tbody>\r\n\r\n        </table>\r\n");
                EndContext();
#line 77 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(2864, 51, true);
                WriteLiteral("        <p>No se encuentran datos disponibles</p>\r\n");
                EndContext();
#line 81 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2929, 97, true);
            WriteLiteral("\r\n\r\n<link href=\"//cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3043, 913, true);
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script>
    $(document).ready(function () {
        $(""#tabla"").datatable().fnDestroy();
        $(""#tabla"").dataTable({
            ""responsive"":true,
            ""ajax"": {
                ""url"": ""/Pages/Facturas/FacturasEspeciales/GetList"",
                ""type"": ""GET"",
                ""datatype"": ""json""
            },
            ""columns"": [
                { ""data"": ""Id"" },
                { ""data"": ""FormaDespacho"" },
                { ""data"": ""Peso"" },
                { ""data"": ""FormaCobro"" },
                { ""data"": ""Moneda"" },
                { ""data"": ""Cliente"" },
                { ""data"": ""Provincia"" },
                { ""data"": ""Canton"" },
                { ""data"": ""Distrito"" },
                { ""data"": ""Comentarios"" }
            ],

        });
    });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FaryvetLogisticSupport.Pages.Facturas.FacturasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FaryvetLogisticSupport.Pages.Facturas.FacturasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FaryvetLogisticSupport.Pages.Facturas.FacturasModel>)PageContext?.ViewData;
        public FaryvetLogisticSupport.Pages.Facturas.FacturasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
