#pragma checksum "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57a28faab8d3dc5771b62c03cee79c6ec63ae11f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Test), @"mvc.1.0.view", @"/Views/Home/Test.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Language;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Chapter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Question;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Answer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Notification;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Story;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Achievement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.dal.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Advice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.bll.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57a28faab8d3dc5771b62c03cee79c6ec63ae11f", @"/Views/Home/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestQuestionVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57a28faab8d3dc5771b62c03cee79c6ec63ae11f8484", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 16 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
  
    Random rng = new Random();

    void Shuffle(IList<QuestionVM> list)
    {
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            QuestionVM value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    var questions = await _questionService.GetAll();

    if (Model.QuestionId == 0)
    {
        Shuffle(questions);
        TestQuestionVM.RandomQuestion = new List<QuestionVM>();
        TestQuestionVM.RandomQuestion = questions;
    }

    QuestionVM question = new QuestionVM();

    if (Model.QuestionNumber == 1)
    {
        question = TestQuestionVM.RandomQuestion.FirstOrDefault(x => x.TestId == Model.TestId);
        TestQuestionVM.RandomQuestion.Remove(question);
    }
    else
    {
        question = TestQuestionVM.RandomQuestion.FirstOrDefault(x => x.TestId == Model.TestId);
        TestQuestionVM.RandomQuestion.Remove(question);
    }

    List<AnswerVM> answers = new List<AnswerVM>();
    int countRightAnswers = 0;

    var questionRight = new List<QuestionVM>();
    var questionNotRight = new List<QuestionVM>();
    var persent = 0;
    var status = string.Empty;

    var test = await _testService.GetById(Model.TestId);
    var theme = await _themeService.GetById(test.ThemeId);

    if (question != null)
    {
        answers = _answerService
            .GetAll()
            .GetAwaiter().GetResult()
            .Where(x => x.QuestionId == question.QuestionId).ToList();

        countRightAnswers = answers.Count(x => x.IsRight);
    }
    else
    {
        questionRight = TestQuestionVM.QuestionRightList;
        questionNotRight = TestQuestionVM.QuestionNotRightList;

        persent = Model.CountSelectRightAnswer * 100 / Model.CountRightAnswer;





        Management management = null;
        if (persent <= 30)
        {
            status = "Плохой результат. Вам следует перечитать тему несколько раз и тестировать код предложенный в теме, чтобы усвоить весь материал.";
        }
        else if (persent > 30 && persent <= 60)
        {
            status = "Результат ниже среднего. Вам следует перечитать тему два раза и вы улучшите свой результат.";
        }
        else if (persent > 60 && persent <= 90)
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.Identity.Name.Equals("admin@gmail.com"))
                {
                    var user = await _userManager.FindByNameAsync(User.Identity.Name);

                    var managements = _context.Managements
                        .Where(x => x.UserId == user.Id)
                        .ToList();

                    var isExists = managements.Any(x => x.ThemeId == theme.ThemeId);

                    if (!isExists)
                    {

                        management = new Management()
                        {
                            ThemeId = theme.ThemeId,
                            IsEnable = true,
                            UserId = user.Id
                        };

                        _context.Managements.Add(management);

                        await _context.SaveChangesAsync();
                    }
                }
            }

            status = "Хороший результат, выше среднего. Перечитайте тему 1 раз и вы достигните наилучшего результата!";
        }
        else
        {
            if (User.Identity.IsAuthenticated)
            {
                if (!User.Identity.Name.Equals("admin@gmail.com"))
                {
                    var user = await _userManager.FindByNameAsync(User.Identity.Name);

                    var managements = _context.Managements
                        .Where(x => x.UserId == user.Id)
                        .ToList();

                    var isExists = managements.Any(x => x.ThemeId == theme.ThemeId);

                    if (!isExists)
                    {

                        management = new Management()
                        {
                            ThemeId = theme.ThemeId,
                            IsEnable = true,
                            UserId = user.Id
                        };

                        _context.Managements.Add(management);

                        await _context.SaveChangesAsync();
                    }

                    //theme.IsEnableTheme = true;
                    //await _context.SaveChangesAsync();
                }
            }

            status = "Отличный результат, вы можете смело переходить к следующей теме для изучения!";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mt-5 mb-5\">\r\n    <div class=\"col-md-3\">\r\n\r\n\r\n    </div>\r\n    <div class=\"text-center col-md-6\">\r\n\r\n");
#nullable restore
#line 173 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
         if (question != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>");
#nullable restore
#line 175 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
           Write(question.SomeQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 177 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
             if (!string.IsNullOrEmpty(question.Avatar))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 179 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                 if (!string.IsNullOrEmpty(question.Avatar))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"mt-5\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 5546, "\"", 5581, 1);
#nullable restore
#line 182 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 5552, Url.Content(question.Avatar), 5552, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 300px; width: 700px\" />\r\n                    </div>\r\n                    <hr />\r\n");
#nullable restore
#line 185 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 186 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
             

            using (Html.BeginForm("Test", "Home", FormMethod.Get))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 190 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 191 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-success list-unstyled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"hidden\" name=\"TestId\"");
            BeginWriteAttribute("value", " value=\"", 5990, "\"", 6011, 1);
#nullable restore
#line 193 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 5998, Model.TestId, 5998, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"QuestionId\"");
            BeginWriteAttribute("value", " value=\"", 6071, "\"", 6099, 1);
#nullable restore
#line 194 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 6079, question.QuestionId, 6079, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"QuestionNumber\"");
            BeginWriteAttribute("value", " value=\"", 6163, "\"", 6198, 1);
