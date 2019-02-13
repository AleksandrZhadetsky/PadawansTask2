using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
			if(count <= 0)
            {
                throw new ArgumentException();
            }

            int sum = 0;
            int counter = count;
            while (counter > 0)
            {
                sum = checked(sum + (number + (add * --counter)));
            }
            return sum;
        }
    }
}
