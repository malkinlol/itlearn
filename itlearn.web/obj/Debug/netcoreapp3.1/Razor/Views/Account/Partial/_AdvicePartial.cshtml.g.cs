#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec1be2bba969702860cd7193606b10cc6442ff09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Partial__AdvicePartial), @"mvc.1.0.view", @"/Views/Account/Partial/_AdvicePartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Language;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Chapter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Question;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Answer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Notification;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Story;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Achievement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.dal.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Advice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.bll.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec1be2bba969702860cd7193606b10cc6442ff09", @"/Views/Account/Partial/_AdvicePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Partial__AdvicePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdviceVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
  
    var test = await testService.GetById(Model.TestId);
    var theme = await themeService.GetById(test.ThemeId);
    var chapter = await chapterService.GetById(theme.ChapterId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .custom-card:hover {
        border-bottom: solid 3px #6a4dcb;
    }

    .label-custom {
        background-color: #6a4dcb;
        color: white;
        border-radius: 15px;
        padding: 0px 6px;
    }
</style>

<div class=""custom-card card w-100 mt-3 mb-3 ml-5 mr-5 shadow"">
    <div class=""modal-header"" style=""background: none;"">
        <h3>");
#nullable restore
#line 26 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
       Write(theme.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <button type=\"button\" data-toggle=\"modal\" data-target=\"#deleteAdviceModal-");
#nullable restore
#line 27 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
                                                                             Write(Model.AdviceId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""close"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-md-9"">
                <p style=""font-size:20px""><b>Совет: </b>");
#nullable restore
#line 34 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
                                                   Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            </div>\r\n            <div class=\"col-md-3 text-center\">\r\n                <a class=\"mt-3 mb-3 btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1221, "\"", 1291, 4);
            WriteAttributeValue("", 1228, "/Home/Theme?themeId=", 1228, 20, true);
#nullable restore
#line 38 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
WriteAttributeValue("", 1248, theme.ThemeId, 1248, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1262, "&chapterId=", 1262, 11, true);
#nullable restore
#line 38 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
WriteAttributeValue("", 1273, chapter.ChapterId, 1273, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Перейти к теме</a>\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"form-inline\">\r\n            <label class=\"label-custom ml-2 mr-2\"><b> ");
#nullable restore
#line 43 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
                                                 Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 1546, "\"", 1584, 2);
            WriteAttributeValue("", 1551, "deleteAdviceModal-", 1551, 18, true);
#nullable restore
#line 48 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
WriteAttributeValue("", 1569, Model.AdviceId, 1569, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Совет</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Вы уверены, что хотите удалить этот совет?</p>
");
#nullable restore
#line 59 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
                 using (Html.BeginForm("DeleteAdvice", "Account", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2322, "\"", 2345, 1);
#nullable restore
#line 61 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
WriteAttributeValue("", 2330, Model.AdviceId, 2330, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"AdviceId\" />\r\n");
            WriteLiteral("                    <input type=\"submit\" class=\"btn btn-danger\" value=\"Удалить\" />\r\n");
#nullable restore
#line 64 "E:\Projects\itlearn\itlearn.web\Views\Account\Partial\_AdvicePartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IChapterService chapterService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IThemeService themeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITestService testService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdviceVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
