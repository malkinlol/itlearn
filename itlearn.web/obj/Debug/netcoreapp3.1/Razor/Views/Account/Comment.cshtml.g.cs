#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "abf25e28e6a11c80bc87b122a72a0eca993355ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Comment), @"mvc.1.0.view", @"/Views/Account/Comment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf25e28e6a11c80bc87b122a72a0eca993355ee", @"/Views/Account/Comment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Comment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
  
    var user = await userManager.FindByNameAsync(User.Identity.Name);

    var comments = _context.Comments
        .Where(x => x.UserId == user.Id)
        .OrderByDescending(x => x.CommentDate)
        .ToList();

    var commentsCourse = _context.CourseComments
        .Where(x => x.UserId == user.Id)
        .OrderByDescending(x => x.CommentDate)
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
        <h2>Мои комментарии</h2>
    </div>
    <hr />
    <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
        <li class=""nav-item"" role=""presentation"">
            <a class=""nav-link active"" id=""post-tab"" data-toggle=""tab"" href=""#post"" role=""tab"" aria-controls=""post"" aria-selected=""true"">Комментарии к постам</a>
        </li>
        <li class=""nav-item"" role=""presentation"">
            <a class=""nav-link"" id=""course-tab"" data-toggle=""tab"" href=""#course"" role=""tab"" aria-controls=""course"" aria-selected=""false"">Комментарии к курсам</a>
        </li>

    </ul>
    <div class=""tab-content"" id=""myTabContent"">
        <div class=""tab-pane fade show active"" id=""post"" role=""tabpanel"" aria-labelledby=""post-");
            WriteLiteral("tab\">\r\n");
