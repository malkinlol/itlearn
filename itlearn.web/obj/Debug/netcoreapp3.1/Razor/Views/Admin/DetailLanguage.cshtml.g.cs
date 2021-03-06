#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82476995f5034ed494677bf352b72568505d4a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DetailLanguage), @"mvc.1.0.view", @"/Views/Admin/DetailLanguage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82476995f5034ed494677bf352b72568505d4a57", @"/Views/Admin/DetailLanguage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DetailLanguage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LanguageVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
  
    var chapters = chapterService.GetAll()
        .GetAwaiter().GetResult()
        .Where(x => x.LanguageId == Model.LanguageId)
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <section class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"alert alert-light mt-2 mb-2\">\r\n                <h2>Описание языка программирования: ");
#nullable restore
#line 17 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
                                                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <input type=\"hidden\" id=\"description\"");
            BeginWriteAttribute("value", " value=\"", 561, "\"", 587, 1);
#nullable restore
#line 18 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
WriteAttributeValue("", 569, Model.Description, 569, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <hr />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 635, "\"", 690, 2);
            WriteAttributeValue("", 642, "/Admin/EditLanguage?languageId=", 642, 31, true);
#nullable restore
#line 20 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
WriteAttributeValue("", 673, Model.LanguageId, 673, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Изменить</a>\r\n                <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 772, "\"", 828, 2);
            WriteAttributeValue("", 779, "/Admin/CreateChapter?languageId=", 779, 32, true);
#nullable restore
#line 21 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
WriteAttributeValue("", 811, Model.LanguageId, 811, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Добавить главу</a>\r\n                <button type=\"submit\" data-toggle=\"modal\" data-target=\"#deleteModal\" class=\"btn btn-danger\">Удалить</button>\r\n            </div>\r\n\r\n            <div>\r\n");
#nullable restore
#line 26 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
                 if (chapters.Count != 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <ul>\r\n");
#nullable restore
#line 29 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
                         foreach (ChapterVM chapter in chapters)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 1232, "\"", 1288, 2);
            WriteAttributeValue("", 1239, "/Admin/DetailChapter?chapterId=", 1239, 31, true);
#nullable restore
#line 31 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
WriteAttributeValue("", 1270, chapter.ChapterId, 1270, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
                                                                                       Write(chapter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 32 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n");
#nullable restore
#line 34 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

            <div id=""content"" class=""col-md-12"">

            </div>
        </div>
    </section>
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
        let data = document.getElementById('description').value;
             let fixeddata = '';
        let fixeddata1 = '';
        let fixeddata2 = '';
        console.log(data);
        if (data.includes('oembed')) {
            fixeddata = data.replace(new RegExp('<oembed url', 'g'), '<iframe src')
            fixeddata1 = fixeddata.replace(new RegExp(""watch\\?v="", 'g'), 'embed/')
   ");
            WriteLiteral(@"         fixeddata2 = fixeddata1.replace(new RegExp('></oembed', 'g'), ' width=""960"" height=""540"" frameBorder=""0"" allow=""autoplay; encrypted-media"" allowFullScreen title=""video""></iframe');
        } else {
            fixeddata2 = data;
        }

        document.getElementById('content').innerHTML = fixeddata2;
    };
</script>

<div class=""modal fade"" id=""deleteModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Удаление</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Вы уверены, что хотите удалить язык программирования: ");
#nullable restore
#line 95 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
                                                                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 96 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
                 using (Html.BeginForm("DeleteLanguage", "Admin", FormMethod.Get))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <input type=\"hidden\" name=\"LanguageId\"");
            BeginWriteAttribute("value", " value=\"", 3574, "\"", 3599, 1);
#nullable restore
#line 98 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
WriteAttributeValue("", 3582, Model.LanguageId, 3582, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral("                    <input type=\"submit\" class=\"btn btn-danger\" value=\"Удалить\" />\r\n");
#nullable restore
#line 101 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailLanguage.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanguageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
