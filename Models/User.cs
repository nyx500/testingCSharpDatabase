﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace TestingSQLRelationships.Models
{

    public class User : IdentityUser
    {
        // Inherits IdentityUser properties


        // Required fields
        [Required(ErrorMessage ="Please enter a Slack ID!")]
        [StringLength(50)]
        [Key]
        public string SlackId { get; set; }

        [Required(ErrorMessage ="Please enter a Username!")]
        [StringLength(70)]
        public string UserName { get; set; }

        //public string UserId { get; set; }

        // Many-to-one relationships
        [Required(ErrorMessage = "Please enter your career phase!")]
        public int CareerPhaseId { get; set; } // foreign key
        public CareerPhase CareerPhase { get; set; } // navigation property


        [Required(ErrorMessage = "Please enter your experience level!")]
        public int ExperienceLevelId { get; set; } // foreign key
        public ExperienceLevel ExperienceLevel { get; set; } // navigation property

        // Many-to-many relationships

        // ICollection variables storing lists of natural and programming languages
        public ICollection<NaturalLanguageUser> NaturalLanguageUsers { get; set; }

        [Required(ErrorMessage = "Please enable selection of favourite programming languages!")]
        public ICollection<ProgrammingLanguageUser> ProgrammingLanguageUsers { get; set; }

        [Required(ErrorMessage = "Please enable selection of Computer Science interests!")]
        public ICollection<CSInterestUser> CSInterestUsers { get; set; }

        [Required(ErrorMessage = "Please select some hobbies and interests!")]
        public ICollection<HobbyUser> HobbyUsers { get; set; }

        public ICollection<Likes> UsersLiked { get; set; }
        public ICollection<Likes> LikedBy { get; set; }

        public ICollection<Rejections> UsersRejected { get; set; }
        public ICollection<Rejections> RejectedBy { get; set; }
        public ICollection<QuestionAnswerBlock> QuestionAnswerBlocks { get; set; }


        // Optional fields
        [StringLength(500)]
        public string Bio { get; set; }
        public int GenderId { get; set; } // foreign key
        public Gender Gender { get; set; } // navigation property


    }
}