#nullable restore
#line 51 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
             if (comments.Count != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"listPost\" class=\"mt-4\">\r\n\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""mt-3 mb-3"">
                    <div style=""text-align:center;"">
                        <input type=""button"" class=""btn btn-dark btn-lg"" id=""firstPost"" onclick=""firstPagePost()"" value=""Начало"" />
                        <input type=""button"" class=""btn btn-dark btn-lg"" id=""previousPost"" onclick=""previousPagePost()"" value=""Предыдущая"" />
                        <input type=""button"" class=""btn btn-dark btn-lg"" id=""nextPost"" onclick=""nextPagePost()"" value=""Следующая"" />
                        <input type=""button"" class=""btn btn-dark btn-lg"" id=""lastPost"" onclick=""lastPagePost()"" value=""Конец"" />
                    </div>
                </div>
");
#nullable restore
#line 65 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size: 25px;\">Пока у вас нет комментариев к постам...</p>\r\n");
#nullable restore
#line 69 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"tab-pane fade\" id=\"course\" role=\"tabpanel\" aria-labelledby=\"course-tab\">\r\n");
#nullable restore
#line 72 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
             if (commentsCourse.Count != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div id=\"listCourse\" class=\"mt-4\">\r\n\r\n                </div>\r\n");
            WriteLiteral(@"                <div class=""mt-3 mb-3"">
                    <div style=""text-align:center;"">
                        <input type=""button"" class=""btn btn-dark btn-lg"" id=""firstCourse"" onclick=""firstPageCourse()"" value=""Начало"" />
                        <input type=""button"" class=""btn btn-dark btn-lg"" id=""previousCourse"" onclick=""previousPageCourse()"" value=""Предыдущая"" />
                        <input type=""button"" class=""btn btn-dark btn-lg"" id=""nextCourse"" onclick=""nextPageCourse()"" value=""Следующая"" />
                        <input type=""button"" class=""btn btn-dark btn-lg"" id=""lastCourse"" onclick=""lastPageCourse()"" value=""Конец"" />
                    </div>
                </div>
");
#nullable restore
#line 86 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p style=\"font-size: 25px;\">Пока у вас нет комментариев к курсам...</p>\r\n");
#nullable restore
#line 90 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n<script>\r\n    var listPost = ");
#nullable restore
#line 99 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
              Write(Html.Raw(Json.Serialize(comments)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    var pageListPost = new Array();
    var currentPagePost = 1;
    var numberPerPagePost = 5;
    var numberOfPagesPost = 0;

    function makeListPost() {
        numberOfPagesPost = getNumberOfPagesPost();
    }

    function getNumberOfPagesPost() {
        return Math.ceil(");
#nullable restore
#line 110 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
                    Write(comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" / numberPerPagePost);
    }

    function nextPagePost() {
        currentPagePost += 1;
        loadListPost();
    }

    function previousPagePost() {
        currentPagePost -= 1;
        loadListPost();
    }

    function firstPagePost() {
        currentPagePost = 1;
        loadListPost();
    }

    function lastPagePost() {
        currentPagePost = numberOfPagesPost;
        loadListPost();
    }

    function loadListPost() {
        var beginPost = ((currentPagePost - 1) * numberPerPagePost);
        var endPost = beginPost + numberPerPagePost;

        pageListPost = listPost.slice(beginPost, endPost);
        drawListPost();
        checkPost();
    }

    function drawListPost() {
        console.log('1');
        //document.getElementById(""listPost"").innerHTML = """";
        for (r = 0; r < pageListPost.length; r++) {
            console.log(pageListPost[r]);
            let date = new Date(pageListPost[r].commentDate);
            var card =
           ");
            WriteLiteral(@"     ""<div class='card w-100 mt-3 mb-3 shadow'>"" +
                    ""<div class='modal-header' style='background: none;'>"" +
                        ""<a href='/Comment/Delete?commentId="" + pageListPost[r].commentId + ""' class='close' data-dismiss='modal' aria-label='Close'>"" +
                            ""<span aria-hidden='true'>&times;</span>"" +
                        ""</a>"" +
                    ""</div>"" +
                    ""<div class='card-body'>"" +
                        ""<h5 class='card-title'>"" +
                        ""<a href='/Post/Detail?postId="" + pageListPost[r].postId +""' style='text-decoration: none;'>Перейти к посту</a></h5>"" +
                        ""<p class='card-text'>"" + pageListPost[r].message + ""</p>"" +
                        ""<div class='form-inline mt-3'>"" +
                            ""<label class='ml-2 mr-2'><b>"" + date.toLocaleDateString() + ""</b></label>"" +
                        ""</div>"" +
                    ""</div>"" +
                ""</div>"";

    ");
            WriteLiteral(@"        document.getElementById(""listPost"").innerHTML += card;
        }
    }

    function checkPost() {
        document.getElementById(""nextPost"").disabled = currentPagePost == numberOfPagesPost ? true : false;
        document.getElementById(""previousPost"").disabled = currentPagePost == 1 ? true : false;
        document.getElementById(""firstPost"").disabled = currentPagePost == 1 ? true : false;
        document.getElementById(""lastPost"").disabled = currentPagePost == numberOfPagesPost ? true : false;
    }

    function loadPost() {
        makeListPost();
        loadListPost();
    }

    loadPost();
</script>



<script>
    var listCourse = ");
#nullable restore
#line 187 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
                Write(Html.Raw(Json.Serialize(commentsCourse)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
    var pageListCourse = new Array();
    var currentPageCourse = 1;
    var numberPerPageCourse = 5;
    var numberOfPagesCourse = 0;

    function makeListCourse() {
        numberOfPagesCourse = getNumberOfPagesCourse();
    }

    function getNumberOfPagesCourse() {
        return Math.ceil(");
#nullable restore
#line 198 "E:\Projects\itlearn\itlearn.web\Views\Account\Comment.cshtml"
                    Write(commentsCourse.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" / numberPerPageCourse);
    }

    function nextPageCourse() {
        currentPageCourse += 1;
        loadListCourse();
    }

    function previousPageCourse() {
        currentPageCourse -= 1;
        loadListCourse();
    }

    function firstPageCourse() {
        currentPageCourse = 1;
        loadListCourse();
    }

    function lastPageCourse() {
        currentPageCourse = numberOfPagesCourse;
        loadListCourse();
    }

    function loadListCourse() {
        var beginCourse = ((currentPageCourse - 1) * numberPerPageCourse);
        var endCourse = beginCourse + numberPerPageCourse;

        pageListCourse = listCourse.slice(beginCourse, endCourse);
        drawListCourse();
        checkCourse();
    }

    function drawListCourse() {
        document.getElementById(""listCourse"").innerHTML = """";
        for (r = 0; r < pageListCourse.length; r++) {
            //console.log(pageListCourse[r]);
            let date = new Date(pageListCourse[r].commentDate);");
            WriteLiteral(@"
            var card =
                ""<div class='card w-100 mt-3 mb-3 shadow'>"" +
                    ""<div class='modal-header' style='background: none;'>"" +
                    ""<a href='/Account/DeleteCourseComment?commentId="" + pageListCourse[r].commentId + ""' class='close' data-dismiss='modal' aria-label='Close'>"" +
                        ""<span aria-hidden='true'>&times;</span>"" +
                    ""</a>"" +
                ""</div>"" +
                    ""<div class='card-body'>"" +
                        ""<h5 class='card-title'>"" +
                        ""<a href='/Account/ShowCourse?courseId="" + pageListCourse[r].courseId +""' style='text-decoration: none;'>Перейти на курс</a></h5>"" +
                        ""<p class='card-text'>"" + pageListCourse[r].message + ""</p>"" +
                        ""<div class='form-inline mt-3'>"" +
                            ""<label class='ml-2 mr-2'><b>"" + date.toLocaleDateString() + ""</b></label>"" +
                        ""</div>"" +
              ");
            WriteLiteral(@"      ""</div>"" +
                ""</div>"";

            document.getElementById(""listCourse"").innerHTML += card;
        }
    }

    function checkCourse() {
        document.getElementById(""nextCourse"").disabled = currentPageCourse == numberOfPagesCourse ? true : false;
        document.getElementById(""previousCourse"").disabled = currentPageCourse == 1 ? true : false;
        document.getElementById(""firstCourse"").disabled = currentPageCourse == 1 ? true : false;
        document.getElementById(""lastCourse"").disabled = currentPageCourse == numberOfPagesCourse ? true : false;
    }

    function loadCourse() {
        makeListCourse();
        loadListCourse();
    }

    loadCourse();
</script>


");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICommentService commentService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationContext _context { get; private set; }
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
