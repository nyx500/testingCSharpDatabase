using System.ComponentModel.DataAnnotations.Schema;

namespace TestingSQLRelationships.Models
{
    public class NaturalLanguageUser
    {
        // Composite primary key

        [Column("SlackId")]
        public string SlackId { get; set; } // Foreign key for user
        public int NaturalLanguageId { get; set; } // Foreign key for natural language

        // Navigation properties
        public User User { get; set; }
        public NaturalLanguage NaturalLanguage { get; set; } 
    }
}
