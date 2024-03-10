using System.ComponentModel.Design;
using System.Threading.Channels;

namespace hometask_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new(3);
            //square.CalcArea();
            Rectangular rectangular = new Rectangular(12,22);
            //rectangular.CalcArea();


            Console.WriteLine("Square");
            Console.WriteLine("Rectangular");
            Console.WriteLine("Exit");

            
            while (true)
            {
                bool result = int.TryParse(Console.ReadLine(), out int command);
                if (command >0 && command < 3)
                {
                    switch (command)
                    {
                        case 1:
                            square.CalcArea();break;
                        case 2: rectangular.CalcArea(); break;

                    
                    }
                   
                }
                else if (command == 3)
                {
                    break;
                }
            }
      


        }

    }
}
