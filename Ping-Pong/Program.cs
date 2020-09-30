using System;

namespace Ping_Pong
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Ping ping_object = new Ping();
                ping_object.Ping_Event += Message;
                ping_object.Ping_Message();

                Pong pong_object = new Pong();
                pong_object.Pong_Event += Message;
                pong_object.Pong_Message();
            }

            static void Message(string a)
            {
                Console.WriteLine(a);
            }

        }

        class Ping
        {
            public delegate void Ping_Del(string a);
            public event Ping_Del Ping_Event;

            public void Ping_Message()
            {
                Ping_Event?.Invoke(Ping_Message2());
            }
            public string Ping_Message2()
            {
                return "Ping received Pong.";
            }
        }

        class Pong
        {
            public delegate void Pong_Del(string a);
            public event Pong_Del Pong_Event;
            public void Pong_Message()
            {
                Pong_Event?.Invoke(Pong_Message2());
            }
            public string Pong_Message2()
            {
                return "Pong received Ping.";

            }
        }
    }
}
