namespace TestingSQLRelationships.Models
{
    public class Question
    {
        public Question(int _Id, string _QText)
        {
            Id = _Id;
            QText = _QText;
        }

        public int Id { get; set; }
        public string QText { get; set; }

    }
}
