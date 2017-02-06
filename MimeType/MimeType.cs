using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static string GetMIMEType(Dictionary<string, string> extMT, string filename)
    {
        int extIndex = 0;
        
        if ((extIndex = filename.LastIndexOf('.')) == -1)
            return "UNKNOWN";
        string extension = filename.Substring(extIndex + 1);
        string value = string.Empty;
        if (extMT.TryGetValue(extension, out value))
            return value;
        return "UNKNOWN";
    }
    
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        Dictionary<string, string> extMT = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        
        for (int i = 0; i < N; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            extMT.Add(inputs[0], inputs[1]);
        }
        
        for (int i = 0; i < Q; i++)
        {
            Console.WriteLine(GetMIMEType(extMT, Console.ReadLine()));
        }
    }
}