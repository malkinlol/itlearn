#pragma checksum "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c09eafa58567c0254a96d27cb6f353fa32860645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Theme), @"mvc.1.0.view", @"/Views/Home/Theme.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c09eafa58567c0254a96d27cb6f353fa32860645", @"/Views/Home/Theme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Theme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThemeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
  
    var chapter = await chapterService.GetById(Model.ChapterId);

    var language = await languageService.GetById(chapter.LanguageId);

    var firstTheme = themeService.GetAll()
        .GetAwaiter().GetResult()
        .Where(x => x.LanguageId == language.LanguageId)
        .FirstOrDefault();

    var isFirstTheme = firstTheme.ThemeId == Model.ThemeId;

    var chapters = chapterService.GetAll()
     .GetAwaiter().GetResult()
     .Where(x => x.LanguageId == Model.LanguageId && x.IsEnable)
     .ToList();

    var tests = testService.GetAll()
        .GetAwaiter().GetResult()
        .Where(x => x.ThemeId == Model.ThemeId && x.IsCorrectTest)
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\" id=\"description\"");
            BeginWriteAttribute("value", " value=\"", 963, "\"", 989, 1);
#nullable restore
#line 33 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
WriteAttributeValue("", 971, Model.Description, 971, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

<div style=""height: 100vh; width: 100%;position:relative; background-image: url('/images/backgrounds/languageBg.jpg'); background-repeat: no-repeat; background-size: cover;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8 text-white"">
                <div class=""mt-5 mb-5"">
                    <nav aria-label=""breadcrumb"" style=""background: none"">
                        <ol class=""breadcrumb"" style=""background: none; font-size: 24px;"">
                            <li class=""breadcrumb-item""><a href=""/Home/Index"" class=""text-white"">Главная</a></li>
                            <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 1658, "\"", 1711, 2);
            WriteAttributeValue("", 1665, "/Home/Language?languageId=", 1665, 26, true);
#nullable restore
#line 43 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
WriteAttributeValue("", 1691, language.LanguageId, 1691, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white\">");
#nullable restore
#line 43 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                                                                                                                               Write(language.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">Основы</li>
                        </ol>
                    </nav>
                </div>
                <div class=""mt-5 mb-5"">
                    <h1 class=""display-3"" style=""font-weight: 600"">");
#nullable restore
#line 49 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                                                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-4\">\r\n                        <p class=\"text-secondary\" style=\"font-size:20px\"><b>Время чтения</b></p>\r\n                        <p><b>");
#nullable restore
#line 54 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                         Write(Model.CountReadTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" минут</b></p>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <p class=\"text-secondary\" style=\"font-size:20px\"><b>Опубликована</b></p>\r\n                        <p><b>");
#nullable restore
#line 58 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                         Write(Model.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <p class=\"text-secondary\" style=\"font-size:20px\"><b>Изменена</b></p>\r\n                        <p><b>");
#nullable restore
#line 62 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                         Write(Model.UpdatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></p>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">

            </div>
        </div>
    </div>
</div>
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-9"" style=""background-color: #ffffff; bottom: 80px; z-index: 100;"">
            <div class=""card shadow m-5"">
                <div class=""card-body"">
                    <div class=""mt-2 mb-4"">
