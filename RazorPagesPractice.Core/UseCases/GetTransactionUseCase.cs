using Microsoft.Extensions.Logging;
using RazorPagesPractice.Entities.Entities;

namespace RazorPagesPractice.Core.UseCases
{
    public class GetTransactionUseCase(ILogger<GetTransactionUseCase> logger) : IUseCase<GetTransactionRequest, GetTransactionResponse>
    {
        private readonly ILogger<GetTransactionUseCase> _logger = logger;

        public GetTransactionResponse Handle(GetTransactionRequest request)
        {
            _logger.LogInformation("Use Case entered.");
            var list = new List<TransactionResponseEntity>();
            var transactionResponseEntity1 = new TransactionResponseEntity
            {
                TransactionId = 100,
                Description = "Description 1.",
                Amount = 2,
                Balance = 200
            };
            var transactionResponseEntity2 = new TransactionResponseEntity
            {
                TransactionId = 300,
                Description = "Description 2.",
                Amount = 4,
                Balance = 600
            };
            list.Add(transactionResponseEntity1);
            list.Add(transactionResponseEntity2);
            return new GetTransactionResponse { TransactionResponseEntities = list };
        }
    }
}
