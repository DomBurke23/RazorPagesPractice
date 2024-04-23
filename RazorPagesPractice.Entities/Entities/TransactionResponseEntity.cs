namespace RazorPagesPractice.Entities.Entities
{
    public class TransactionResponseEntity
    {
        public int TransactionId { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
        public double Balance { get; set; }
    }
}