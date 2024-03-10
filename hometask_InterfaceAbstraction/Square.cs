

namespace  hometask_InterfaceAbstraction
{
    internal class Square:Figure
    {
        int _side;
        public int Side  
        {
            
            get => _side;
            set
            {
                if (value < 0) return;
                
                    _side = value;
                
            }
          }
        
        public Square(int side )
        {
            Side=side;
        }
        public override void CalcArea()
        {
            Console.WriteLine(Side + Side);

        }
        

    }
}
