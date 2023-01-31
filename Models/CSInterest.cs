namespace TestingSQLRelationships.Models
{   
    // Computer Science interests, e.g. AI, Web Development
    public class CSInterest
    {
        public int Id { get; set; }
        public EnumsForUser.CSInterestName Name { get; set; }
    }
}
