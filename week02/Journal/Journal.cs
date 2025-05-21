class Journal
{
    List<string> _entries = new List<string>();
    string fileName = "myfile.txt";
    
    public void AddEntry()
    {
        Console.WriteLine("Please write below");
        string answer = Console.ReadLine();

        PromptGenerator _promptGenerator = new PromptGenerator();
        string prompt = _promptGenerator.GetRandomPrompt();


        _entries.Add(answer); // Save to the entrie list
        _entries.Add(prompt);
        File.AppendAllText(fileName, answer);
    }

    public void DisplayAll ()
    {
        if (File.Exists(fileName))

        {
            string [] lines = File.ReadAllLines (fileName);
            foreach (string line in lines)
            {
                Console.WriteLine (line);
            }
        }
        else
        {
            Console.WriteLine("File not found");
        }
        
        

    }

    public void SaveToFile (string filename)
    {
             
        File.WriteAllLines (filename, _entries) ;

    }

    public void LoadFromFile (string filename) 
    {
        
        string [] lines = System.IO.File.ReadAllLines (filename);

        foreach (string line in lines)
        {
            string [] parts = line.Split('|');
            string firstName = parts[0];
            string lastName = parts[1];

            Console.WriteLine(line);
        }

    }
}