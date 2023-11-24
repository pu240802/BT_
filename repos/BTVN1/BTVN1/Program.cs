using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN1
{
    internal class Program
    {
        class Fraction
        {
            private double denominator;
            private double numerator;

            public double Denominator { get => denominator; set => denominator = value; }
            public double Numerator { get => numerator; set => numerator = value; }

            public Fraction()
            {

            }

            public Fraction(double numerator, double denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
        }
        class SolveProblem
        {
            protected Fraction FractionNumber;

            internal Fraction FractionNumber1 { get => FractionNumber; set => FractionNumber = value; }

            public Fraction theSumOfTwoFraction(Fraction first, Fraction second)
            {
                Fraction result = new Fraction();
                if (first.Denominator == second.Denominator)
                {
                    result.Numerator = first.Numerator + second.Numerator;
                    result.Denominator = first.Denominator;
                }
                else
                {
                    result.Numerator = first.Numerator * second.Denominator + first.Denominator * second.Numerator;
                    result.Denominator = first.Denominator * second.Denominator;
                }
                return result;

            }
            public Fraction theMinusOfTwoFraction(Fraction first, Fraction second)
            {
                Fraction result = new Fraction();
                if (first.Denominator == second.Denominator)
                {
                    result.Numerator = first.Numerator - second.Numerator;
                    result.Denominator = first.Denominator;
                }
                else
                {
                    result.Numerator = first.Numerator * second.Denominator - first.Denominator * second.Numerator;
                    result.Denominator = first.Denominator * second.Denominator;
                }
                return result;
            }
            public Fraction theMulOfTwoFraction(Fraction first, Fraction second)
            {
                Fraction result = new Fraction();
                result.Numerator = first.Numerator * second.Numerator;
                result.Denominator = first.Denominator * second.Denominator;
                return result;
            }
            public Fraction theDivOfTwoFraction(Fraction first, Fraction second)
            {
                Fraction result = new Fraction();
                result.Numerator = first.Numerator * second.Denominator;
                result.Denominator = first.Denominator * second.Numerator;
                return result;
            }
            public double UCLN(Fraction input)
            {
                while (input.Denominator != input.Numerator)
                {
                    if (input.Denominator > input.Numerator)
                    {
                        input.Denominator -= input.Numerator;
                    }
                    else
                    {
                        input.Numerator -= input.Denominator;
                    }
                }
                return input.Denominator;
            }

            public Boolean isSimple(Fraction input)
            {
                if (UCLN(input) == 1)
                {
                    return true;
                }
                return false;
            }

            public Fraction createSimpleFraction(Fraction input)
            {
                Fraction result = new Fraction();
                result.Denominator = result.Denominator / UCLN(input);
                result.Numerator = result.Numerator / UCLN(input);
                return result;
            }

        }
        static void Main(string[] args)
        {
            SolveProblem solve = new SolveProblem();
            Console.WriteLine("Enter fraction 1: ");
            double num1 = double.Parse(Console.ReadLine());
            double de1 = double.Parse(Console.ReadLine());
            Fraction f1 = new Fraction(num1, de1);
            Console.WriteLine("Enter fraction 2: ");
            double num2 = double.Parse(Console.ReadLine());
            double de2 = double.Parse(Console.ReadLine());
            Fraction f2 = new Fraction(num2, de2);
            int choice;
            do
            {
                Console.WriteLine("\n1.tinh tong");
                Console.WriteLine("\n2.tinh hieu");
                Console.WriteLine("\n3.tinh tich");
                Console.WriteLine("\n4.tinh thuong");
                Console.WriteLine("\n5.kiem tra phan so toi gian");
                Console.WriteLine("\n6.in ra dang toi gian");
                Console.WriteLine("\nInput solution 1->6: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Result: {0}/{1}",
                                solve.theSumOfTwoFraction(f1, f2).Numerator,
                                solve.theSumOfTwoFraction(f1, f2).Denominator);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Result: {0}/{1}",
                                solve.theMinusOfTwoFraction(f1, f2).Numerator,
                                solve.theMinusOfTwoFraction(f1, f2).Denominator);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Result: {0}/{1}",
                                solve.theMulOfTwoFraction(f1, f2).Numerator,
                                solve.theMulOfTwoFraction(f1, f2).Denominator);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Result: {0}/{1}",
                                solve.theMulOfTwoFraction(f1, f2).Numerator,
                                solve.theMulOfTwoFraction(f1, f2).Denominator);
                            break;
                        }
                    case 5:
                        {
                            if (solve.isSimple(f1))
                            {
                                Console.WriteLine("Fraction 1 is simple");
                            }
                            else
                            {
                                Console.WriteLine("Fraction 1 is not simple");
                            }

                            if (solve.isSimple(f2))
                            {
                                Console.WriteLine("Fraction 2 is simple");
                            }
                            else
                            {
                                Console.WriteLine("Fraction 2 is not simple");
                            }
                            break;
                        }
                    case 6:
                        {
                            if (!solve.isSimple(f1))
                            {
                                Console.WriteLine("Simple 1 fraction: {0}/{1}", solve.createSimpleFraction(f1).Numerator,
                                                                              solve.createSimpleFraction(f1).Denominator);
                            }
                            if (!solve.isSimple(f2))
                            {
                                Console.WriteLine("Simple 2 fraction: {0}/{1}", solve.createSimpleFraction(f2).Numerator,
                                                                              solve.createSimpleFraction(f2).Denominator);
                            }
                            break;
                        }
                }

            } while (choice != 0);

        }
    }
}
    

