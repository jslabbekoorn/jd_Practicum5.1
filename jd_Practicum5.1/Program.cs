using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jd_Practicum5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double dblInput = 0;
            double dblSom = 0;
            double dblDeling = 0;
            string strJN;
            string strAnswer;
            bool calculate;


            Console.WriteLine("Gemiddelde berekening, geef een negatief getal in om te stoppen");
            do
            {
                int intCount = 1;

                do
                {
                    Console.Write(intCount + " > ");
                    dblInput = double.Parse(Console.ReadLine());


                    if (dblInput < 0 && intCount == 1)
                    {
                        calculate = false;
                        Console.WriteLine("Kan niet delen door 0!");
                        break;
                    }
                    else
                    {
                        if (dblInput > 0)
                        {

                            dblSom = dblSom + dblInput;
                            intCount++;
                        }
                    }

                    calculate = true;

                } while (dblInput > 0);


                if (calculate)
                {
                    intCount -= 1;
                    dblDeling = dblSom / intCount;
                    Console.WriteLine("Het gemiddelde is : " + dblDeling);
                    Console.Write("Opnieuw een gemiddelde berekenen? (j/n): ");
                    strJN = Console.ReadLine();
                    strAnswer = strJN.ToLower();

                }
                else
                {
                    Console.Write("Opnieuw een gemiddelde berekenen? (j/n): ");
                    strJN = Console.ReadLine();
                    strAnswer = strJN.ToLower();
                }



            }
            while (strAnswer == "j" || strAnswer == "ja");

            Console.WriteLine("Press any key to continue..");
            Console.ReadLine();
        }
    }
}
