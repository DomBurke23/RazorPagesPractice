using RazorPagesPractice.Entities.Entities;

namespace RazorPagesPractice.Core.UseCases
{
    public class GetTransactionResponse
    {
        public List<TransactionResponseEntity> TransactionResponseEntities { get; set; }
    }
}
