using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Specify the input and output file paths
        string inputFilePath = "path/to/your/input.txt";
        string outputFilePath = "path/to/your/output.txt";

        // Read the file content
        string fileContent = File.ReadAllText(inputFilePath);

        // Regex pattern to match blocks starting with h5 { and ending with }
        string pattern = @"(?sm)^h5\s*\{.*?\}";

        // Remove all matching blocks
        string updatedContent = Regex.Replace(fileContent, pattern, "");

        // Write the updated content back to a new file
        File.WriteAllText(outputFilePath, updatedContent);

        Console.WriteLine("Matching blocks have been removed successfully.");
    }
}
