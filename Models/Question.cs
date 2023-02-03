using System.ComponentModel.DataAnnotations.Schema;

namespace TestingSQLRelationships.Models
{
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuestionId { get; set; }
        public string QuestionString { get; set; }

    }
}
