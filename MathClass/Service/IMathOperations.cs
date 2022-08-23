//namespace MathClass
//{
//    public class IMathOperations
//    {
//    }
//}

using MathClass.Model;

namespace MathClass.Service

{
    public interface IMathOperations
    {
        int Addition(InputValues values);
        int Substraction(InputValues values);
        int Multiplication(InputValues values);
        int Division(InputValues values);

    }
}