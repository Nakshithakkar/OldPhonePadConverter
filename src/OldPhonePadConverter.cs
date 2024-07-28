using System;
using System.Collections.Generic;
using System.Text;

class OldPhonePadConverter
{
    private static readonly Dictionary<char, string> mapping = new Dictionary<char, string> {
        {'2', "ABC"}, {'3', "DEF"}, {'4', "GHI"},
        {'5', "JKL"}, {'6', "MNO"}, {'7', "PQRS"},
        {'8', "TUV"}, {'9', "WXYZ"}, {'0', " "},
    };

    public string Convert(string inputString)
    {
        StringBuilder output = new StringBuilder();
        char currentChar = ' ';
        int count = 0;

        for (int i = 0; i < inputString.Length; i++)
        {
            char c = inputString[i];

            if (c == '#')
            {
                AddCurrentCharToOutput(output, currentChar, count);
                break;
            }
            else if (c == '*')
            {
                if (output.Length > 0)
                {
                    output.Length--;
                }
                currentChar = ' ';
                count = 0;
            }
            else if (char.IsDigit(c))
            {
                if (c == currentChar)
                {
                    count++;
                }
                else
                {
                    AddCurrentCharToOutput(output, currentChar, count);
                    currentChar = c;
                    count = 1;
                }
            }
            else if (c == ' ')
            {
                AddCurrentCharToOutput(output, currentChar, count);
                currentChar = ' ';
                count = 0;
            }

            // If this is the last character, add it to the output
            if (i == inputString.Length - 1)
            {
                AddCurrentCharToOutput(output, currentChar, count);
            }
        }

        return output.ToString();
    }

    private void AddCurrentCharToOutput(StringBuilder output, char currentChar, int count)
    {
        if (currentChar != ' ' && count > 0 && mapping.ContainsKey(currentChar))
        {
            output.Append(mapping[currentChar][(count - 1) % mapping[currentChar].Length]);
        }
    }

    static void Main(string[] args)
    {
        OldPhonePadConverter converter = new OldPhonePadConverter();

        while (true)
        {
            Console.WriteLine("Enter the input string (or type 'exit' to quit): ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrEmpty(userInput) || userInput.ToLower() == "exit")
            {
                break;
            }

            string result = converter.Convert(userInput);
            Console.WriteLine("Old Phone Pad output: " + result);
            Console.WriteLine();
        }
    }
} 
