using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Pipes;

namespace PipeServer
{
    class Server
    {
        private StreamReader pipeReader;
        private bool running = true;
        private string input = string.Empty;
        private Dictionary<string, Currency> currencies = new Dictionary<string, Currency>();

        public void Run(string pipeName)
        {
            Console.Write("Venter på klient...");
            using (NamedPipeServerStream server = new NamedPipeServerStream(pipeName))
            {
                //wait for client to connect:
                server.WaitForConnection();
                Console.WriteLine(" - Klient tilslutte!");

                using (pipeReader = new StreamReader(server))
                {
                    while (running)
                    {
                        Console.Write("Venter på input...");
                        input = GetLineFromClient(pipeReader);
                        running = ManageInput(input);
                    }
                } 
            }
        }

        private string GetLineFromClient(StreamReader reader)
        {
            string result = string.Empty;
            while(reader.Peek() >= 0)
            {
                result += reader.ReadLine();
            }
            reader.DiscardBufferedData();
            return result.ToUpper();
        }
        private void ShowCurrencies()
        {
            Console.WriteLine("\nValutakurser: ");
            foreach (Currency c in currencies.Values)
            {
                Console.WriteLine($"{c.CountryCode}, {c.ExchangeRate}");
            }
        }


        private bool ManageInput(string input)
        {


            if (input.ToUpper() == "EXIT")
            {
                return false;
            }

            string[] muslim = input.Split(' ');
            Currency inputCurrency = new Currency(muslim[0], int.Parse(muslim[1]));
            currencies.Add(input, inputCurrency);
            ShowCurrencies();
            return true;
        }
    }
}
