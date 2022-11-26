using TestsGeneration.Generators;
using TestsGeneration.Parsers;
using Example.FileToFileGeneration;

namespace Example
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string resultDirPath = @"D:\files\results";
            List<string> files = new List<string>()
            {
                @"D:\files\Input.cs",
                @"D:\files\DoubleInput.cs"
            };

            FileToFileGenerator generator = new(
                new Parser(),
                new xUnitTestGenerator(),
                FileToFileGeneratorOptions.Default);

            await generator.GenerateTestsAsync(files, resultDirPath);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}