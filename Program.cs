using System; 
using System.IO; 

class LineNumberInserter
{
    static void Main()
    {
        StreamReader r = new StreamReader(@"C:\Users\krisi\Desktop\TU-Varna\C#\ППС#\projects\lab11\Lab11.ex5\bin\Debug\net10.0\proba.txt");
        StreamWriter w = new StreamWriter("out.txt");

        int lineNumber = 0; 
        string line = r.ReadLine();

        while(line != null) 
        {
            lineNumber++;
            w.WriteLine("{0,5} {1}", lineNumber, line);
            line = r.ReadLine();

        }
        w.Close();
        r.Close();

        r = new StreamReader("out.txt");
        lineNumber = 0;
        line = r.ReadLine();
        while(line != null)
        {
            lineNumber++;
            Console.WriteLine("{0}", line);
            line = r.ReadLine();
        }
        r.Close();
        Console.ReadLine();
    }
}