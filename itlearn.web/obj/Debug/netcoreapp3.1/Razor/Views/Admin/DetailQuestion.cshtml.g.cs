#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5991b729637af5932941337d7a65dd0be64b25d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DetailQuestion), @"mvc.1.0.view", @"/Views/Admin/DetailQuestion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5991b729637af5932941337d7a65dd0be64b25d", @"/Views/Admin/DetailQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DetailQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
  
    var answers = answerService.GetAll()
        .GetAwaiter().GetResult()
        .Where(x => x.QuestionId == Model.QuestionId)
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <section class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"alert alert-light mt-2 mb-2\">\r\n                <h2>Вопрос: ");
#nullable restore
#line 18 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                       Write(Model.SomeQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>\r\n");
#nullable restore
#line 20 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                     if (await questionService.IsCorrectQuestion(Model.QuestionId))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"text-success\"><b>CORRECT</b></span>\r\n");
#nullable restore
#line 23 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"text-danger\"><b>INCORRECT</b></span>\r\n");
#nullable restore
#line 27 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                <hr />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 966, "\"", 1021, 2);
            WriteAttributeValue("", 973, "/Admin/EditQuestion?questionId=", 973, 31, true);
#nullable restore
#line 30 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
WriteAttributeValue("", 1004, Model.QuestionId, 1004, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Изменить</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1079, "\"", 1134, 2);
            WriteAttributeValue("", 1086, "/Admin/CreateAnswer?questionId=", 1086, 31, true);
#nullable restore
#line 31 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
WriteAttributeValue("", 1117, Model.QuestionId, 1117, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Добавить ответ</a>\r\n            </div>\r\n\r\n");
#nullable restore
#line 34 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
             if (!string.IsNullOrEmpty(Model.Avatar))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mt-5 mb-5\" >\r\n                    <img");
            BeginWriteAttribute("src", "  src=\"", 1338, "\"", 1371, 1);
#nullable restore
#line 37 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
WriteAttributeValue("", 1345, Url.Content(Model.Avatar), 1345, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 300px; width: 700px\"/>\r\n                </div>\r\n                <hr />\r\n");
#nullable restore
#line 40 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <div>\r\n");
#nullable restore
#line 44 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                 if (answers.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul>\r\n");
#nullable restore
#line 47 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                         foreach (AnswerVM answer in answers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1743, "\"", 1795, 2);
            WriteAttributeValue("", 1750, "/Admin/DetailAnswer?answerId=", 1750, 29, true);
#nullable restore
#line 50 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
WriteAttributeValue("", 1779, answer.AnswerId, 1779, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 51 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                               Write(answer.SomeAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\r\n\r\n");
#nullable restore
#line 53 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                                     if (answer.IsRight)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Правильный</span>\r\n");
#nullable restore
#line 56 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Неправильный</span>\r\n");
#nullable restore
#line 60 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </a>\r\n                            </li>\r\n");
#nullable restore
#line 63 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 65 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailQuestion.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IQuestionService questionService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAnswerService answerService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
