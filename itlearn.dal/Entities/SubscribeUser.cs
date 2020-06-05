using System.ComponentModel.DataAnnotations;

namespace itlearn.dal.Entities
{
    public class SubscribeUser
    {
        [Key]
        public int SubscribeUserId { get; set; }
        [Required]
        public string SubUserId { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
