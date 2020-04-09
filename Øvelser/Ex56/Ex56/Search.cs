using Ex56;
using System;

namespace Ex56
{
    public class Search
    {
        public static int FindPositionInList_Linear(int[] data, int value)
        {
            int resultat = -1;

            for (int pos = 0; pos < data.Length; pos++)
            {
                if (data[pos] == value)
                {
                    resultat = pos;

                    break;
                }
            }
            return resultat;

        }
        public static int FindPositionInList_Binary(int[] data, int value)
        {
            int resultat = -1;

            Array.Sort(data);

            int lower = 0;
            int mid;
            int upper = data.Length -1;

            bool searching = true;

            while (searching)
            {
                if (upper < lower)
                {
                    break;
                }

                mid = lower + (upper - lower) / 2;

                if (data[mid] < value)
                {
                    lower = mid + 1;
                }

                else if (data[mid] > value)
                {
                    upper = mid - 1;
                }

                else
                {
                    resultat = mid;
                    break;
                }
                    
            }

            return resultat;
        }

        public static int FindPositionInList_Binary(int[] data, int value, int lowerBound, int upperBound)
        {
            if (upperBound >= lowerBound)
            {
                int mid = lowerBound + (upperBound - lowerBound) / 2;

                if (data[mid] == value)
                {
                    return mid;
                }

                else if (data[mid] > value)
                {
                    return FindPositionInList_Binary(data, lowerBound, mid - 1, value);
                }

                else
                {
                    return FindPositionInList_Binary(data, mid + 1, upperBound, value);
                }

            }
            else
            {
                return -1;
            }


        }
    }
}
