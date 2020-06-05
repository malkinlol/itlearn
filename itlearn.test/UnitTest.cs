using itlearn.bll.api.Interfaces;
using itlearn.bll.api.Services;
using itlearn.model.ViewModels.Advice;
using itlearn.model.ViewModels.Comment;
using itlearn.model.ViewModels.Language;
using itlearn.model.ViewModels.Story;
using itlearn.web.ApiControllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace itlearn.test
{
    public class UnitTest
    {
        private readonly LanguageApiController _languageApiController;
        private readonly ILanguageService _languageService;

        private readonly StoryApiController _storyApiController;
        private readonly IStoryService _storyService;

        private readonly CommentApiController _commentApiController;
        private readonly ICommentService _commentService;

        private readonly AdviceApiController _adviceApiController;
        private readonly IAdviceService _adviceService;

        public UnitTest()
        {
            _languageService = new LanguageService();
            _languageApiController = new LanguageApiController(_languageService);

            _storyService = new StoryService();
            _storyApiController = new StoryApiController(_storyService);

            _commentService = new CommentService();
            _commentApiController = new CommentApiController(_commentService);

            _adviceService = new AdviceService();
            _adviceApiController = new AdviceApiController(_adviceService);
        }

        [Fact]
        public void GetLanguages_WhenCalled_ReturnsOkResult()
        {
            var okResult = _languageApiController.GetAll();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetLanguages_WhenCalled_ReturnsAllItems()
        {
            var okResult = _languageApiController.GetAll().Result as OkObjectResult;

            var items = Assert.IsType<List<LanguageVM>>(okResult.Value);
            Assert.Equal(4, items.Count);
        }

        [Fact]
        public void GetLanguageById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            var notFoundResult = _languageApiController.GetById(5);

            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }

        [Fact]
        public void GetLanguageById_ExistingIdPassed_ReturnsOkResult()
        {
            var testId = 1;

            var okResult = _languageApiController.GetById(testId);

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetLanguageById_ExistingIdPassed_ReturnsRightItem()
        {
            var testId = 1;

            var okResult = _languageApiController.GetById(testId).Result as OkObjectResult;

            Assert.IsType<LanguageVM>(okResult.Value);
            Assert.Equal(testId, (okResult.Value as LanguageVM).LanguageId);
        }

        [Fact]
        public void AddLanguage_InvalidObjectPassed_ReturnsBadRequest()
        {
            var language = new LanguageVM()
            {
                LanguageId = 1
            };

            _languageApiController.ModelState.AddModelError("Name", "Required");

            var badResponse = _languageApiController.Post(language);

            Assert.IsType<BadRequestObjectResult>(badResponse);
        }


        [Fact]
        public void AddLanguage_ValidObjectPassed_ReturnsCreatedResponse()
        {
            LanguageVM testItem = new LanguageVM()
            {
                LanguageId = 1,
                Name = "Name",
                Description = "Description"
            };

            var createdResponse = _languageApiController.Post(testItem);

            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }


        [Fact]
        public void AddLanguage_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        {
            var testItem = new LanguageVM()
            {
                LanguageId = 1,
                Name = "Name",
                Description = "Description"
            };

            var createdResponse = _languageApiController.Post(testItem) as CreatedAtActionResult;
            var item = createdResponse.Value as LanguageVM;

            Assert.IsType<LanguageVM>(item);
            Assert.Equal("Name", item.Name);
        }

        [Fact]
        public void RemoveLanguage_NotExistingIdPassed_ReturnsNotFoundResponse()
        {
            var notExistingId = 7;

            var badResponse = _languageApiController.Remove(notExistingId);

            Assert.IsType<NotFoundResult>(badResponse);
        }

        [Fact]
        public void RemoveLanguage_ExistingIdPassed_ReturnsOkResult()
        {
            var existingId = 1;

            var okResponse = _languageApiController.Remove(existingId);

            Assert.IsType<OkResult>(okResponse);
        }
        [Fact]
        public void RemoveLanguage_ExistingIdPassed_RemovesOneItem()
        {
            var existingId = 1;

            var okResponse = _languageApiController.Remove(existingId);

            Assert.Equal(3, _languageService.GetAll().Count());
        }

        ////////////////////////////////////////////////////////////////
        ///
        [Fact]
        public void GetStory_WhenCalled_ReturnsOkResult()
        {
            var okResult = _storyApiController.GetAll();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetStory_WhenCalled_ReturnsAllItems()
        {
            var okResult = _storyApiController.GetAll().Result as OkObjectResult;

            var items = Assert.IsType<List<StoryVM>>(okResult.Value);
            Assert.Equal(4, items.Count);
        }

        [Fact]
        public void GetStoryById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            var notFoundResult = _storyApiController.GetById(5);

            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }

        [Fact]
        public void GetStoryById_ExistingIdPassed_ReturnsOkResult()
        {
            var testId = 1;

            var okResult = _storyApiController.GetById(testId);

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetStoryById_ExistingIdPassed_ReturnsRightItem()
        {
            var testId = 1;

            var okResult = _storyApiController.GetById(testId).Result as OkObjectResult;

            Assert.IsType<StoryVM>(okResult.Value);
            Assert.Equal(testId, (okResult.Value as StoryVM).StoryId);
        }

        [Fact]
        public void AddStory_InvalidObjectPassed_ReturnsBadRequest()
        {
            var story = new StoryVM()
            {
                StoryId = 1
            };

            _storyApiController.ModelState.AddModelError("Name", "Required");

            var badResponse = _storyApiController.Post(story);

            Assert.IsType<BadRequestObjectResult>(badResponse);
        }


        [Fact]
        public void AddStory_ValidObjectPassed_ReturnsCreatedResponse()
        {
            StoryVM testItem = new StoryVM()
            {
                StoryId = 1,
                Link = "Link"
            };

            var createdResponse = _storyApiController.Post(testItem);

            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }


        [Fact]
        public void AddStory_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        {
            StoryVM testItem = new StoryVM()
            {
                StoryId = 1,
                Link = "Link"
            };

            var createdResponse = _storyApiController.Post(testItem) as CreatedAtActionResult;
            var item = createdResponse.Value as StoryVM;

            Assert.IsType<StoryVM>(item);
            Assert.Equal("Link", item.Link);
        }

        [Fact]
        public void RemoveStory_NotExistingIdPassed_ReturnsNotFoundResponse()
        {
            var notExistingId = 7;

            var badResponse = _storyApiController.Remove(notExistingId);

            Assert.IsType<NotFoundResult>(badResponse);
        }

        [Fact]
        public void RemoveStory_ExistingIdPassed_ReturnsOkResult()
        {
            var existingId = 1;

            var okResponse = _storyApiController.Remove(existingId);

            Assert.IsType<OkResult>(okResponse);
        }
        [Fact]
        public void RemoveStory_ExistingIdPassed_RemovesOneItem()
        {
            var existingId = 1;

            var okResponse = _storyApiController.Remove(existingId);

            Assert.Equal(3, _storyService.GetAll().Count());
        }

        //////////////////////////////////////////////////////////////
        ///
        [Fact]
        public void GetComment_WhenCalled_ReturnsOkResult()
        {
            var okResult = _commentApiController.GetAll();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetComment_WhenCalled_ReturnsAllItems()
        {
            var okResult = _commentApiController.GetAll().Result as OkObjectResult;

            var items = Assert.IsType<List<CommentVM>>(okResult.Value);
            Assert.Equal(4, items.Count);
        }

        [Fact]
        public void GetCommentById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            var notFoundResult = _commentApiController.GetById(5);

            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }

        [Fact]
        public void GetCommentById_ExistingIdPassed_ReturnsOkResult()
        {
            var testId = 1;

            var okResult = _commentApiController.GetById(testId);

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetCommentById_ExistingIdPassed_ReturnsRightItem()
        {
            var testId = 1;

            var okResult = _commentApiController.GetById(testId).Result as OkObjectResult;

            Assert.IsType<CommentVM>(okResult.Value);
            Assert.Equal(testId, (okResult.Value as CommentVM).CommentId);
        }

        [Fact]
        public void AddComment_InvalidObjectPassed_ReturnsBadRequest()
        {
            var comment = new CommentVM()
            {
                CommentId = 1
            };

            _commentApiController.ModelState.AddModelError("Name", "Required");

            var badResponse = _commentApiController.Post(comment);

            Assert.IsType<BadRequestObjectResult>(badResponse);
        }


        [Fact]
        public void AddComment_ValidObjectPassed_ReturnsCreatedResponse()
        {
            CommentVM testItem = new CommentVM()
            {
                CommentId = 1,
                Message = "Message"
            };

            var createdResponse = _commentApiController.Post(testItem);

            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }


        [Fact]
        public void AddComment_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        {
            CommentVM testItem = new CommentVM()
            {
                CommentId = 1,
                Message = "Message"
            };

            var createdResponse = _commentApiController.Post(testItem) as CreatedAtActionResult;
            var item = createdResponse.Value as CommentVM;

            Assert.IsType<CommentVM>(item);
            Assert.Equal("Message", item.Message);
        }

        [Fact]
        public void RemoveComment_NotExistingIdPassed_ReturnsNotFoundResponse()
        {
            var notExistingId = 7;

            var badResponse = _commentApiController.Remove(notExistingId);

            Assert.IsType<NotFoundResult>(badResponse);
        }

        [Fact]
        public void RemoveComment_ExistingIdPassed_ReturnsOkResult()
        {
            var existingId = 1;

            var okResponse = _commentApiController.Remove(existingId);

            Assert.IsType<OkResult>(okResponse);
        }
        [Fact]
        public void RemoveComment_ExistingIdPassed_RemovesOneItem()
        {
            var existingId = 1;

            var okResponse = _commentApiController.Remove(existingId);

            Assert.Equal(3, _commentService.GetAll().Count());
        }

        ///////////////////////////////////////////////
        ///
        [Fact]
        public void GetAdvice_WhenCalled_ReturnsOkResult()
        {
            var okResult = _adviceApiController.GetAll();

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetAdvice_WhenCalled_ReturnsAllItems()
        {
            var okResult = _adviceApiController.GetAll().Result as OkObjectResult;

            var items = Assert.IsType<List<AdviceVM>>(okResult.Value);
            Assert.Equal(4, items.Count);
        }

        [Fact]
        public void GetAdviceById_UnknownIdPassed_ReturnsNotFoundResult()
        {
            var notFoundResult = _adviceApiController.GetById(5);

            Assert.IsType<NotFoundResult>(notFoundResult.Result);
        }

        [Fact]
        public void GetAdviceById_ExistingIdPassed_ReturnsOkResult()
        {
            var testId = 1;

            var okResult = _adviceApiController.GetById(testId);

            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void GetAdviceById_ExistingIdPassed_ReturnsRightItem()
        {
            var testId = 1;

            var okResult = _adviceApiController.GetById(testId).Result as OkObjectResult;

            Assert.IsType<AdviceVM>(okResult.Value);
            Assert.Equal(testId, (okResult.Value as AdviceVM).AdviceId);
        }

        [Fact]
        public void AddAdvice_InvalidObjectPassed_ReturnsBadRequest()
        {
            var advice = new AdviceVM()
            {
                AdviceId = 1
            };

            _adviceApiController.ModelState.AddModelError("Name", "Required");

            var badResponse = _adviceApiController.Post(advice);

            Assert.IsType<BadRequestObjectResult>(badResponse);
        }


        [Fact]
        public void AddAdvice_ValidObjectPassed_ReturnsCreatedResponse()
        {
            AdviceVM testItem = new AdviceVM()
            {
                AdviceId = 1,
                Status = "Status"
            };

            var createdResponse = _adviceApiController.Post(testItem);

            Assert.IsType<CreatedAtActionResult>(createdResponse);
        }


        [Fact]
        public void AddAdvice_ValidObjectPassed_ReturnedResponseHasCreatedItem()
        {
            AdviceVM testItem = new AdviceVM()
            {
                AdviceId = 1,
                Status = "Status"
            };

            var createdResponse = _adviceApiController.Post(testItem) as CreatedAtActionResult;
            var item = createdResponse.Value as AdviceVM;

            Assert.IsType<AdviceVM>(item);
            Assert.Equal("Status", item.Status);
        }

        [Fact]
        public void RemoveAdvice_NotExistingIdPassed_ReturnsNotFoundResponse()
        {
            var notExistingId = 7;

            var badResponse = _adviceApiController.Remove(notExistingId);

            Assert.IsType<NotFoundResult>(badResponse);
        }

        [Fact]
        public void RemoveAdvice_ExistingIdPassed_ReturnsOkResult()
        {
            var existingId = 1;

            var okResponse = _adviceApiController.Remove(existingId);

            Assert.IsType<OkResult>(okResponse);
        }
        [Fact]
        public void RemoveAdvice_ExistingIdPassed_RemovesOneItem()
        {
            var existingId = 1;

            var okResponse = _adviceApiController.Remove(existingId);

            Assert.Equal(3, _adviceService.GetAll().Count());
        }
    }
}
