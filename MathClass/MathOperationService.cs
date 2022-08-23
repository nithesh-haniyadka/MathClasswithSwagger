//namespace MathClass
//{
//    public class MathOperationService
//    {
//    }
//}

using MathClass.Model;
using System;

namespace WebApplicationAPI.Service
{
    public class MathOperationService : IMathOperations
    {
        public int AddFun(InputValues values)
        {
            try
            {
                return values.valueA + values.ValueB;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public int SubFun(InputValues values)
        {
            try
            {
                return values.valueA - values.ValueB;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        public int MulFun(InputValues values)
        {
            try
            {

                return values.valueA * values.ValueB;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int DivFun(InputValues values)
        {
            try

            {
                return values.valueA / values.ValueB;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}