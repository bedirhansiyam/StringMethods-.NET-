namespace StringMethods;
class Program
{
    static void Main(string[] args)
    {
        string variable = "Our lesson is CSharp, Welcome!";
        string variable2 = "Our lesson is CSharp";

        //Length
        Console.WriteLine(variable.Length);   // 30

        //ToUpper, ToLower
        Console.WriteLine(variable.ToUpper());   //OUR LESSON IS CSHARP, WELCOME!     
        Console.WriteLine(variable.ToLower());   //our lesson is csharp, welcome!

        //Concat
        Console.WriteLine(String.Concat(variable," Hello"));   //Our lesson is CSharp, Welcome! Hello

        //Compare, CompareTo
        Console.WriteLine(variable.CompareTo(variable2));   //1
        Console.WriteLine(String.Compare(variable,variable2,true));   //1
        Console.WriteLine(String.Compare(variable,variable2,false));   //1

        //Contains
        Console.WriteLine(variable.Contains(variable2));   //True
        Console.WriteLine(variable.EndsWith("Welcome!"));   //True
        Console.WriteLine(variable.StartsWith("Hello"));   //False

        //IndexOf
        Console.WriteLine(variable.IndexOf("C"));   //14
        Console.WriteLine(variable.IndexOf("b"));   //-1
        Console.WriteLine(variable.LastIndexOf("o"));   //26

        //Insert
        Console.WriteLine(variable.Insert(0,"Hello! "));   //Hello! Our lesson is CSharp, Welcome!
        
        //PadLeft, PadRight
        Console.WriteLine(variable + variable2.PadLeft(30));   //Our lesson is CSharp, Welcome!          Our lesson is CSharp
        Console.WriteLine(variable + variable2.PadLeft(30,'-'));   //Our lesson is CSharp, Welcome!          Our lesson is CSharp
        Console.WriteLine(variable.PadRight(50) + variable2);   //Our lesson is CSharp, Welcome!                    Our lesson is CSharp
        Console.WriteLine(variable.PadRight(50,'*') + variable2);   //Our lesson is CSharp, Welcome!********************Our lesson is CSharp

        //Remove
        Console.WriteLine(variable.Remove(10));   //Our lesson
        Console.WriteLine(variable.Remove(7,3));   //Our les is CSharp, Welcome

        //Replace
        Console.WriteLine(variable.Replace("CSharp", "C#"));   //Our lesson is C#, Welcome!

        //Split
        Console.WriteLine(variable.Split(' ')[3]);   //CSharp,

        //SubString
        Console.WriteLine(variable.Substring(4));   //lesson is CSharp, Welcome!
        Console.WriteLine(variable.Substring(4,6));   //lesson
        

    }
}
