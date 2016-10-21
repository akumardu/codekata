using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beginner.Codewar
{
    class DollarBillTickets
    {
        public static string Tickets(int[] peopleinLine)
        {
            int dollarBillof25 = 0;
            int dollarBillof50 = 0;
            //int dollarBillof100 = 0;
            for (int i = 0; i < peopleinLine.Length; i++)
            {
                switch (peopleinLine[i])
                {
                    case 25:
                        dollarBillof25++;
                        break;
                    case 50:
                        if (dollarBillof25 > 0)
                        {
                            dollarBillof25--;
                            dollarBillof50++;
                        }
                        else
                            return "NO";
                        break;
                    case 100:
                        if (dollarBillof25 > 0 && dollarBillof50 > 0)
                        {
                            dollarBillof50--;
                            dollarBillof25--;
                        }
                        else if (dollarBillof25 > 2)
                            dollarBillof25 = dollarBillof25 - 3;
                        else
                            return "NO";
                        break;
                    default:
                        return "NO";
                }
            }
            return "YES";
        }

        public static void TestDollarBillTickets()
        {
            int[] peopleinLine = { 25, 50, 100 };
            Console.WriteLine(DollarBillTickets.Tickets(peopleinLine));

            Console.WriteLine("Enter the size:");
            int size = int.Parse(Console.ReadLine());
            int[] peopleInLine2 = new int[size];
            for (int i = 0; i < size; i++) 
                peopleInLine2[i] = int.Parse(Console.ReadLine());
            Console.WriteLine(DollarBillTickets.Tickets(peopleInLine2));

        }
    }

 }

