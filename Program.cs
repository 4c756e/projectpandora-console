namespace projectpandora_console;
using System;
using System.IO;

class Program
{
    static string input;
    static string filepath = "/files/data.txt";
    static string authspath = "/files/info.txt";


    public static void Main()
    {
        //DetectFile();
        using (FileStream ww = new FileStream("data.txt", FileMode.CreateNew))
        {
            using (StreamWriter w = new StreamWriter(ww))
            {
                w.Write("testeETETETET");
            }
        }
    }

    static void DetectFile()
    {
        if (!File.Exists(filepath)) { StartCreation(); }
        else { StartPan(); }
    }

    static void StartPan()
    {
        bool exit = false,errorMessage=false;
        do
        {
            if (errorMessage) { ProgMenu(" Press the Right Button"); }
            else { ProgMenu(""); }

            input = Console.ReadLine();
            errorMessage = CheckSelected(input);
        } while(!exit);
    }

    static void StartCreation()
    {
        Console.WriteLine(" Do you want to create the files?");
        string answer=Console.ReadLine();

        if (!File.Exists(filepath))
        {
            using (StreamWriter w = File.AppendText("data.txt"))
            {
                w.Write("testeETETETET");
            }
        }
        DetectFile();
    }

    static void ProgMenu(string message)
    {
        ////////////// Remember language
        Console.Clear();
        Console.WriteLine(" ------------------------\n");
        Console.WriteLine("  Menu:\n ");
        Console.WriteLine(" [1] List (Locked)");
        Console.WriteLine(" [2] Bot (Locked)");
        Console.WriteLine(" [3] Settings (Locked)");
        Console.WriteLine(" [0] Close (Locked)");
        Console.WriteLine(" ------------------------\n");
        Console.WriteLine(" {0}",message);
    }

    static bool CheckSelected(string typed)
    {
        int value;
        typed=typed.ToLower();
        if (typed == "close" || typed == "c" || typed == "0" || typed == "fechar" || typed == "f") { SaveFile(true); }
        else if (typed == "list" || typed == "l" || typed == "1" || typed == "lista") { }
        else if (typed == "Bot" || typed == "b" || typed == "2") { }
        else if (typed == "settings" || typed == "s" || typed == "3" || typed == "opcoes" || typed == "o") { }
        else { return true; }
        return false;

    }

    static void SaveFile(bool close)
    {
        //close app if
    }
}
