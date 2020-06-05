namespace itlearn.model.ViewModels.Account
{
    public class UserVM
    {
        public string UserId { get; set; }
        public string Email { get; set; }

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
        public string Phone { get; set; }
        public int Time { get; set; }
        public int CountCourse { get; set; }

        public int SelectedJobId { get; set; }
        public int SelectedEducationId { get; set; }
    }
}
