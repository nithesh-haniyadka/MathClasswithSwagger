//namespace MathClass
//{
//    public class MathOperationService
//    {
//    }
//}

using MathClass.Model;
using System;

namespace MathClass.Service
{
    public class MathOperationService : IMathOperations
    {
        public int Addition(InputValues values)
        {
            try
            {
                return values.valueA + values.ValueB;
            }
            catch (Exception e)
            {
                throw;
            }
        }


        public int Substraction(InputValues values)
        {
            try
            {
                return values.valueA - values.ValueB;
            }
            catch (Exception e)
            {
                throw;
            }

        }

        public int Multiplication(InputValues values)
        {
            try
            {

                return values.valueA * values.ValueB;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public int Division(InputValues values)
        {
            try

            {
                return values.valueA / values.ValueB;
            }
            catch (Exception e)
            {
                throw;
            }
        }


    }
}