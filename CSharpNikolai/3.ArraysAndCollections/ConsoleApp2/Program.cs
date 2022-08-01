using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


class Result
{

    /*
     * Complete the 'maximumOccurringCharacter' function below.
     *
     * The function is expected to return a CHARACTER.
     * The function accepts STRING text as parameter.
     */

    public static char maximumOccurringCharacter(string text)
    {
        // Create array to keep the count of
        // individual characters and
        // initialize the array as 0
        int[] count = new int[256];

        // Construct character count array
        // from the input string.
        int len = text.Length;
        for (int i = 0; i < len; i++)
            count[text[i]]++;

        int max = -1; // Initialize max count
        char result = ' '; // Initialize result

        // Traversing through the string and
        // maintaining the count of each character
        for (int i = 0; i < len; i++)
        {
            if (max < count[text[i]])
            {
                max = count[text[i]];
                result = text[i];
            }
        }

        return result;
    }
}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string text = Console.ReadLine();

        char result = Result.maximumOccurringCharacter(text);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}