");
#nullable restore
#line 78 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {
                            if (!User.Identity.Name.Equals("admin@gmail.com"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <button type=\"button\" data-toggle=\"modal\" data-target=\"#storyAccountModal\" class=\"btn-custom btn-primary text-white\">Остановиться</button>\r\n");
#nullable restore
#line 83 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 86 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                     if (isFirstTheme)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("style", " style=\"", 3813, "\"", 3911, 9);
            WriteAttributeValue("", 3821, "height:350px;", 3821, 13, true);
            WriteAttributeValue(" ", 3834, "width:", 3835, 7, true);
            WriteAttributeValue(" ", 3841, "100%;", 3842, 6, true);
            WriteAttributeValue(" ", 3847, "background:", 3848, 12, true);
            WriteAttributeValue(" ", 3859, "url(", 3860, 5, true);
#nullable restore
#line 88 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
WriteAttributeValue("", 3864, Url.Content(language.Avatar), 3864, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3893, ")", 3893, 1, true);
            WriteAttributeValue(" ", 3894, "no-repeat", 3895, 10, true);
            WriteAttributeValue(" ", 3904, "center", 3905, 7, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        </div>\r\n                        <h2 class=\"mt-2\">Начало работы: ");
#nullable restore
#line 91 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                                                   Write(language.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <div id=\"content\" class=\"mt-3\">\r\n\r\n                        </div>\r\n");
#nullable restore
#line 95 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div id=\"content\"");
            BeginWriteAttribute("class", " class=\"", 4230, "\"", 4238, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                        </div>\r\n");
#nullable restore
#line 101 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"col-md-3\">\r\n            <div class=\"mt-3\">\r\n");
#nullable restore
#line 120 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                 using (Html.BeginForm("Search", "Home", FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""form-row"">
                        <div class=""col-12 col-md-10 mb-2"">
                            <input type=""text"" class=""form-control form-control-lg"" name=""SearchText"" placeholder=""Искать..."">
                        </div>
                        <div class=""col-12 col-md-2"">
                            <button type=""submit"" class=""btn btn-block btn-lg btn-primary""><span class=""iconify"" data-icon=""simple-line-icons:magnifier"" data-inline=""false""></span></button>
                        </div>
                    </div>
");
#nullable restore
#line 130 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"mt-5\">\r\n                <div class=\"accordion\">\r\n");
#nullable restore
#line 134 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                     foreach (ChapterVM c in chapters)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                   Write(await Html.PartialAsync("~/Views/Home/Partial/_ChapterShowPartial.cshtml", c));

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                                                                                                      
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n");
#nullable restore
#line 140 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
             if (tests.Count != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mt-5 text-center\">\r\n                    <a href=\"#tests\" class=\"btn-custom btn-primary\">Перейти к тестам</a>\r\n                </div>\r\n");
#nullable restore
#line 145 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 148 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
     if (tests.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <hr />
        <div class=""container mb-5"" id=""tests"">
            <div class=""text-center"">
                <h2>Тест</h2>
            </div>
            <div class=""row"">
                <div class=""col-md-3"">

                </div>
                <div class=""col-md-6"">
                    <div class=""col mb-4"">
                        <div class=""card shadow"">
                            <div class=""card-body"">
");
            WriteLiteral("                            </div>\r\n                            <div class=\"card-footer\" style=\"background:none;\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7237, "\"", 7301, 4);
            WriteAttributeValue("", 7244, "/Home/Test?themeId=", 7244, 19, true);
#nullable restore
#line 166 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
WriteAttributeValue("", 7263, Model.ThemeId, 7263, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7277, "&testId=", 7277, 8, true);
#nullable restore
#line 166 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
WriteAttributeValue("", 7285, tests[0].TestId, 7285, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Перейти</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n        </div>\r\n");
#nullable restore
#line 174 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""modal fade"" id=""storyAccountModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 181 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Вы уверены, что хотите остановиться на этой теме?</p>
");
#nullable restore
#line 188 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                 using (Html.BeginForm("Story", "Account", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\" name=\"ThemeId\"");
            BeginWriteAttribute("value", " value=\"", 8331, "\"", 8353, 1);
#nullable restore
#line 190 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
WriteAttributeValue("", 8339, Model.ThemeId, 8339, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"Index\"");
            BeginWriteAttribute("value", " value=\"", 8412, "\"", 8432, 1);
#nullable restore
#line 191 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
WriteAttributeValue("", 8420, Model.Index, 8420, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"ChapterId\"");
            BeginWriteAttribute("value", " value=\"", 8495, "\"", 8519, 1);
#nullable restore
#line 192 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
WriteAttributeValue("", 8503, Model.ChapterId, 8503, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <input type=\"submit\" class=\"btn btn-success\" value=\"Остановиться\" />\r\n");
#nullable restore
#line 194 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Home\Theme.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<script>
    let editor;

    ClassicEditor
        .create(document.querySelector('#editor'))
        .then(newEditor => {
            editor = newEditor;
        })
        .catch(error => {
            console.error(error);
        });

    function GetDescription() {
        const editorData = editor.getData();

        document.getElementById('description').setAttribute('value', editorData);
    }
</script>

<script>
    window.onload = function () {
        document.getElementById('content').innerHTML = document.getElementById('description').value;
    };
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ITestService testService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IThemeService themeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ILanguageService languageService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IChapterService chapterService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThemeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
