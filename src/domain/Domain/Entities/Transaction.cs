namespace Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }

        public int TypeId { get; set; }
        public TransactionType TransactionType { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Description { get; set; } = string.Empty;

        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}