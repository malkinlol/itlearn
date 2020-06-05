using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace itlearn.model.ViewModels.Account
{
    public class EducationVM
    {
        public int EducationId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Site { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public DateTime DateTo { get; set; }
        [Required]
        public DateTime DateFrom { get; set; }
        [Required]
        public bool IsGraduate { get; set; }
        public string UserId { get; set; }
    }
}
