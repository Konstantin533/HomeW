using System.ComponentModel.DataAnnotations;

namespace WebApp3.Models
{
    public class InvenViewModel 
    {
        
        public  int One { get; set; }
        public int Onestock { get; } = 10;
        public int Two { get; set; }
        public int Twostock { get; } = 10;
        public  int Three { get; set; }
        public int Threestock { get; } = 10;
        public  int Four { get; set; }
        public int Fourstock { get; } = 10;
        public int Five{ get; set; }
        public int Fivestock { get; } = 10;
        public InvenViewModel() { }

      public InvenViewModel(int one , int two,int  three, int four, int five)
     {
            One= one;
            Two= two;
            Three= three;
            Four= four;
            Five= five;
     }
    }
}