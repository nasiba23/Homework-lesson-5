using System;

namespace HomeworkLesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] letters = { "a", "b", "c" };
            ArrayHelper.Pop(ref letters);
        }
    }
    public static class ArrayHelper
    {
        //string
        public static string Pop(ref string[] arr)
        {
            string LastElement = arr[^1];
            string[] newArray = new string[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return LastElement;
        }
        public static int Push(ref string[] arr, string el)
        {
            string[] newArray = new string[arr.Length + 1];
            newArray[arr.Length] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }
        public static string Shift(ref string[] arr)
        {
            string FirstElement = arr[0];
            string[] newArray = new string[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
            return FirstElement;
        }
        public static int UnShift(ref string[] arr, string el)
        {
            string[] newArray = new string[arr.Length + 1];
            newArray[0] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }

        //int
        public static int Pop(ref int[] arr)
        {
            int LastElement = arr[^1];
            int[] newArray = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return LastElement;
        }
        public static int Push(ref int[] arr, int el)
        {
            int[] newArray = new int[arr.Length + 1];
            newArray[arr.Length] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }
        public static int Shift(ref int[] arr)
        {
            int FirstElement = arr[0];
            int[] newArray = new int[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
            return FirstElement;
        }
        public static int UnShift(ref int[] arr, int el)
        {
            int[] newArray = new int[arr.Length + 1];
            newArray[0] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }

        //double
        static double Pop(ref double[] arr)
        {
            double LastElement = arr[^1];
            double[] newArray = new double[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return LastElement;
        }
        static int Push(ref double[] arr, double el)
        {
            double[] newArray = new double[arr.Length + 1];
            newArray[arr.Length] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }
        static double Shift(ref double[] arr)
        {
            double FirstElement = arr[0];
            double[] newArray = new double[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
            return FirstElement;
        }
        static int UnShift(ref double[] arr, double el)
        {
            double[] newArray = new double[arr.Length + 1];
            newArray[0] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }

        //decimal
        public static decimal Pop(ref decimal[] arr)
        {
            decimal LastElement = arr[^1];
            decimal[] newArray = new decimal[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return LastElement;
        }
        public static int Push(ref decimal[] arr, decimal el)
        {
            decimal[] newArray = new decimal[arr.Length + 1];
            newArray[arr.Length] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }
        public static decimal Shift(ref decimal[] arr)
        {
            decimal FirstElement = arr[0];
            decimal[] newArray = new decimal[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
            return FirstElement;
        }
        public static int UnShift(ref decimal[] arr, decimal el)
        {
            decimal[] newArray = new decimal[arr.Length + 1];
            newArray[0] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }

        //float
        public static float Pop(ref float[] arr)
        {
            float LastElement = arr[^1];
            float[] newArray = new float[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return LastElement;
        }
        public static int Push(ref float[] arr, float el)
        {
            float[] newArray = new float[arr.Length + 1];
            newArray[arr.Length] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }
        public static float Shift(ref float[] arr)
        {
            float FirstElement = arr[0];
            float[] newArray = new float[arr.Length - 1];
            for (int i = 1; i < arr.Length; i++)
            {
                newArray[i - 1] = arr[i];
            }
            arr = newArray;
            return FirstElement;
        }
        public static int UnShift(ref float[] arr, float el)
        {
            float[] newArray = new float[arr.Length + 1];
            newArray[0] = el;
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i + 1] = arr[i];
            }
            arr = newArray;
            return arr.Length;
        }
    }
}
