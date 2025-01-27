using System.Collections;
using System.Collections.Generic;

namespace Advanced_Assigment02
{
    internal class Program {
        #region PalindromeFunction
        static bool isPalindrome(List<int> list)
        {
            int left = 0; int right = list.Count - 1;
            while (left < right)
            {
                if (list[left] != list[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }

        #endregion
        #region ReverseElement
        static void ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }
            while (stack.Count > 0)
            {
                queue.Enqueue((T)stack.Pop());
            }
        }
        #endregion
        #region IsBalanced
        static bool IsBalanced<T>(string str)
        {
            Stack<char>stack =new Stack<char> ();
            foreach (char ch in str) 
            { 
                if(ch == '(' || ch == '{' || ch == '[')
                {
                    stack.Push (ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    if(stack.Count==0)
                        return false;

                    char top = stack.Pop();
                    if ((ch == ')' && top != '(') ||
                        (ch == '}' && top != '{') ||
                        (ch == ']' && top != '['))
                    {
                        return false;
                    }    
                }
            }
            return stack.Count == 0;
        }
        #endregion
        #region RemoveDup
        static ArrayList RemoveDuplicates(ArrayList list) 
        { 
            ArrayList UniqueList = new ArrayList();
            foreach (var item in list) 
            {
                if (!UniqueList.Contains(item))
                {
                    UniqueList.Add(item);
                }
            }
            return UniqueList;
        }
        #endregion
        #region RemoveOdd
        static ArrayList RemoveOddNUmber(ArrayList array)
        {
            ArrayList EvenList = new ArrayList();
            foreach (var item in array)
            {
                if (item is int && (int)item % 2 == 0)
                {
                    EvenList.Add(item);
                }
            }
            return EvenList;

        }
        #endregion
        #region CheckNumberIntoStack
        static void SearchTarget<T>(Stack<int> stack,int Target)
        {
            Stack<int> TempStack = new Stack<int>();
            int count = 0;
            bool found = false;
            while (stack.Count > 0) 
            { 
                int item=stack.Pop();
                TempStack.Push(item);
                count++;
                if (item == Target) 
                {
                    found = true;
                    Console.WriteLine($"Target was found successfully and the count = {count}");
                    break;
                }

            }
            while (TempStack.Count > 0)
            {
                stack.Push(TempStack.Pop());
            }
            if (!found)
            {
                Console.WriteLine("Target was not found");
            }




        }
        #endregion
        #region FindIntersection
        static List<int> FindIntersection(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> intersection = new List<int>();

            
            foreach (int num in arr1)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
            }

            foreach (int num in arr2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    intersection.Add(num);
                    freq[num]--; 
                }
            }

            return intersection;
        }
        #endregion


        #region ReverseFirstElement
        static Queue<int> ReverseFirstKElements(Queue<int> queue, int k)
        {
            if (queue == null || k <= 0 || k > queue.Count)
                return queue;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());

            for (int i = 0; i < queue.Count - k; i++)
                queue.Enqueue(queue.Dequeue());

            return queue;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Question1
            //Console.WriteLine("Enter size of array Then Enter Number of Queries");
            //int ArraySize = int.Parse(Console.ReadLine());
            //List<int> arrayList = new List<int>(ArraySize);
            //int Qsize = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Array Elements");
            //for (int i = 0; i < ArraySize; i++)
            //{
            //    arrayList.Add(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("Enter Queries");
            //List<int> resultcounter = new List<int>();
            //for (int i = 0; i < Qsize; i++)
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    int count = 0;
            //    for (int j = 0; j < ArraySize; j++)
            //    {
            //        if (arrayList[j] > X)
            //        {
            //            count++;
            //        }
            //    }
            //    resultcounter.Add(count);
            //}
            //Console.WriteLine("OutPut : ");
            //foreach (int i in resultcounter)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Question2
            //Console.WriteLine("Input: ");
            //int ArraySize = int.Parse(Console.ReadLine());
            //List<int> arrayList = new List<int>(ArraySize);
            //Console.WriteLine("Enter List Elements : ");
            //for (int i = 0; i < ArraySize; i++)
            //{
            //    arrayList.Add(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("Output:");
            //if (isPalindrome(arrayList))
            //{
            //    Console.WriteLine("YES");
            //}
            //else
            //    Console.WriteLine("Not Palindrome");

            #endregion
            #region Question3
            //Queue<int> queue = new Queue<int>();
            //Console.WriteLine("Enter Queue Size");
            //int QSize=int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Queue Elements");
            //for (int i = 0; i < QSize; i++)
            //{
            //    int element=int.Parse(Console.ReadLine());
            //    queue.Enqueue(element);
            //}
            //Console.WriteLine("Original Queue :");
            //foreach(var i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //ReverseQueue(queue);
            //Console.WriteLine("Reversed Queue :");
            //foreach (var i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Question4
            //Console.WriteLine("Input:");
            //string input= Console.ReadLine();
            //Console.WriteLine("Output:");
            //Console.WriteLine(IsBalanced<string>(input) ? "Balanced" : "Not Balanced");
            #endregion
            #region Question5
            //ArrayList arrayList = new ArrayList { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            //ArrayList result=RemoveDuplicates(arrayList);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question6
            //ArrayList input = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //ArrayList result = RemoveOddNUmber(input);
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion
            #region Question7
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //    queue.Enqueue("Sama");
            //queue.Enqueue(1.24);
            //foreach (var item in queue)
            //{ 
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question8
            //Stack<int> stack = new Stack<int>();
            //Console.WriteLine("Enter Stack Elements");
            //for (int i = 0; i < 5; i++) 
            //{
            //    stack.Push(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("Enter Target Number You want");
            //int Target=int.Parse(Console.ReadLine());
            //SearchTarget<int>(stack, Target);
            #endregion
            #region Question9

            #endregion
            #region Question10

            #endregion
            #region Question11
            Queue<int> queue = new Queue<int>(new[]{1, 2, 3, 4, 5, 6, 7, 8});
            int key = 3;

            Queue<int> result = ReverseFirstKElements(queue, key);
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }


            #endregion
        }
    }
}
