#pragma checksum "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f018ce91a0b4e9e1da6f64c86927ad907bdbd1ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowCategory), @"mvc.1.0.view", @"/Views/Home/ShowCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowCategory.cshtml", typeof(AspNetCore.Views_Home_ShowCategory))]
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
#line 1 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\_ViewImports.cshtml"
using Products_N_Categories;

#line default
#line hidden
#line 4 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
using Products_N_Categories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f018ce91a0b4e9e1da6f64c86927ad907bdbd1ba", @"/Views/Home/ShowCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"281d9afe1cd6c28622998d4f01018fcc2e3a9b54", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewProductCategoryModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
            BeginContext(105, 55, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
            EndContext();
            BeginContext(161, 24, false);
#line 8 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
                     Write(ViewBag.oneCategory.Name);

#line default
#line hidden
            EndContext();
            BeginContext(185, 78, true);
            WriteLiteral("</h1>\r\n    \r\n <div class=\"row\">\r\n\r\n<div class=\"col-md\">\r\n<h1>Categories</h1>\r\n");
            EndContext();
#line 14 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
 foreach(var a in @ViewBag.oneCategory.Associations){

#line default
#line hidden
            BeginContext(318, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(334, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f018ce91a0b4e9e1da6f64c86927ad907bdbd1ba5074", async() => {
                BeginContext(352, 14, false);
#line 15 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
                            Write(a.Product.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(375, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
            }

#line default
#line hidden
            BeginContext(392, 63, true);
            WriteLiteral("</div>\r\n<div class=\"col-md\">\r\n    <h1>Add Category: </h1>\r\n    ");
            EndContext();
            BeginContext(455, 341, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f018ce91a0b4e9e1da6f64c86927ad907bdbd1ba6897", async() => {
                BeginContext(534, 44, true);
                WriteLiteral(" \r\n        <select name=\"ProductId\" id=\"\">\r\n");
                EndContext();
#line 22 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
             foreach(Product a in @ViewBag.currentProduct){

#line default
#line hidden
                BeginContext(639, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(655, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f018ce91a0b4e9e1da6f64c86927ad907bdbd1ba7641", async() => {
                    BeginContext(685, 6, false);
#line 23 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
                                        Write(a.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 23 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
                   WriteLiteral(a.ProductId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(700, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 24 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
            }

#line default
#line hidden
                BeginContext(717, 72, true);
                WriteLiteral("        </select>   \r\n    \r\n    <input type=\"submit\" value=\"Add!\">\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 469, "/addProducttocatg/", 469, 18, true);
#line 20 "D:\coding dojo\C#\ORM\Entity\Products_N_Categories\Views\Home\ShowCategory.cshtml"
AddHtmlAttributeValue("", 487, ViewBag.oneCategory.CategoryId, 487, 31, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(796, 37, true);
            WriteLiteral("\r\n</div>\r\n\r\n</div>\r\n </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewProductCategoryModel> Html { get; private set; }
    }
}
#pragma warning restore 1591