using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 5, 7, 8 };
            Node<int> lst = CreateList();

            //Print(lst);
            //Console.WriteLine("----------------");
            //Node<int> R_lst = Reverse();
            //Print(R_lst);
            //Print(Turnarr(arr));
            //Console.WriteLine(Avg(lst));
            //Console.WriteLine(Get_Max(lst));
            //Console.WriteLine(Get_Min(lst));
            //Console.WriteLine(TrueIfNumInNode(lst, 8));
            Print(OnlyEvenNode(lst));
        }
        public static Node<int> CreateList()
        {
            Node<int> first = new Node<int>(8);
            Node<int> last = first;
            for (int i = 0; i < 3; i++)
            {
                last.SetNext(new Node<int>(i));
                last = last.GetNext();
            }
            return first;
        }
        public static void Print(Node<int> lst)
        {
            while (lst != null)
            {
                Console.WriteLine(lst);
                lst = lst.GetNext();
            }
        }
        public static Node<int> Reverse()
        {
            Node<int> lst = null;
            for (int i = 0; i < 4; i++)
            {
                lst = new Node<int>(i, lst);
            }
            return lst;
        }
        public static Node<int> Turnarr(int[] arr)
        {
            Node<int> first = new Node<int>(arr[0]);
            Node<int> last = first;
            for (int i = 1; i < arr.Length; i++)
            {
                last.SetNext(new Node<int>(arr[i]));
                last = last.GetNext();
            }
            return first;
        }
        public static double Avg(Node<int> lst)
        {
            int count = 0;
            double sum = 0;
            while (lst != null)
            {
                sum += lst.GetValue();
                lst = lst.GetNext();
                count++;
            }
            return sum / count;
        }
        public static int Get_Max(Node<int> lst)
        {
            int max = lst.GetValue();
            while (lst != null)
            {
                if (lst.GetValue() > max)
                    max = lst.GetValue();
                lst = lst.GetNext();

            }
            return max;
        }
        public static int Get_Min(Node<int> lst)
        {
            int min = lst.GetValue();
            while (lst != null)
            {
                if (lst.GetValue() < min)
                    min = lst.GetValue();
                lst = lst.GetNext();
            }
            return min;
        }

        public static bool TrueIfNumInNode(Node<int> lst, int num)
        {
            while (lst != null)
            {
                if (lst.GetValue() == num)
                    return true;
                lst = lst.GetNext();
            }
            return false;
        }
        public static Node<int> ReturnFirstHoliaThatEqualsNum(Node<int> lst, int num)
        {
            while (lst != null)
            {
                if (lst.GetValue() == num)
                    return lst;
                lst = lst.GetNext();
            }
            return null;
        }  
        public static Node<int> OnlyEvenNode(Node<int> lst)
        {
            Node<int> last = null;
            Node<int> first = null;
            while (lst != null)
            {
                if (lst.GetValue() % 2 == 0)
                {
                    if(first == null)
                    {
                        first = new Node<int>(lst.GetValue());
                        last = first;
                    }
                    else
                    {
                        last.SetNext(new Node<int>(lst.GetValue()));
                        last = last.GetNext();
                    }   
                }
                lst = lst.GetNext();
            }
            return first;
        }
        public static int Numofrezef(Node<int> lst , int num)
        {
            int count = 0; 
            while(lst.HasNext())
            {
                if (lst.GetValue() == num && lst.GetNext().GetValue()!=num)
                        count++;
                lst = lst.GetNext();
            }
            return count;
        }
    }
}

