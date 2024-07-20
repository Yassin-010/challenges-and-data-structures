namespace CC6_B
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "Reverse the words in this sentence";

            Console.WriteLine(ReverseWords(str));
        }

        public static string ReverseWords(string str)
        {
            string newStr = "";

            string[] arrStr = str.Split(" ");

            for (int i = arrStr.Length - 1; i >= 0; i--)
            {
                if (i > 0)
                {
                    newStr += arrStr[i] + " ";
                }
                else
                {
                    newStr += arrStr[i];
                }
            }
            return newStr;
        }
    }
}
