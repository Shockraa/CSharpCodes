using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFile
{

   
    class Program //num linhas
        //num linhasiguais
        //num linhasdiferentes
    {
        static void Main(string[] args)
        {
            int counter1 = 0;
            int counter2 = 0;
            int equalLines = 0;
            int diffLines = 0;
            string arquivo1 = "exemplo1.txt";
            string arquivo2 = "exemplo2.txt";
            StreamReader reader1 = new StreamReader(arquivo1);
            StreamReader reader2 = new StreamReader(arquivo2);

            string line1 = reader1.ReadLine();
            string line2 = reader2.ReadLine();

            while (line1 != null || line2 != null)
            {
                if (line1 == line2)
                {
                    equalLines++;
               
                }
                else
                {
                    diffLines++;
                }
                counter1++;
                counter2++;
                if(counter1 != counter2)
                {
                    throw new Exception("The files do not have the same line numbers.");
                }

                line1 = reader1.ReadLine();
                line2 = reader2.ReadLine();
            }
            Console.WriteLine("Number of equal lines = " + equalLines);
            Console.WriteLine("Number of different lines = " + diffLines);

            Console.ReadKey();
        }
    }

}
