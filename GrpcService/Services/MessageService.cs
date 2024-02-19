using Grpc.Core;

namespace GrpcService.Services
{
    public class MessageService : Messages.MessagesBase
    {
        public override Task<MessageResponse> ProcessMessage(MessageRequest request, ServerCallContext context)
        {
            var result = "ok";
            Console.WriteLine($"Сообщение:{request.Text}");
            return Task.FromResult(new MessageResponse { Result = result });
        }
    }
}