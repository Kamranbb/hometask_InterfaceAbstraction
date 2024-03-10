

namespace hometask_InterfaceAbstraction
{
    internal class Rectangular:Figure
    {
        public int witdh { get =>_width;
            set
            {
                if (value < 0)  return;
                _width = value; 
            }
        }
        int _lenght;
        int _width;


        public int lenght 
        { get => _lenght;
            set
            {
                if (value < 0) return;
                _lenght = value;
            }   
        }
        public Rectangular(int width ,int length)
        {
            witdh = width;
            lenght = length;    
        }
        public override void CalcArea()
        {
            Console.WriteLine(witdh+lenght);
        }
    }
}
