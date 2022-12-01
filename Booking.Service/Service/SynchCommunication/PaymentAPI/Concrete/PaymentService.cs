using Booking.Service.Service.SynchCommunication.PaymentAPI.Abstract;
using Booking.Service.Service.SynchCommunication.PaymentAPI.Contracts;
using Newtonsoft.Json;
using System.Text;

namespace Booking.Service.Service.SynchCommunication.PaymentAPI.Concrete
{
    public class PaymentService : IPaymentService
    {
        private readonly HttpClient _httpClient;

        public PaymentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AddPaymentResult> ProcessPayment(string orderId)
        {
            var obj = new AddPaymentExternal() { OrderIntegrationId = orderId, Total = 1 };
            var body = JsonConvert.SerializeObject(obj);
            var content = new StringContent(body, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7003/api/BookingPayment/AddPayment", content);
            var dataAsString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<AddPaymentResult>(dataAsString);
            return result;
        }
    }
}
