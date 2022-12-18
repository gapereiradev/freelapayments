using Freela.Payments.API.Models;
using System.Threading.Tasks;

namespace Freela.Payments.API.Services
{
    public interface IPaymentService
    {
        Task<bool> Process(PaymentInfoInputModel paymentInfoInputModel);
    }
}
