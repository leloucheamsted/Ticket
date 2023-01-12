using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ticket.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="ProfilePicture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }


        // RelationShips
        public List<Movie> Movies { get; set; }

    }
}
