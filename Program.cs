// See https://aka.ms/new-console-template for more information



string parentFolder = @"D:\test_files\Csharp_PSPM\BatchLog";
string[] subfolders = { "201", "202", "203", "204" };

foreach (string subfolder in subfolders)
{
    string subfolderPath = Path.Combine(parentFolder, subfolder);
    if (Directory.Exists(subfolderPath))
    {
        string[] files = Directory.GetFiles(subfolderPath);
        foreach (string file in files)
        {
            File.Delete(file);
        }
        Console.WriteLine($"Delete files in {subfolder}.");
        Thread.Sleep(200);
    }
}

string[] filesS1 = Directory.GetFiles(@"D:\test_files\Csharp_PSPM\IIS_generator\S1");

foreach (string file in filesS1)
{
    File.Delete(file);
}

Console.WriteLine("S1 cleared");
Thread.Sleep(200);

string basePath = @"D:\test_files\Csharp_PSPM\daily_report";
string todayDataFolder = DateTime.Now.ToString("yyMMdd");

string todayReportFullPath = Path.Combine(basePath, todayDataFolder);

if (!Directory.Exists(todayReportFullPath))
{
    Directory.CreateDirectory(todayReportFullPath);
    Console.WriteLine($"{todayDataFolder} created");
    Thread.Sleep(1000);
}
else
{
    Console.WriteLine($"{todayDataFolder} Exists");
    Thread.Sleep(1000);
}

