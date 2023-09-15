// See https://aka.ms/new-console-template for more information
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

Console.WriteLine("Welcome to Order processing service!");

var factory = new ConnectionFactory()
{
    HostName = "localhost",
    UserName = "user",
    Password = "mypass",
    VirtualHost = "/"
};
var conn = factory.CreateConnection();
using var channel = conn.CreateModel();
channel.QueueDeclare("Orders", durable:true, exclusive:false);


var consumer = new EventingBasicConsumer(channel);

consumer.Received += (model, eventArgs) =>
{
    //getting my byte[]
    var body = eventArgs.Body.ToArray();

    var message = Encoding.UTF8.GetString(body);
    Console.WriteLine($"New Book Order : {message} ");
};

channel.BasicConsume("Orders", true, consumer);

Console.ReadKey();
