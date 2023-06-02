namespace WriteStuff1;

public class Program
{
    public static void Main(string[] args)
    {
        bool stop = false;
        string strToAdd;
        Queue<string> stringsToAdd = new Queue<string>();
        
        
        while (!stop)
        {
            Console.WriteLine("Write here string to add to file!");
            strToAdd = Console.ReadLine();

            if (string.IsNullOrEmpty(strToAdd)) stop = true;
            else stringsToAdd.Enqueue(strToAdd);
        }
        File.WriteAllLines(args[0],stringsToAdd);
    }
}