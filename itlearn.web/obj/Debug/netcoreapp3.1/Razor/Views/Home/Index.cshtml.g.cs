#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad4d8a55dddbddcb928322ed1e4c1e844c2c833d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad4d8a55dddbddcb928322ed1e4c1e844c2c833d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: Arial"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-2 img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default/default-person.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("60"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
  
    var courses = _context.Courses
        .Include(x => x.User)
        .Where(x => x.Approved)
        .OrderByDescending(x => x.UpdatedDate)
        .Take(4)
        .ToList();

    var comments = _context.CourseComments
        .Include(x => x.User)
        .Where(x => !x.isAdmin)
        .OrderByDescending(x => x.CommentDate)
        .Take(3)
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    div.bg {
        position: relative
    }

        div.bg div {
            margin: 0;
            position: absolute;
            top: 50%;
            left: 50%;
            margin-right: -50%;
            transform: translate(-50%, -50%)
        }

    .nav-link:hover {
        border-bottom: 2px solid #000000;
        margin-bottom: -2px;
    }
</style>

<div class=""bg"" style=""height: 500px; background-image: url(/images/default/homeBg.jpg); background-size: cover"">
    <div class=""text-white"">
        <h1 class=""display-3 mb-5"">Мы учимся на новых высотах</h1>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad4d8a55dddbddcb928322ed1e4c1e844c2c833d12365", async() => {
                WriteLiteral(@"
            <input type=""text"" autocomplete=""off"" class=""form-control col-md-9"" name=""SearchText"" placeholder=""Что вы хотите узнать сегодня?"" />
            <input type=""submit"" class=""btn btn-warning col-auto"" value=""Поиск"" style=""margin-left: 20px; width: 200px;"" />
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""container"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card shadow"" style=""z-index: 1000; bottom: 100px;"">
                <div class=""row"">
                    <div class=""col-md-6 text-center pl-5 pt-2"">
                        <p class=""display-1"" style=""font-size: 45px;"">Найдите свое призвание и изучайте языки программирования!</p>
                        <p class=""display-1"" style=""font-size: 20px;"">
                            Мы предоставляем для вас бесплатно изучать языки программирования, материал которых составлен профессионалами. Также вам предоставляется возможность изучать курсы, написанные другими пользователями нашего сайта. Реализуйте эту возможность и не теряйте времени. Удачи!
                        </p>
                        <a href=""/Home/HomeIndex"" class=""mt-3 mb-3 btn btn-lg btn-success"">Изучить сейчас</a>
                    </div>
                    <div class=""col-md-6"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad4d8a55dddbddcb928322ed1e4c1e844c2c833d15189", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""container mt-5"">
    <div class=""text-center"">
        <h2>Сотни онлайн-курсов, которые расширили карьеру по всему миру</h2>
    </div>
    <div class=""mt-3"">
        <ul class=""nav justify-content-center"">
            <li class=""nav-item "">
                <a class=""nav-link text-dark"" href=""/Home/SearchCourse?course=Блокчейн"">Блокчейн</a>
            </li>
            <li class=""nav-item "">
                <a class=""nav-link text-dark"" href=""/Home/SearchCourse?course=Бизнес"">Бизнес</a>
            </li>
            <li class=""nav-item "">
                <a class=""nav-link text-dark"" href=""/Home/SearchCourse?course=Кодирование"">Кодирование</a>
            </li>
            <li class=""nav-item "">
                <a class=""nav-link text-dark"" href=""/Home/SearchCourse?course=Наука о данных"">Наука о данных</a>
            </li>
            <li class=""nav-item "">
         ");
            WriteLiteral(@"       <a class=""nav-link text-dark"" href=""/Home/SearchCourse?course=Дизайн"">Дизайн</a>
            </li>
            <li class=""nav-item "">
                <a class=""nav-link text-dark"" href=""/Home/SearchCourse?course=Личное развитие"">Личное развитие</a>
            </li>
        </ul>
    </div>
    <div class=""mt-5"">
        <div class=""card-group"">
");
#nullable restore
#line 101 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
             for (int i = 0; i < courses.Count; i++)
            {
                var commentsCourse = _context.CourseComments
                    .Where(x => x.CourseId == courses[i].CourseId && !x.isAdmin)
                    .ToList();

                var rating = 0;

                if (commentsCourse.Count != 0)
                {
                    rating = (int)commentsCourse.Average(x => x.Rating);

                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card shadow m-2 p-2\">\r\n                    <div class=\"card-header\"");
            BeginWriteAttribute("style", " style=\"", 4499, "\"", 4585, 6);
            WriteAttributeValue("", 4507, "background-image:", 4507, 17, true);
            WriteAttributeValue(" ", 4524, "url(", 4525, 5, true);
#nullable restore
#line 116 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4529, Url.Content(courses[i].Avatar), 4529, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4560, ");", 4560, 2, true);
            WriteAttributeValue(" ", 4562, "background-size:", 4563, 17, true);
            WriteAttributeValue(" ", 4579, "cover", 4580, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div style=\"height: 100px;\">\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4776, "\"", 4836, 2);
            WriteAttributeValue("", 4783, "/Account/ShowUserProfile?email=", 4783, 31, true);
#nullable restore
#line 122 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4814, courses[i].User.Email, 4814, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-secondary small\">");
#nullable restore
#line 122 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                                                                                                Write(courses[i].User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4921, "\"", 4977, 2);
            WriteAttributeValue("", 4928, "/Account/ShowCourse?courseId=", 4928, 29, true);
#nullable restore
#line 123 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 4957, courses[i].CourseId, 4957, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark\">");
#nullable restore
#line 123 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                                                                                 Write(courses[i].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"card-footer bg-white\" style=\"border: none;\">\r\n                        <div>\r\n");
#nullable restore
#line 127 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                             if (rating == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
");
#nullable restore
#line 134 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                             if (rating == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
");
#nullable restore
#line 142 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 143 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                             if (rating == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
");
#nullable restore
#line 150 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 151 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                             if (rating == 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
");
#nullable restore
#line 158 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 159 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                             if (rating == 4)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-secondary"">★</label>
");
#nullable restore
#line 166 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                             if (rating == 5)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
                                <label for=""rating3"" class=""text-warning"">★</label>
");
#nullable restore
#line 174 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <label class=\"ml-2\">");
#nullable restore
#line 176 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                           Write(rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            <label class=\"ml-2\">(");
#nullable restore
#line 177 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                            Write(commentsCourse.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</label>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 181 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
    <div class=""mt-5 text-center"">
        <a href=""/Home/SearchCourse"" class=""btn btn-lg btn-warning"">Смотреть все курсы</a>
    </div>
</div>
<div class=""bg-light"">
    <div class=""container"">
        <div class=""mt-5"">
            <div class=""text-center pt-5"">
                <h2>Отзывы студентов</h2>
            </div>
            <div class=""mt-5 pb-5"">
                <div class=""card-group"">
");
#nullable restore
#line 196 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                     for (int i = 0; i < comments.Count; i++)
                    {
                        var course = _context.Courses.FirstOrDefault(x => x.CourseId == comments[i].CourseId);

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card shadow m-2 pd-2\" style=\"border-top: 2px solid #ffc107\">\r\n                            <div class=\"card-body\">\r\n                                <p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 9505, "\"", 9557, 2);
            WriteAttributeValue("", 9512, "/Account/ShowCourse?courseId=", 9512, 29, true);
#nullable restore
#line 202 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 9541, course.CourseId, 9541, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-dark\"><b>");
#nullable restore
#line 202 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                                                                                            Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></a>\r\n                                </p>\r\n                                <hr />\r\n\r\n                                <p>");
#nullable restore
#line 206 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                              Write(comments[i].Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n                                <div class=\"row\">\r\n");
#nullable restore
#line 211 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                     if (string.IsNullOrEmpty(comments[i].User.Avatar))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-3\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad4d8a55dddbddcb928322ed1e4c1e844c2c833d30099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n");
#nullable restore
#line 216 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-md-3\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 10505, "\"", 10548, 1);
#nullable restore
#line 220 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
WriteAttributeValue("", 10511, Url.Content(comments[i].User.Avatar), 10511, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"60\" height=\"60\" style=\"border-radius: 50%\" />\r\n                                        </div>\r\n");
#nullable restore
#line 222 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"col-md-9\">\r\n                                        <p>");
#nullable restore
#line 224 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                      Write(comments[i].User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <p>");
#nullable restore
#line 225 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                                      Write(comments[i].User.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 230 "E:\Projects\itlearn\itlearn.web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
