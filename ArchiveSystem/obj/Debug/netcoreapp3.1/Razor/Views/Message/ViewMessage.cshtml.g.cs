#pragma checksum "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\Message\ViewMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67d38b74b629dd2e9d8edcfdcda5f1b852242d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_ViewMessage), @"mvc.1.0.view", @"/Views/Message/ViewMessage.cshtml")]
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
#line 1 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\_ViewImports.cshtml"
using ArchiveSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\_ViewImports.cshtml"
using ArchiveSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d38b74b629dd2e9d8edcfdcda5f1b852242d01", @"/Views/Message/ViewMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf0f816de4d66f3369d536af6119ec924ae6ac1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_ViewMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArchiveSystem.Models.Message>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#DCABAB; border-color: white; border-radius: 25px; color: white; padding: 10px 20px; margin-right: 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AttachmentView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\Message\ViewMessage.cshtml"
  
    Layout = "_UserLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    body {
        background-image: url(https://cdn.aukro.cz/images/sk1623352698430/730x548/pohlednice-cervena-postovni-schranka-vlastni-vyroba-cista-vf-101957236.jpeg);
        background-repeat: repeat;
        background-attachment: fixed;
        background-size: 100% 100%;
    }

    body {
        height: 100%;
        margin: 0;
        padding: 0;
    }

    .image-container {
        height: 100%;
    }

    .full-screen-image {
        width: 100%;
        height: 100%;
        object-fit: cover;
        position: fixed;
    }

    .form-container {
        height: 480px;
        display: flex;
        align-items: center;
        justify-content: center;
        margin: 0 auto;
        display: flex;
        flex-direction: column;
        align-items: center;
    }

    .form-group input {
        flex: 1;
    }

    .form-label {
        font-size: 14px;
    }

    .form-control-lg {
        font-size: 14px;
    }

    .thumbnail {
        display: inline-block;
        width: 100px;
   ");
            WriteLiteral(@"     height: 100px;
        margin: 10px;
        overflow: hidden;
    }

        .thumbnail img {
            width: 100%;
            height: auto;
            object-fit: cover;
        }
</style>

<header style=""text-align: center"">
    <br />
    <h1 style=""color:coral""> View Message </h1>
</header>

<section class=""vh-100"">
");
            WriteLiteral("\n\n    <div class=\"form-outline mb-4\">\n        <div class=\"form-container\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67d38b74b629dd2e9d8edcfdcda5f1b852242d016881", async() => {
                WriteLiteral(@"
                <style>
                    /* Your existing CSS code here */

                    form button {
                        display: block;
                        margin: 0 auto;
                        border-radius: 10px; /* Add border-radius property with a value to set the desired rounded edge */
                    }
                </style>

                <div>
                    <!--Title-->
                    <div>
                        <label style=""color:#E6E3D9"" class=""form-label"" for=""form1Example13"">Title</label>
                        <input style=""text-align: center"" type=""text"" id=""form1Example13""");
                BeginWriteAttribute("value", " value=\"", 2228, "\"", 2248, 1);
#nullable restore
#line 93 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\Message\ViewMessage.cshtml"
WriteAttributeValue("", 2236, Model.Title, 2236, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control form-control-lg"" readonly />

                    </div>
                    <!--send Date -->
                    <div>
                        <label style=""color:#E6E3D9"" class=""form-label"" for=""form1Example23"">Send Date</label>
                        <input type=""datetime"" style=""text-align: center"" id=""form1Example13""");
                BeginWriteAttribute("value", " value=\"", 2595, "\"", 2618, 1);
#nullable restore
#line 99 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\Message\ViewMessage.cshtml"
WriteAttributeValue("", 2603, Model.SendDate, 2603, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control form-control-lg\" readonly />\n                    </div>\n");
                WriteLiteral(@"                    <!-- Address of the letter -->
                    <div>
                        <label style=""color:#E6E3D9"" class=""form-label"" for=""form1Example23""> Address of the letter</label>
                        <input type=""text"" style=""text-align: center"" id=""form1Example13""");
                BeginWriteAttribute("value", " value=\"", 3364, "\"", 3393, 1);
#nullable restore
#line 109 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\Message\ViewMessage.cshtml"
WriteAttributeValue("", 3372, Model.MessageAddress, 3372, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control form-control-lg"" readonly />
                    </div>

                    <!-- The content of the letter -->
                    <div>
                        <label style=""color:#E6E3D9"" class=""form-label"" for=""form1Example23""> The content of the letter</label>
                        <textarea type=""text"" style=""text-align: center"" id=""form1Example13"" class=""form-control form-control-lg"" readonly rows=""3"" cols=""50"">");
#nullable restore
#line 115 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\Message\ViewMessage.cshtml"
                                                                                                                                                         Write(Model.MessageText);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                    </div>

                    <!-- The destination from which the letter was received -->
                    <div>
                        <label style=""color:#E6E3D9"" class=""form-label"" for=""form1Example23""> The destination from which the letter was received</label>
                        <input type=""text"" style=""text-align: center"" id=""form1Example13""");
                BeginWriteAttribute("value", " value=\"", 4245, "\"", 4278, 1);
#nullable restore
#line 121 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\Message\ViewMessage.cshtml"
WriteAttributeValue("", 4253, Model.MessageDestination, 4253, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control form-control-lg"" readonly />
                    </div>

                    <br />
                    <div style=""display: flex; justify-content: center;"">
                        <!--    asp-route-id="" Model.AttachmentId  -->
                        <div asp-action=""AttachmentView"" asp-controller=""User"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67d38b74b629dd2e9d8edcfdcda5f1b852242d0111777", async() => {
                    WriteLiteral("Attachment");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
                WriteLiteral(" ");
#nullable restore
#line 128 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\Message\ViewMessage.cshtml"
                                                                                                                                                                         WriteLiteral(Model.MessageId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        </div>\n\n                      </div>\n                    <div style=\"display: flex; justify-content: center;\">\n                    </div>\n                </div>\n\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <br />\n        </div>\n        <br />\n    </div>\n    <div>\n    </div>\n</section>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArchiveSystem.Models.Message> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
