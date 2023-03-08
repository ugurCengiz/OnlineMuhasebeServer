using OnlineMuhasebeServer.Application.Services;
using OnlineMuhasebeServer.Domain.Dtos;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;

namespace OnlineMuhasebeServer.Infrasturcture.Services
{
    public sealed class RabbitMQService:IRabbitMQService
    {
        public void SendQueue(ReportDto reportDto)
        {
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqps://aewmosbk:GNGYwoF1XCultQcDUdWPsnmZ1tSyGtwF@sparrow.rmq.cloudamqp.com/aewmosbk");

            using var connection = factory.CreateConnection();

            var channel = connection.CreateModel();
            channel.QueueDeclare("Reports", true, false, false);

            var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(reportDto));

            channel.BasicPublish(String.Empty, "Reports",null,body);




        }
    }
}
