using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Numbers
{
    public class Numbers
    {
        public static int RectangleArea(int height, int widht)
        {
       

            return height * widht;

        }

        public static int Sum(int[] ints)
        {
            int sum = 0;
            for (int l = 0; l < ints.Length; l++)
            {

               sum = sum + ints[l];

            }
            return sum ;
            
        }

        public static int Min(int[] ints)
        {
            int min = 0;
            for (int j = 0; j < ints.Length; j++)
            {
                if (ints[j] < ints[min])
                {
                    min = j;
                }
            }
            
            return ints[min];
            
        }

        public static int Max(int[] ints)
        {
            int max = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] > ints[max])
                {
                    max = i;
                }

           
                
            }

            return ints[max];
        }

        public static bool Contains(int v, int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (v == ints[i])
                {
                    return true;
                }
             
            }
            return false;
        }

        public static double Average(int[] ints)
        {
            double average = ints.Sum();
            average = average / ints.Length;

            return average;
                
        }

        public static double LineLength(int xa, int ya, int xb, int yb)
        {
            double PolyLength = 0.0;
            PolyLength = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2));

            return PolyLength;

        }

        public static double PolylineLength(int[] xCoords, int[] yCoords)
        {
            double PolyLineLenght = 0.0;
            for (int i = 0; i < xCoords.Length -1; i++)
            {
                PolyLineLenght = PolyLineLenght + LineLength(xCoords[i], yCoords[i], xCoords[i + 1], yCoords[i + 1]);
            }
            return PolyLineLenght;
        }
    }
}


