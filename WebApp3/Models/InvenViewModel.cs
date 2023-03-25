using System.ComponentModel.DataAnnotations;

namespace WebApp3.Models
{
    public class InvenViewModel 
    {
        
        public  int One { get; set; } 
        
        public int Two { get; set; } 
        
        public  int Three { get; set; } 
       
        public  int Four { get; set; } 
       
        public int Five{ get; set; } 

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