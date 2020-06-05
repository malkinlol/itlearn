using itlearn.dal.Context;
using itlearn.dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationContext _context;

        private ILanguageRepository _languageRepository { get; set; }
        private IChapterRepository _chapterRepository { get; set; }
        private IThemeRepository _themeRepository { get; set; }
        private ITestRepository _testRepository { get; set; }
        private IQuestionRepository _questionRepository { get; set; }
        private IAnswerRepository _answerRepository { get; set; }
        private INotificationRepository _notificationRepository { get; set; }
        private IPostRepository _postRepository { get; set; }
        private ICommentRepository _commentRepository { get; set; }
        private IAchievementRepository _achievementRepository { get; set; }
        private IAdviceRepository _adviceRepository { get; set; }
        private IStoryRepository _storyRepository { get; set; }

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
        }

        public ILanguageRepository Languages
        {
            get
            {
                if (_languageRepository == null)
                {
                    _languageRepository = new LanguageRepository(_context);
                }

                return _languageRepository;
            }
        }

        public IChapterRepository Chapters
        {
            get
            {
                if (_chapterRepository == null)
                {
                    _chapterRepository = new ChapterRepository(_context);
                }

                return _chapterRepository;
            }
        }

        public IThemeRepository Themes
        {
            get
            {
                if (_themeRepository == null)
                {
                    _themeRepository = new ThemeRepository(_context);
                }

                return _themeRepository;
            }
        }

        public ITestRepository Tests
        {
            get
            {
                if (_testRepository == null)
                {
                    _testRepository = new TestRepository(_context);
                }

                return _testRepository;
            }
        }

        public IQuestionRepository Questions
        {
            get
            {
                if (_questionRepository == null)
                {
                    _questionRepository = new QuestionRepository(_context);
                }

                return _questionRepository;
            }
        }

        public IAnswerRepository Answers
        {
            get
            {
                if (_answerRepository == null)
                {
                    _answerRepository = new AnswerRepository(_context);
                }

                return _answerRepository;
            }
        }

        public INotificationRepository Notifications
        {
            get
            {
                if (_notificationRepository == null)
                {
                    _notificationRepository = new NotificationRepository(_context);
                }

                return _notificationRepository;
            }
        }

        public IPostRepository Posts
        {
            get
            {
                if (_postRepository == null)
                {
                    _postRepository = new PostRepository(_context);
                }

                return _postRepository;
            }
        }

        public ICommentRepository Comments
        {
            get
            {
                if (_commentRepository == null)
                {
                    _commentRepository = new CommentRepository(_context);
                }

                return _commentRepository;
            }
        }

        public IAchievementRepository Achievements
        {
            get
            {
                if (_achievementRepository == null)
                {
                    _achievementRepository = new AchievementRepository(_context);
                }

                return _achievementRepository;
            }
        }

        public IAdviceRepository Advices
        {
            get
            {
                if (_adviceRepository == null)
                {
                    _adviceRepository = new AdviceRepository(_context);
                }

                return _adviceRepository;
            }
        }

        public IStoryRepository Stories
        {
            get
            {
                if (_storyRepository == null)
                {
                    _storyRepository = new StoryRepository(_context);
                }

                return _storyRepository;
            }
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
