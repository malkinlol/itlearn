using System;
using System.ComponentModel.DataAnnotations;

namespace itlearn.model.ViewModels.Account
{
    public class JobVM
    {
        public int JobId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Site { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public DateTime DateTo { get; set; }
        //[Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public string Info { get; set; }

        public string UserId { get; set; }
    }
}
