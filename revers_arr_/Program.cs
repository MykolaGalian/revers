using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace revers_arr_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Reverse");
            int[] a = {1,2,3,4,5,6,7,8,9};
            var b = a.Reverse();
            foreach (var item in b)
            {
               Console.Write(item+" "); 
            }
            Console.WriteLine();
            Console.WriteLine("ReverseArrToIEnum:"); 
 
            var c = ReverseArrToIEnum(a);
            foreach (var item in c)
            {
                Console.Write(item+" "); 
            }
            Console.WriteLine();
            Console.WriteLine("My ReverseArrToArr:");

            var d = ReverseArrToArr(a);
            foreach (var item in d)
            {
                Console.Write(item+" ");
            }

            Console.WriteLine();
            Console.WriteLine("My ReverseEnumToIEnum:");
            IEnumerable<int> e = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
            var k = ReverseEnumToIEnum(e);
            foreach (var item in k)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine("ReverseString:");
            Console.WriteLine(ReverseString("Saqwe rtu"));
            
            
            
            LinkedListNode L = new LinkedListNode();
            L.Add(new Node("first"));
            L.Add(new Node("second"));
            L.Add(new Node("third"));
            L.Add(new Node("forth"));
            Console.WriteLine("___Before:");
            L.PrintNodes();
            L.ReverseLinkedList();
            Console.WriteLine("___After:");
            L.PrintNodes();
            Console.ReadKey();
        } 
  //----------------------reverse ArrToIEnum-------------------
        public static IEnumerable<int> ReverseArrToIEnum(int[] ar)
        {
           for(int i = ar.Length-1;    i >= 0;   i--)
                yield return ar[i];
        }
  //----------------------reverse ReverseArrToArr----------
        public static int[] ReverseArrToArr(int[] a)
        {
            int temp;
            for (int i = 0,  j = a.Length-1; i < j; i++, j--) {
                temp = a[i]; 
                a[i] = a[j];
                a[j] = temp;
            }
            return a;
        }
        
  //----------------------reverse EnumToIEnum----------//in IEnumerable exist methods count, reverse
        public static IEnumerable<int> ReverseEnumToIEnum(IEnumerable<int> ar) 
        {
              for(int i = ar.Count()-1;    i >= 0;   i--)
                  yield return ar.ElementAt(i);
        }
  //----------------------reverse String----------
        public static string ReverseString(string text)
        {
            char[] cArray = text.ToCharArray();
            StringBuilder reverse = new StringBuilder(50);
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse.Append(cArray[i]);
            }
            return reverse.ToString();
        }
        
       
  
    }
}