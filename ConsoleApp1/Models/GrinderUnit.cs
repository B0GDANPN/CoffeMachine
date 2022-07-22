namespace ConsoleApp1.Models
{
    public class GrinderUnit
    {
        public GroundCoffe Grind( int quantity)
        {
            GroundCoffe result=new GroundCoffe();
            result.quantity = quantity;
            return result;
        }
    }
}