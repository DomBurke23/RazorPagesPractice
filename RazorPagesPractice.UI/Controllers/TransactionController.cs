using Microsoft.AspNetCore.Mvc;
using RazorPagesPractice.Core;
using RazorPagesPractice.Core.UseCases;
using RazorPagesPractice.UI.Models;

namespace RazorPagesPractice.UI.Controllers
{
    [Route("v1/[controller]"),  ApiController]
    public class TransactionController : Controller
    {
        private readonly IUseCase<GetTransactionRequest, GetTransactionResponse> _getTransactionUseCase;

        public TransactionController(IUseCase<GetTransactionRequest, GetTransactionResponse> getTransactionUseCase)
        {
            _getTransactionUseCase = getTransactionUseCase;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("GetTransaction")]
        public IActionResult GetTransaction(string tRef)
        {
            var response = _getTransactionUseCase.Handle(new GetTransactionRequest { TRef = tRef });

            return View("Index", new TransactionViewModel
            {
                AccountId = 1,
                TransactionResponseEntities = response.TransactionResponseEntities,
                Tref = tRef
            });
        }
    }
}