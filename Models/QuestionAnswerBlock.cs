﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace TestingSQLRelationships.Models
{
    public class QuestionAnswerBlock
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int QuestionAnswerBlockId;


        [Key]
        public string SlackId { get; set; } // foreign key
        public User User { get; set; } // navigation property

        public string QuestionString { get; set; }
        public string AnswerString { get; set; }

    }
}
