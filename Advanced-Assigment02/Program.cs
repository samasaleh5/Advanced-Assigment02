using System.Collections;

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
            ArrayList arrayList = new ArrayList { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
            ArrayList result=RemoveDuplicates(arrayList);
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
