using System;
using System.Drawing;

namespace QuestionDay05
{
    internal class LoopArray
    {
        public class Loop
        {
            public void RotateLeft(int[] arr,int size)
            {
                for (int i = 0; i < 2; i++)
                {
                    int temp = arr[0];

                    for (int j = 0; j < arr.Length - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    arr[arr.Length - 1] = temp;
                }

            }
            public void RotateRight(int[] arr,int size)
            {
                for (int i = 0; i < 1; i++)
                {
                    int lastElement = arr[arr.Length - 1];
                    for (int j = arr.Length-1 ; j >0; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[0] = lastElement;
                }

            }
            public void display(int[] arr)
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            public void Showfirst(int[] arr)
            {
                 Console.WriteLine(arr[0]);
            }
            public void PopFirst(int[] arr)
            {
                Console.WriteLine(arr[0]);
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[0] = default(int);

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");

            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the Elements of the array:");
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Loop loop = new Loop();
            Console.WriteLine("To Rotate right:");
            loop.RotateRight(array,size);
            loop.display(array);
            Console.WriteLine("To Rotate left:");
            loop.RotateLeft(array, size);
            loop.display(array);
            Console.WriteLine("To show first:");
            loop.Showfirst(array);
            Console.WriteLine("To pop first:");
            loop.PopFirst(array);


        }
    }
}