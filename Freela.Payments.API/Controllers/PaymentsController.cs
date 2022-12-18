using Freela.Payments.API.Models;
using Freela.Payments.API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Freela.Payments.API.Controllers
{
    [Route("api/payments")]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PaymentInfoInputModel paymentInfoInputModel)
        {
            var result = await _paymentService.Process(paymentInfoInputModel);

            if (!result)
            {
                return BadRequest();
            }

            return NoContent();
        }
    }
}

