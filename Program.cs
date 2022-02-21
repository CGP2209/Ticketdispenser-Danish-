using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Fodbold_klubben_TEC___opgave
{
    class Program
    {
        static void Main(string[] args)
           
        {


            {
               // LAV NYT PROGRAM MED ALLE VARIABLER I TOPPEN !!!!!!!!!!!!   

                double antalbilletter = Convert.ToDouble(File.ReadAllText(@"C:\Users\Caspe\OneDrive\Skrivebord\TEC - Programmering afleveringer\Random data\billetter.txt", Encoding.Unicode));
                //SKRIV I BUNDEN
                string ALLEBilletter = Convert.ToString(antalbilletter);
                //"ALLEBILLETTER" Skal gemmes til fil

                File.WriteAllText(@"C:\Users\Caspe\OneDrive\Skrivebord\TEC - Programmering afleveringer\Random data\billetter.txt", ALLEBilletter, Encoding.Unicode);

                int børnebillet = 0;
                int voksenbillet = 0;
                

                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.SetCursorPosition(40, 0);
                Console.WriteLine("          TEC BOLDKLUB          ");
                Console.ResetColor();
                Console.SetCursorPosition(90, 1); Console.WriteLine(DateTime.Now.ToLongDateString());
                Console.WriteLine("Antal billetter tilbage :  {0}\n", antalbilletter);
                Console.WriteLine("Velkommen til TEC boldklubs billet automat");
                Console.SetCursorPosition(70, 3); Console.WriteLine("Næste kamp starter Søndag d. 14/11/2021 Kl 10:00");

                do
                {
                    

                    
                    Console.WriteLine("\n\n\n\nHvor mange børnebilleter ønsker du at købe?"); børnebillet = Convert.ToInt16(Console.ReadLine());

                    Console.Clear();
                    if (børnebillet > 10) Console.WriteLine("Hov! Maks 10 billeter pr person");
                } while (børnebillet > 10);

                do
                {
                    Console.WriteLine("Hvor mange Voksenbilletter ønsker du at købe?"); voksenbillet = Convert.ToInt16(Console.ReadLine());

                    Console.Clear();
                    if (voksenbillet > 10) Console.WriteLine("Hov! Maks 10 billeter pr person");
                } while (voksenbillet > 10);

                int voksenpris = 60 * voksenbillet;
                int børnepris = 30 * børnebillet;
                int samletbill = børnebillet + voksenbillet;
                int samletpris = voksenpris + børnepris;

                Console.WriteLine("Du har valgt {0} børnebilletter og {1} voksenbilleter", børnebillet, voksenbillet);
                Console.WriteLine("Du har tilsammen {0} billetter", samletbill);
                Console.WriteLine("Den samlede pris er {0} : ", samletpris);

                int medlemspris = samletpris - 10 * samletpris / 100;

                Console.WriteLine("Er du medlem af Klubbens foreningsgruppe?");
                Console.WriteLine("Ja [1]   [2] Nej");

                string svar = "";
                svar = Console.ReadLine().ToLower();
                if (svar == "ja")
                {
                    Console.Clear();
                    Console.WriteLine("Du har valgt {0} børnebilletter og {1} voksenbilleter", børnebillet, voksenbillet);
                    Console.WriteLine("Du har tilsammen {0} billetter", samletbill);
                    Console.WriteLine("Din samlede pris er : {0} ", medlemspris);

                }
                else if (svar != "Nej")
                {
                    Console.Clear();
                    Console.WriteLine("Du har valgt {0} børnebilletter og {1} voksenbilleter", børnebillet, voksenbillet);
                    Console.WriteLine("Du har tilsammen {0} billetter", samletbill);
                    Console.WriteLine("Din samlede pris er : {0} ", samletpris);

                }
                string tast = "";

                tast = Console.ReadLine().ToLower();


                Console.WriteLine("Ønsker du at købe flere billetter?");
                    Console.WriteLine("[Ja]     [Nej]");
                    Console.ReadLine();
                
                

            } while ( "" != "nej");







            

           Console.ReadKey();
        }
    }
}
