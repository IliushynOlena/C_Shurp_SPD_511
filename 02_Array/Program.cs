using System.Reflection.PortableExecutable;

namespace _02_Array
{
    internal class Program
    {
        static void PrintArray(string text , int[] arr)
        {
            Console.Write(text + " : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Array 

          
            //Array == int[]
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[3]);
            Console.WriteLine(array[4]);
            Console.WriteLine();
            //------------- 2 --------------
            int[] array2 = new int[5];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = i * 2;
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();

            //------------- 3 ------------------
            //int[] array3 = new int[5] { 1, 2, 3, 4, 5 };
            int[] array3 = [10, 20, 30, 40, 50];
            for(int i = 0;  i < array3.Length;i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
            //------------------- 4 ------------------
            //int[] array4 = new int[] { 77, 88, 99, 100 };
            int[] array4 = [77, 88, 99, 100];
            for(int i = 0;i < array4.Length;i++)
            {
                Console.Write(array4[i] + " ");
            }
            Console.WriteLine();

            // ------------------ 5 ----------------------
            //numbers --> 0
            // bool ---> false
            //reference --> null
            int[] array5 = new int[10];
            for(int i = 0; i < array5.Length  ; i++)
            {
                //array5[i] = 88;
                Console.Write(array5[i] + " ");
            }
            array5.SetValue(77, 5);
            array5.SetValue(33, 3);
            Console.WriteLine();
           // IEnumerator --> object Current, MoveNext, Reset
            foreach (int element in array5)//read only
            {
                //element = 5;
                Console.Write(element + " ");
            }

            int a = 5;
            //Nullable<int> b = null;
            int? b = null;
            int[] array6;//null
            array6 = new int[10];
            #endregion
            #region Two Demention Array
            /*
            int[,] matrix = new int[3, 5];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[0, 3] = 4;
            matrix[0, 4] = 5;

            matrix[1, 0] = 7;
            matrix[1, 1] = 8;
            matrix[1, 2] = 9;
            matrix[1, 3] = 10;
            matrix[1, 4] = 11;

            matrix[2, 0] = 12;
            matrix[2, 1] = 13;
            matrix[2, 2] = 14;
            matrix[2, 3] = 15;
            matrix[2, 4] = 16;

            Console.WriteLine($"Lenght matrix : {matrix.Length}"); 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] matrix2 = new int[3, 4];
            for (int i = 0; i < matrix2.GetLength(0); i++)//3
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)//4
                {
                    matrix2[i, j] = i * j + 1;
                }
                Console.WriteLine();
            }

            for (int i = 0; i <= matrix2.GetUpperBound(0); i++)//2
            {
                for (int j = 0; j <= matrix2.GetUpperBound(1); j++)//3
                {
                    Console.Write($"{matrix2[i, j],5} ");
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region Many Demention Array
            /*
            int[,,] array10 = new int[3, 3, 3];
            for (int i = 0; i < array10.GetLength(0); i++)//3
            {
                for (int j = 0; j < array10.GetLength(1); j++)//4
                {
                   for(int k = 0; k < array10.GetLength(2); k++)
                    {
                        array10[i, j, k] = i * i;
                        Console.Write(array10[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            */
            #endregion
            #region Methods Array
            /*
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            PrintArray("\nOriginal array ", arr);

            int[] cloneArr = (int[])arr.Clone();
            PrintArray("\nClone  array ", cloneArr);

            //Array.Reverse(arr);
            Array.Reverse(arr, 1,5);
            PrintArray("\nReverse array ", arr);

            arr = cloneArr;
            PrintArray("\nArray after operator =", arr);

            int[] copy = new int[20];
            arr.CopyTo(copy, 5);
            PrintArray("\nCopy array ", copy);

            Array.Clear(arr, 3,5);
            PrintArray("\nClear array ", arr);

            Array.Resize(ref arr,20);
            PrintArray("\nResize array ", arr);

            Array.Sort(arr);
            PrintArray("\nSort array ", arr);

            Console.WriteLine(Array.IndexOf(arr, 3));
            Console.WriteLine(Array.BinarySearch(arr,9));

            Console.WriteLine($"Max element in array : {arr.Max()}");
            Console.WriteLine($"Min element in array : {arr.Min()}");
            Console.WriteLine($"Average element in array : {arr.Average()}");
            Console.WriteLine($"Rank array : {arr.Rank}");
            int[,] m = new int[2, 2];
            Console.WriteLine($"Rank array : {m.Rank}");
            */
            #endregion

            #region Jagged Array
            int[] [] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[2] { 22,33 };
            jagged[2] = new int[3] { 55,66,77};

            Console.WriteLine();
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Array in Functions
            int[] myArray = [14, 78, 45, 20, 36, 54, 2, 8, 9, 6];

            Random random = new Random();   
            for (int i = 0; i < myArray.Length;i++)
            {
                //myArray[i] = int.Parse(Console.ReadLine()!);
            }
             double num = Math.Round(random.Next(100) + random.NextDouble(),2);
            Console.WriteLine(num);
            PrintArray("Array before modify : ", myArray);
            myArray =  ModifyArray(myArray, 40);
            PrintArray("Array AFTER modify : ", myArray);


            ShowArray(100, myArray);
            ShowArray(100, new int[] {11,22,33,44,55});
            ShowArray(777, 99, 88, 77, 66, 55, 44, 33, 22, 11,01);
            #endregion
        }
        static void ShowArray(int a,params int[]arr)
        {
            Console.WriteLine($"a = {a}");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static int[] ModifyArray(int[] arr, int modifier)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += modifier;
            }
            return arr;
        }
    }
}
