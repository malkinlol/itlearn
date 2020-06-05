using itlearn.dal.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.dal.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<CourseLearn> CourseLearn { get; set; }
        public DbSet<CategoryCourse> CategoryCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTheme> CourseThemes { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Requirement> Requirements { get; set; }
        public DbSet<SubcategoryCourse> SubcategoryCourses { get; set; }
        public DbSet<SubscribeCourse> SubscribeCourses { get; set; }
        public DbSet<SubscribeUser> SubscribeUsers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Achievement> Achievements { get; set; }
        public DbSet<Advice> Advices { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Management> Managements { get; set; }
        public DbSet<CourseComment> CourseComments { get; set; }
        public DbSet<ResultCourse> ResultCourses { get; set; }
        public DbSet<UserLearn> UserLearns { get; set; }
        public DbSet<CourseThemeQA> CourseThemeQAs { get; set; }
    }
}
