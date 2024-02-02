namespace palindrome_word_task;
using System.Text.RegularExpressions;

internal class Program
{
    //public static string 
    
    public static Char[] charArr(string str)
    {
        string[] t = str.Split(" ");
        string temp = String.Join(",", t);
        string strOutput = Regex.Replace(temp, @"[^\w\d\s+]", "");

        Char[] tempCharArr = new Char[strOutput.Length];
        for (int i = 0; i < strOutput.Length; i++)
        {
            tempCharArr[i] = strOutput[i];
        }

        return tempCharArr;
    }
    public static bool checkpalindrome(string str)
    {
        string[] t = str.Split(" ");
        string temp = String.Join(",", t);
        string strOutput = Regex.Replace(temp, @"[^\w\d\s+]", "");
        Char[] chararr = charArr(str); 
        Array.Reverse(chararr);
        string testString = new String(chararr);
        if (testString == strOutput)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static void Main(string[] args)
    {
        Console.Write("Enter your word :");
        string strInput= Console.ReadLine();
        if (checkpalindrome(strInput))
        {
            Console.WriteLine("This is palindrome");
        }
        else
        {
            Console.WriteLine("This is not palindrome");
        }

        

        
    }
}