using System;
using System.Collections.Generic;
using System.Linq;

namespace DaysOfHackerrank
{




    class PowerException : Exception
    {
        public override string Message
        {
            get { return "n and p should be non-negative"; }

        }


        //Write your code here
        public Stack<char> stack = new Stack<char>();
        //yjhjg
        public Queue<char> queue = new Queue<char>();

        public void pushCharacter(char ch)
        {
            stack.Push(ch);
        }
        public void enqueueCharacter(char ch)
        {
            queue.Enqueue(ch);
        }
        public char popCharacter()
        {
            return stack.Pop();
        }
        public char dequeueCharacter()
        {
            return queue.Dequeue();
        }
        static int[] cutTheSticks(int[] arr)
        {
            Array.Sort(arr);
            
            List<int> sticksCut = new List<int>();

            // När Count blir noll ska loopen sluta.
            int lowest = -1;
            while (lowest +1 < arr.Length)
            {

                lowest++;
                sticksCut.Add((arr.Length - lowest) -1);


                for (int i = lowest; i < arr.Length; i++)
                {
                    if (arr[lowest] == arr[i])
                    {
                        lowest++;
                    }
                }

            }

            return sticksCut.ToArray();
        }


        public void printArray<T>(T[] array)
        {
            foreach (var s in array){
                Console.WriteLine(s);
            }
        }
    }
}