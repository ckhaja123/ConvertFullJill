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

        // Regex pattern to match any CSS-like block
        string pattern = @"[a-zA-Z0-9\s,]+\{(?:[^{}]*|\s)*?\}";

        // Remove all matching blocks
        string updatedContent = Regex.Replace(fileContent, pattern, "", RegexOptions.Multiline);

        // Write the updated content back to a new file
        File.WriteAllText(outputFilePath, updatedContent);

        Console.WriteLine("All matching CSS blocks have been removed successfully.");
    }
}
