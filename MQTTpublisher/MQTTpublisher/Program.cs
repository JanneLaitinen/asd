using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MQTTpublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("start publishing");
            // Create Client instance
            MqttClient myClient = new MqttClient("192.168.28.130");

            string clientId = Guid.NewGuid().ToString();
            myClient.Connect(clientId);

            string strValue = Convert.ToString("hei hei");
            myClient.Publish("test", Encoding.UTF8.GetBytes(strValue));
        }

    }
}
