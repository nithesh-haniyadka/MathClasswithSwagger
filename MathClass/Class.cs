//namespace MathClass
//{
//    public class Class
//    {

//    }
//}


using System.ComponentModel.DataAnnotations;

namespace MathClass.Model
{
    public class InputValues
    {
        [Required]
        public int valueA { get; set; }

        [Required]
        public int ValueB { get; set; }


    }
}
