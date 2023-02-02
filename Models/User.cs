using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestingSQLRelationships.Models
{
    public class User : IdentityUser
    {
        // Inherits IdentityUser properties


        // Required fields
        [Required(ErrorMessage ="Please enter a Slack ID!")]
        public string SlackId { get; set; }

        //public string UserId { get; set; }


        [Required(ErrorMessage = "Please enter your career phase!")]
        public EnumsForUser.CareerPhase CareerPhase { get; set; }


        [Required(ErrorMessage = "Please enter your experience level!")]
        public EnumsForUser.ExperienceLevel ExperienceLevel { get; set; }

        // ICollection variables storing lists of natural and programming languages
        public ICollection<NaturalLanguageUser> NaturalLanguageUsers { get; set; }
        public ICollection<ProgrammingLanguageUser> ProgrammingLanguageUsers { get; set; }

        //[Required(ErrorMessage = "Please enable selection of Computer Science interests!")]
        //public List<CSInterest> CSInterests = new List<CSInterest>();

        //[Required(ErrorMessage = "Please enable selection of Hobbies!")]
        //public List<Hobby> Hobbies = new List<Hobby>();


        // Optional fields
        public string Bio { get; set; }
        public EnumsForUser.Gender Gender { get; set; }

    }
}
