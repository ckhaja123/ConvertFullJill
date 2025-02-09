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

        // Updated regex pattern to match CSS blocks starting with h5 { and ending with }
        string pattern = @"h5\s*\{(?:[^{}]*|\s)*\}";

        // Remove all matching blocks
        string updatedContent = Regex.Replace(fileContent, pattern, "", RegexOptions.Multiline);

        // Write the updated content back to a new file
        File.WriteAllText(outputFilePath, updatedContent);

        Console.WriteLine("Matching blocks have been removed successfully.");
    }
}
