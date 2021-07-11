using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassesAndObjects
{
    public struct FractionalNumbers
    {
        public int AnInteger { get; set; }

        public int Numerator { get; set; }
        public int Denominator { get; set; }
       
        public FractionalNumbers(int anInterger , int numerator, int denominator)
        {
            AnInteger = anInterger;
            Numerator = numerator;
            Denominator = denominator;
        }

        private static int NOD(int a, int b)
        {
            int nod = 0;
            if (b > a)
            {
                int blank = a;
                a = b;
                b = blank;

            }
            else
            {
                for (; ; )
                {
                    int remains = a % b;
                    if (remains == 0)
                    {
                        nod = b;
                        break;
                    }
                    else
                    {
                        a = a/b;
                        b = remains;
                    }
                }
            }
            return nod;
        }
        public static FractionalNumbers operator +(FractionalNumbers first, FractionalNumbers second)
        {
            FractionalNumbers result = new FractionalNumbers();
            result.AnInteger = first.AnInteger + second.AnInteger;
            result.Denominator = first.Denominator * second.Denominator;
            result.Numerator = first.Numerator * second.Denominator + second.Numerator * first.Denominator;
            if (result.Numerator > result.Denominator)
            {
                int tempAnInteger = result.Numerator / result.Denominator;
                result.AnInteger += tempAnInteger;
                result.Numerator %= result.Denominator;
            }
            int nod = NOD(result.Numerator, result.Denominator);
            result.Numerator /= nod;
            result.Denominator /= nod;

            return result;
        }        
        public static FractionalNumbers operator *(FractionalNumbers first, FractionalNumbers second)
        {
            FractionalNumbers result = new FractionalNumbers();
            first.Numerator += first.Denominator * first.AnInteger;
            second.Numerator += second.Denominator * second.AnInteger;
            result.Numerator = first.Numerator * second.Numerator;
            result.Denominator = first.Denominator * second.Denominator;
            int nod = NOD(result.Numerator, result.Denominator);
            result.Numerator /= nod;
            result.Denominator /= nod;
            return result;
        }
        public void Print()
        {
            Console.WriteLine(GetInfo());
        }
        public string GetInfo()
        {
            if (Numerator ==  Denominator)
            {
                return $"{AnInteger+1}";
            }
            return $"{AnInteger} {Numerator}/{Denominator}";
        }
    }
}
