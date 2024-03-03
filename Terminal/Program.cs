string ReadCommand()
{
    Console.ForegroundColor = ConsoleColor.White;
    string currDir = Directory.GetCurrentDirectory();
    Console.Write("command@{0} > ",Path.GetFileName(currDir));
    return Console.ReadLine();
}

void PrintError(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
}
void PrintDir(string dir)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(Path.GetFileName(dir));
}
void PrintFile(string file)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(Path.GetFileName(file));
}

void DoClear()
{
    Console.Clear();
}

void DoList()
{
    string[] dirs = Directory.GetDirectories(Directory.GetCurrentDirectory());
    string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

    foreach (string dir in dirs)
        PrintDir(dir);

    foreach (string file in files)
        PrintFile(file);

}

void DoChDir(string dir)
{
    Directory.SetCurrentDirectory(dir);
}

void DoShowFile(string file)
{
    if(File.Exists(file))
    {
        string[] lines = File.ReadAllLines(file);

        for (int i=0;i<lines.Length;i++)
        {
            string line = lines[i];

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(line);
        }

    }
    else
    {
        PrintError("Böyle bir dosya yok");
    }
}

void ExecuteCommand(string command)
{
    string[] part = command.Split(' ');
    string cmd = part[0].ToLower();

    if (cmd == "clear")
    {
        DoClear();
    }
    else if (cmd == "list")
    {
        DoList();
    }
    else if (cmd == "chdir")
    {
        DoChDir(part[1]);
    }
    else if (cmd == "showfile")
    {
        DoShowFile(part[1]);
    }
    else
    {
        PrintError("Böyle bir komut yok");
    }
}

do
{
    string cmd = ReadCommand();

    ExecuteCommand(cmd);

} while (true);
