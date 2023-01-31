namespace TestingSQLRelationships.Models
{
    public class Answer
    {
        public Answer(int _Id, string _AText)
        {
            Id = _Id;
            AText = _AText;
        }

        public int Id { get; set; }
        public string AText { get; set; }
    }
}
