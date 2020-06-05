using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace itlearn.dal.Entities
{
    public class User : IdentityUser
    {
        public User()
        {
            Jobs = new HashSet<Job>();
            Educations = new HashSet<Education>();
            Courses = new HashSet<Course>();
            SubscribeUsers = new HashSet<SubscribeUser>();
            SubscribeCourses = new HashSet<SubscribeCourse>();
        }

        public string Avatar { get; set; }
        public string Site { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string LinkedIn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string AboutMe { get; set; }
        public int Experience { get; set; }
        public int Time { get; set; }
        public string Tags { get; set; }
        public bool IsNotificationRead { get; set; }
        public DateTime UserDateCreate { get; set; }

        public int SelectedJobId { get; set; }
        public int SelectedEducationId { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<SubscribeUser> SubscribeUsers { get; set; }
        public virtual ICollection<SubscribeCourse> SubscribeCourses { get; set; }
    }
}
