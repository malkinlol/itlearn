#pragma checksum "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\Discussion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2418f933b8e8e83c5f9920fb7e3418e3fba9ad05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Discussion), @"mvc.1.0.view", @"/Views/Account/Discussion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2418f933b8e8e83c5f9920fb7e3418e3fba9ad05", @"/Views/Account/Discussion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Discussion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\Discussion.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\Discussion.cshtml"
  
    var user = await userManager.FindByNameAsync(User.Identity.Name);

    var posts = postService.GetAll()
        .GetAwaiter().GetResult()
        .Where(x => x.UserId == user.Id)
        .OrderByDescending(x => x.PostDate)
        .ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .card:hover {
        border-bottom: solid 3px #6a4dcb;
    }

    label {
        background-color: #6a4dcb;
        color: white;
        border-radius: 15px;
        padding: 0px 6px;
    }
</style>

<div class=""container mt-5 mb-5"">
    <div class=""mt-5 mb-5"">
        <h2>Мои посты</h2>
        <br />
        <a href=""/Post/Create"" class=""btn-custom btn-primary"">Написать пост</a>
    </div>
    <hr />
");
#nullable restore
#line 37 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\Discussion.cshtml"
     if (posts.Count != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"list\" class=\"mt-4\">\r\n\r\n        </div>\r\n");
            WriteLiteral(@"        <div class=""mt-3 mb-3"">
            <div style=""text-align:center;"">
                <input type=""button"" class=""btn btn-dark btn-lg"" id=""first"" onclick=""firstPage()"" value=""Начало"" />
                <input type=""button"" class=""btn btn-dark btn-lg"" id=""previous"" onclick=""previousPage()"" value=""Предыдущая"" />
                <input type=""button"" class=""btn btn-dark btn-lg"" id=""next"" onclick=""nextPage()"" value=""Следующая"" />
                <input type=""button"" class=""btn btn-dark btn-lg"" id=""last"" onclick=""lastPage()"" value=""Конец"" />
            </div>
        </div>
");
#nullable restore
#line 51 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\Discussion.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p style=\"font-size: 25px;\">Пока у вас нет постов...</p>\r\n");
#nullable restore
#line 55 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\Discussion.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<script>\r\n    var list = ");
#nullable restore
#line 59 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\Discussion.cshtml"
          Write(Html.Raw(Json.Serialize(posts)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    var pageList = new Array();
    var currentPage = 1;
    var numberPerPage = 5;
    var numberOfPages = 0;

    function makeList() {
        numberOfPages = getNumberOfPages();
    }

    function getNumberOfPages() {
        return Math.ceil(");
#nullable restore
#line 70 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\Discussion.cshtml"
                    Write(posts.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" / numberPerPage);
    }

    function nextPage() {
        currentPage += 1;
        loadList();
    }

    function previousPage() {
        currentPage -= 1;
        loadList();
    }

    function firstPage() {
        currentPage = 1;
        loadList();
    }

    function lastPage() {
        currentPage = numberOfPages;
        loadList();
    }

    function loadList() {
        var begin = ((currentPage - 1) * numberPerPage);
        var end = begin + numberPerPage;

        pageList = list.slice(begin, end);
        drawList();
        check();
    }

    function drawList() {
        document.getElementById(""list"").innerHTML = """";
        for (r = 0; r < pageList.length; r++) {
            console.log(pageList[r]);
            let date = new Date(pageList[r].postDate);
            var card =
                ""<div class='card w-100 mt-3 mb-3 shadow'>"" +
                ""<div class='modal-header' style='background: none;'>"" +
                ""<a href='/Post/De");
            WriteLiteral(@"lete?postId="" + pageList[r].postId + ""' class='close' data-dismiss='modal' aria-label='Close'>"" +
                    ""<span aria-hidden='true'>&times;</span>"" +
                ""</a>"" +
            ""</div>"" +
                    ""<div class='card-body'>"" +
                        ""<h5 class='card-title'>"" +
                        ""<a href='/Post/Detail?postId="" + pageList[r].postId +""' style='text-decoration: none;'>"" + pageList[r].title + ""</a></h5>"" +
                        ""<p class='card-text'>"" + pageList[r].message + ""</p>"" +
                        ""<footer class='blockquote-footer'>"" + pageList[r].tags.toString().substring(0, pageList[r].tags.toString().length - 1) + ""</footer>"" +
                        ""<div class='form-inline mt-3'>"" +
                            ""<label class='ml-2 mr-2'><b>"" + date.toLocaleDateString() + ""</b></label>"" +
                            ""<label class='ml-2 mr-2'><b>"" + pageList[r].countWatch + "" просмотров</b></label>"" +
                        ""</div>""");
            WriteLiteral(@" +
                    ""</div>"" +
                ""</div>"";

            document.getElementById(""list"").innerHTML += card;
        }
    }

    function check() {
        document.getElementById(""next"").disabled = currentPage == numberOfPages ? true : false;
        document.getElementById(""previous"").disabled = currentPage == 1 ? true : false;
        document.getElementById(""first"").disabled = currentPage == 1 ? true : false;
        document.getElementById(""last"").disabled = currentPage == numberOfPages ? true : false;
    }

    function load() {
        makeList();
        loadList();
    }

    window.onload = load;
</script>

");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IPostService postService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> userManager { get; private set; }
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