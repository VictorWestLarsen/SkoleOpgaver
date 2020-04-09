using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Numbers
{

    class Program
    {


        static void Main(string[] args)
        {
            string cordinate = "";
            int[] holder1 = new int[10];
            int[] holder2 = new int[10];
            string[] talliste = new string[10];
            bool exit = false;
            bool quit = false;
            int counter = 0;
            int height;
            int widht;
            //Console.WriteLine("Højden er ");
            //height = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bredden er ");
            //widht = int.Parse(Console.ReadLine());

            //Console.WriteLine("Højden er " + height);
            //Console.WriteLine("Bredden er " + widht);

            //Console.WriteLine(Numbers.RectangleArea(height, widht));



            //Console.WriteLine("Indtast en talserie(Max. 10 tal, afslut med en tom linje)");
            //while (exit != true)
            //{
            //    talliste[counter] = Console.ReadLine();

            //    if (talliste[counter] == "")
            //    {
            //        exit = true;
            //    }
            //    else
            //    {
            //        counter++;
            //    }

            //}

            //int[] skrivud = new int[counter];
            //for (int i = 0; i < counter; i++)
            //{
            //    skrivud[i] = int.Parse(talliste[i]);
            //}
            //string tal = skrivud[0] + "";

            //for (int i = 1; i < skrivud.Length; i++)
            //{
            //    tal = tal + ", " + skrivud[i];

            //}
            //Console.WriteLine("Dine tal er: " + tal);

            //Console.WriteLine("Mindste tal er: " + Numbers.Min(skrivud));
            //Console.WriteLine("Største tal er : " + Numbers.Max(skrivud));
            //Console.WriteLine("Summen af tallisten er: " + Numbers.Sum(skrivud));
            //Console.ReadKey();

            Console.WriteLine("Indtast koordinater (Max. 10 x,y koordinater)");
            while (quit != true)
            {
                cordinate = Console.ReadLine();
                string[] lort = cordinate.Split(',');

                if(cordinate == "") 
                {
                    quit = true;
                }
                else
                {
                    holder1[counter] = int.Parse(lort[0]);
                    holder2[counter] = int.Parse(lort[1]);

                    counter++;

                }

            }
            string gotem = "";
            for (int i = 0; i < counter; i++)
            {
                gotem = gotem + "(" + holder1[i] + "," + holder2[i] + ")";
            }
            Array.Resize(ref holder1, counter);
            Array.Resize(ref holder2, counter);
            Console.WriteLine("Dine koordinater er; " + gotem);

            Console.WriteLine("Længden af din Polyline er: " + Numbers.PolylineLength(holder1, holder2));

            Console.ReadKey();





        }
        }
    }
