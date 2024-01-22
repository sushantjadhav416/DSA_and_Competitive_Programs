using Competitive_Programs.String_programes;

namespace Competitive_Programs.Recursion
{
    internal class Sum_numbers
    {
        public static int sum(int n)
        {
            if(n==0)
                return 0 ;
            return n+sum(n-1);
        }
        public static int product(int n)
        {
            if (n == 1)
                return 0;
            return n * product(n-1);
        }
        public static int product_of_two_num(int x,int y)
        {
            if(x<y)
                return product_of_two_num(y,x);
            else if(y!=0)
                return x+product_of_two_num(x,y-1);
            else 
                return 0;
        }

        public static int Array_sum(int[] arr,int len) 
        {
            if (len <= 0)
                return 0;

            return (Array_sum(arr, len - 1) + arr[len-1]); 
        }
        public static int Array_prod(int[] arr, int len)
        {
            if (len == 0)
                return arr[len];

            return (arr[len]*Array_prod(arr,len-1));
        }

        public static int sum_dighits(int n)
        {
            if (n == 0)
                return 0;

           return (n%10)+ sum_dighits(n / 10);
        }

        public static string rev_num(int n)
        {
            if (n == 0)
                return " ";

            return ""+n%10+rev_num(n/10);

        }
        public static int Count_0s(int c)
        {
            return helper(c, 0);
        }
        public static int helper(int num , int n)
        {
            if(num == 0)
                return 0;

            int rem = n % 10;
            if (rem == 0)
            {
                return helper(num / 10, n + 1);
            }

            return helper(num / 10, n);
        }
        public static void sum_Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4 };
            Console.WriteLine(sum(n));
            Console.WriteLine(product(n));
            Console.WriteLine(Array_sum(arr,arr.Length));
            Console.WriteLine(Array_prod(arr,arr.Length-1));
            Console.WriteLine(product_of_two_num(5,2));
            Console.WriteLine(sum_dighits(795));
            Console.WriteLine(rev_num(654));

        }
    }
}
