#pragma checksum "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5e399c757ad980d885b75e05d7b5eeca4f2db32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tracuu.giamkichsan.Pages.FamousPeople.Pages_FamousPeople_Create), @"mvc.1.0.razor-page", @"/Pages/FamousPeople/Create.cshtml")]
namespace tracuu.giamkichsan.Pages.FamousPeople
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
#line 1 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\_ViewImports.cshtml"
using tracuu.giamkichsan;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e399c757ad980d885b75e05d7b5eeca4f2db32", @"/Pages/FamousPeople/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e925b31a2dd80d00bcfbd7d2496404eb0a801f95", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FamousPeople_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel panel-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n    <h2>Thêm mới</h2>\r\n    <p>Thông tin những người nổi tiếng</p>\r\n    <div class=\"panel-group\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e399c757ad980d885b75e05d7b5eeca4f2db324378", async() => {
                WriteLiteral("\r\n            <div class=\"panel-body\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"alias\">Bí danh:</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"alias\"");
                BeginWriteAttribute("value", " value=\"", 455, "\"", 496, 1);
#nullable restore
#line 11 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 463, Model.personCommunityModel.Alias, 463, 33, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"name\">Họ và Tên:</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 695, "\"", 735, 1);
#nullable restore
#line 15 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 703, Model.personCommunityModel.Name, 703, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"birthday\">Ngày sinh:</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"birthday\"");
                BeginWriteAttribute("value", " value=\"", 942, "\"", 986, 1);
#nullable restore
#line 19 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 950, Model.personCommunityModel.Birthday, 950, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"address\">Nơi sinh:</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 1190, "\"", 1233, 1);
#nullable restore
#line 23 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 1198, Model.personCommunityModel.Address, 1198, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"workCategoryID\">Nghề nghiệp:</label>\r\n                    <select class=\"form-control\" name=\"workCategoryID\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e399c757ad980d885b75e05d7b5eeca4f2db327458", async() => {
                    WriteLiteral("----");
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
                WriteLiteral("\r\n");
#nullable restore
#line 29 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
                         foreach (var item in Model.workCategoriesEntity)
                        {
                            if (item.ID == Model.personCommunityModel.WorkCategoryID)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e399c757ad980d885b75e05d7b5eeca4f2db329151", async() => {
#nullable restore
#line 33 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
                                   WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 34 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5e399c757ad980d885b75e05d7b5eeca4f2db3211758", async() => {
#nullable restore
#line 37 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
                                   WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n");
#nullable restore
#line 38 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"facebook\">Facebook</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"facebook\"");
                BeginWriteAttribute("value", " value=\"", 2273, "\"", 2317, 1);
#nullable restore
#line 44 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 2281, Model.personCommunityModel.Facebook, 2281, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"youtube\">Youtube</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"youtube\"");
                BeginWriteAttribute("value", " value=\"", 2519, "\"", 2562, 1);
#nullable restore
#line 48 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 2527, Model.personCommunityModel.Youtube, 2527, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"tiktok\">Tiktok</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"tiktok\"");
                BeginWriteAttribute("value", " value=\"", 2761, "\"", 2803, 1);
#nullable restore
#line 52 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 2769, Model.personCommunityModel.Tiktok, 2769, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"wikipedia\">Wikipedia</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"wikipedia\"");
                BeginWriteAttribute("value", " value=\"", 3011, "\"", 3056, 1);
#nullable restore
#line 56 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 3019, Model.personCommunityModel.Wikipedia, 3019, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <div class=\"panel-footer\">\r\n                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 3190, "\"", 3228, 1);
#nullable restore
#line 60 "E:\duanvc\CodeGym\blog.giamkichsan\blog.giamkichsan\tracuu.giamkichsan\Pages\FamousPeople\Create.cshtml"
WriteAttributeValue("", 3198, Model.personCommunityModel.ID, 3198, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-default\">Submit</button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tracuu.giamkichsan.Pages.FamousPeople.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tracuu.giamkichsan.Pages.FamousPeople.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tracuu.giamkichsan.Pages.FamousPeople.CreateModel>)PageContext?.ViewData;
        public tracuu.giamkichsan.Pages.FamousPeople.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591