#pragma checksum "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17efca76ddca02b9294ac470dc5f45a64da97298"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateLanguage), @"mvc.1.0.view", @"/Views/Admin/CreateLanguage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17efca76ddca02b9294ac470dc5f45a64da97298", @"/Views/Admin/CreateLanguage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateLanguage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LanguageVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml"
  
    ViewData["Title"] = "CreateLanguage";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <section class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <h1>Создание</h1>\r\n            <hr />\r\n");
#nullable restore
#line 12 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml"
             using (Html.BeginForm("CreateLanguage", "Admin", FormMethod.Post, new { enctype = "multipart/form-data" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"hidden\" id=\"description\" name=\"Description\" />\r\n");
            WriteLiteral("                <div class=\"form-group row\">\r\n                    <label class=\"col-sm-2 col-form-label\"><b>Название</b></label>\r\n                    <div class=\"col-sm-10\">\r\n                        <input type=\"text\" class=\"form-control\" name=\"Name\"");
            BeginWriteAttribute("value", " value=\"", 868, "\"", 887, 1);
#nullable restore
#line 22 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml"
WriteAttributeValue("", 876, Model.Name, 876, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 23 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group row"">
                    <label for=""inputAvatar"" class=""col-sm-2 col-form-label"">Аватар</label>
                    <div class=""col-sm-10"">
                        <input type=""file"" class=""form-control"" id=""inputAvatar"" name=""uploadedFile"" required>
                    </div>
                </div>
                <div class=""form-group"">
                    <label class=""col-form-label""><b>Описание</b></label>
                    <p>
                        ");
#nullable restore
#line 35 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <div id=\"editor\" class=\"editor\">\r\n\r\n                    </div>\r\n                </div>\r\n                <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Создать\" onclick=\"GetDescription()\" />\r\n");
#nullable restore
#line 42 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\CreateLanguage.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </section>
</div>

<script>
    let editor;
    //'imageUpload', 'mediaEmbed'
    ClassicEditor
        .create(document.querySelector('#editor'), {
            toolbar: ['heading', '|', 'undo', 'redo', 'bold', 'italic', 'bulletedList', 'numberedList']

        })
        //.create(document.querySelector('#editor'))
        .then(dataEditor => {
            editor = dataEditor;
        })
        .catch(error => {
            console.error(error);
        });

    function GetDescription() {
        const dataEditor = editor.getData();

        let substing = '';
        let substing1 = '';
        let substing2 = '';
        console.log(dataEditor);
        if (dataEditor.includes('iframe')) {
            substing = dataEditor.replace(new RegExp('<iframe src', 'g'), '<oembed url')
            substing1 = substing.replace(new RegExp(""embed/"", 'g'), 'watch?v=')
            substing2 = substing1.replace(new RegExp(' width=""960"" height=""540"" frameBorder=""0"" allow=");
            WriteLiteral(@"""autoplay; encrypted-media"" allowFullScreen title=""video""></iframe', 'g'), '></oembed');
        } else {
            substing2 = dataEditor;
        }

        document.getElementById('description').setAttribute('value', substing2);
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LanguageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
