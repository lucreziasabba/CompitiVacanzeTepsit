using System;

namespace DueNumeri
{
    public class Numeri
    {
        public static int Massimo(int n1, int n2)
        {
            if (n1 >= n2)
                return n1;
            else
                return n2;
        }
        public static int Minimo(int n1, int n2)
        {
            if (n1 >= n2)
                return n2;
            else
                return n1;
        }
        public static double Media(double n1, double n2)
        {
            double media = (n1 + n2) / 2;
            return media;
        }
    }
}
