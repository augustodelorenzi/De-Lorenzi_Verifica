using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using MQTTnet;
using MQTTnet.Server;
using MQTTnet.Client;

class Program()
{

    public class inserimentoDati
    {
        public int Id { get; set; }
        public int numeroPersone { get; set; }
        public DateTime DataIns { get; set; }

    }

    static async Task Main(string[] args)
    {
        string broker = "broker.hivemq.com";
        int port = 1883;
        string topic = "bortolanim";

        var factory = new MqttFactory();
        var mqttClient = factory.CreateMqttClient();
        var options = new MqttServerOptionsBuilder();
        var risultato = await mqttClient.ConnectAsync(); 

        await mqttClient.SubscribeAsync(topic);

        string connectionString = "DataSource(localDB)\\MSSQLLocalDB;" +
            "AttachDbFilename=C:\\Users\\delorenzia\\Desktop\\01-Verifica_MQTT_DB\\DB_Verifica.mdf;" +
            "Integrated Security=True;" +
            "Connect Timeout=30;";

    }

}