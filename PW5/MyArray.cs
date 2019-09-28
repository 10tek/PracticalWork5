using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW5
{
    class MyArray
    {
        private int[] numberArray;

        public MyArray()
        {
            numberArray = new int[5];
        }

        public int this[int index]
        {

            get
            {
                if (index >= numberArray.Length)
                    throw new IndexOutOfRangeException("Wrong index!");
                else
                    return numberArray[index];
            }
            set
            {
                if (index >= numberArray.Length)
                    throw new IndexOutOfRangeException("Wrong index!");
                else
                    numberArray[index] = value;
            }
        }

        public int GetSum()
        {
            return numberArray.Sum();
        }

        public static bool operator <(MyArray myFirstArray, MyArray mySecondArray)
        {
            return myFirstArray.GetSum() < mySecondArray.GetSum();
        }

        public static bool operator >(MyArray myFirstArray, MyArray mySecondArray)
        {
            return myFirstArray.GetSum() > mySecondArray.GetSum();
        }
    }


}