#nullable restore
#line 195 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 6171, Model.QuestionNumber + 1, 6171, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"CountRightAnswer\"");
            BeginWriteAttribute("value", " value=\"", 6264, "\"", 6295, 1);
#nullable restore
#line 196 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 6272, Model.CountRightAnswer, 6272, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"CountSelectRightAnswer\"");
            BeginWriteAttribute("value", " value=\"", 6367, "\"", 6404, 1);
#nullable restore
#line 197 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 6375, Model.CountSelectRightAnswer, 6375, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("                <div class=\"mt-3\">\r\n");
#nullable restore
#line 200 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                     if (countRightAnswers > 1)
                    {
                        foreach (AnswerVM answer in answers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>\r\n                                <input type=\"checkbox\" class=\"option-input checkbox\"");
            BeginWriteAttribute("value", " value=\"", 6730, "\"", 6756, 1);
#nullable restore
#line 205 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 6738, answer.SomeAnswer, 6738, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"AnswerChecked\" />\r\n                                ");
#nullable restore
#line 206 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                           Write(answer.SomeAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n");
#nullable restore
#line 208 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                        }
                    }
                    else if (countRightAnswers == 1 && answers.Count == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"text\" class=\"form-control m-3 mb-3 w-100\" autocomplete=\"off\" placeholder=\"Ваш ответ\" name=\"AnswerChecked\" />\r\n");
#nullable restore
#line 213 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                    }
                    else
                    {
                        foreach (AnswerVM answer in answers)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <label>\r\n                                <input type=\"radio\" class=\"option-input radio\"");
            BeginWriteAttribute("value", " value=\"", 7445, "\"", 7471, 1);
#nullable restore
#line 219 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 7453, answer.SomeAnswer, 7453, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"AnswerChecked\" />\r\n                                ");
#nullable restore
#line 220 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                           Write(answer.SomeAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </label>\r\n");
#nullable restore
#line 222 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"btn-group\" role=\"group\" aria-label=\"Basic example\">\r\n                        <button type=\"submit\" class=\"btn-custom btn-primary\">Следующий</button>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 229 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"text-center\">\r\n                <h3>");
#nullable restore
#line 234 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
               Write(theme.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h5 class=\"mt-4\"><b>Совет: </b>");
#nullable restore
#line 235 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                                          Write(status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <span style=\"font-size: 24px\" class=\"mt-4\"><b>Результат: ");
#nullable restore
#line 236 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                                                                    Write(persent);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</b></span>\r\n\r\n");
#nullable restore
#line 238 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                 if (User.Identity.IsAuthenticated)
                {
                    if (!User.Identity.Name.Equals("admin@gmail.com"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row text-center mt-4\">\r\n                            <div class=\"col-md-6\">\r\n");
#nullable restore
#line 244 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                                 using (Html.BeginForm("SaveAchievement", "Account", FormMethod.Post))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"hidden\" name=\"TestId\"");
            BeginWriteAttribute("value", " value=\"", 8648, "\"", 8669, 1);
#nullable restore
#line 246 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 8656, Model.TestId, 8656, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <input type=\"hidden\" name=\"Persent\"");
            BeginWriteAttribute("value", " value=\"", 8746, "\"", 8762, 1);
#nullable restore
#line 247 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 8754, persent, 8754, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"ml-5 mr-5 btn btn-lg btn-primary\">Сохранить результат теста</button>\r\n");
#nullable restore
#line 249 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                            <div class=\"col-md-6\">\r\n");
#nullable restore
#line 252 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                                 using (Html.BeginForm("SaveAdvice", "Account", FormMethod.Post))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <input type=\"hidden\" name=\"TestId\"");
            BeginWriteAttribute("value", " value=\"", 9230, "\"", 9251, 1);
#nullable restore
#line 254 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 9238, Model.TestId, 9238, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <input type=\"hidden\" name=\"Status\"");
            BeginWriteAttribute("value", " value=\"", 9327, "\"", 9342, 1);
#nullable restore
#line 255 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
WriteAttributeValue("", 9335, status, 9335, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"ml-5 mr-5 btn btn-lg btn-primary\">Сохранить совет</button>\r\n");
#nullable restore
#line 257 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 260 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"mt-4\">\r\n                <h4 style=\"margin-bottom: 5px;\"><span style=\"border-bottom: 3px solid #6a4dcb\">Неправильные вопросы</span></h4>\r\n                <div class=\"mt-2\">\r\n");
#nullable restore
#line 266 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                     foreach (QuestionVM q in questionNotRight)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>\r\n                            <input type=\"radio\" class=\"option-input radio\" checked disabled />\r\n                            ");
#nullable restore
#line 270 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                       Write(q.SomeQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n");
#nullable restore
#line 272 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"mt-5\">\r\n                <h4 style=\"margin-bottom: 5px;\"><span style=\"border-bottom: 3px solid #6a4dcb\">Правильные вопросы</span></h4>\r\n                <div class=\"mt-2\">\r\n");
#nullable restore
#line 278 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                     foreach (QuestionVM q in questionRight)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>\r\n                            <input type=\"radio\" class=\"option-input radio\" checked disabled />\r\n                            ");
#nullable restore
#line 282 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                       Write(q.SomeQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </label>\r\n");
#nullable restore
#line 284 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 287 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Test.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-md-3\">\r\n\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IThemeService _themeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAnswerService _answerService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITestService _testService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IQuestionService _questionService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationContext _context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestQuestionVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
