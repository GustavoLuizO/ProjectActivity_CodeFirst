using System.ComponentModel.DataAnnotations;
namespace ProjectActvity_CodeFirst.Models
{
    public class Guests
    {
        [Display(Name = "Guest Code")]
        public long guestId { get; set; }
        [Display(Name = "Name of Guest")]
        public string Name { get; set; }
        [Display(Name = "e-mail of Guest")]
        public string EMail { get; set; }
        [Display(Name = "Guest Phone")]
        public string Phone { get; set; }
        [Display(Name = "Will attend")]
        public bool attendance { get; set; }
    }
}
