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
        int AddFun(InputValues values);
        int SubFun(InputValues values);
        int MulFun(InputValues values);
        int DivFun(InputValues values);

    }
}