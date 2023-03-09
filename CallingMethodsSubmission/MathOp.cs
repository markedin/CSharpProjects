using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    public class MathOp
    {
        
        //create a method within the MathOp class. It takes in an int, integerIn
        public static int add5(int integerIN)
        {
            //create an int to return after method is called, perform add5 on integerIn
            int integerOut = integerIN + 5;
            //return the number 
            return integerOut;
        }

        //create a method within the MathOp class. It takes in an int, integerIn
        public static int multiplyBy3(int integerIN)
        {
            //create an int to retrun after method is called, perform multiplyBy3 on integerIn
            int integerOut = integerIN * 3;
            //return the number
            return integerOut;
        }

        //create a method within the MathOp class. It takes in an int, integerIn
        public static int divideBy2(int integerIN)
        {
            //create an int to retrun after method is called, perform divideBy2 on integerIn
            int integerOut = integerIN / 2;
            //return the number
            return integerOut;
        }
        

        
    }
}
