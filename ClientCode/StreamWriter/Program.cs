

class Program
{
    static void Main(string[] args)
    {
        //WriteMuchData();
        ReadTheData();
        Console.WriteLine("Done");
    }

    private static void ReadTheData()
    {
        var stream = File.OpenRead(@"E:\big.txt");
        var reader = new StreamReader(stream);
        var counter = 0;
        string? line;
        while ((line = reader.ReadLine()) != null)
        {
            counter++;
            if (counter % 1000 == 0)
            {
                System.Console.WriteLine(line);
            }
        }
    }

    private static void WriteMuchData()
    {
        var stream = File.OpenWrite(@"E:\big.txt");
        var writer = new StreamWriter(stream);
        for (var i = 0; i < 100_000_000; i++)
        {
            writer.WriteLine($"Hello World {i}");
        }
        writer.Dispose();
    }
}
