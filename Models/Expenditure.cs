namespace QuestRazor.Models
{
    public class Expenditure
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public DateTime DateDepense { get; set;}
        public double Price { get; set;}

        public Expenditure( int id, string name, DateTime datedepense, double price)
        {
            Id = id;
            Nom = name;
            DateDepense = datedepense;
            Price = price;
        }

    }
}
