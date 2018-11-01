// You are given a text. Write a program that changes the text in all regions 
// surrounded by the tags <upcase> and </upcase> to uppercase. 
// The tags cannot be nested. 
// Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.


using System;
using System.Text;

class UpperCaseTagging
{
    static void Main(string[] args)
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string tagOpen = "<upcase>";
        string tagClose = "</upcase>";

        string formatedText = FormatText(text, tagOpen, tagClose);

        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine(formatedText);
    }

    static string FormatText(string text, string tagOpen, string tagClose)
    {

        int countOfOpenningTags = FindNumberOfSubstrings(text, tagOpen);
        int countOfClosingTags = FindNumberOfSubstrings(text, tagClose);

        StringBuilder formatedText = new StringBuilder();

        if (countOfOpenningTags == countOfClosingTags)
        {
            int tagOpenSize = tagOpen.Length;
            int tagCloseSize = tagClose.Length;

            int index = 0;
            for (int i = 0; i < countOfOpenningTags; i++)
            {
                int tagOpenStart = text.IndexOf(tagOpen, index);
                int tagOpenEnd = tagOpenStart + tagOpenSize;
                int tagCloseStart = text.IndexOf(tagClose, index);
                int tagCloseEnd = tagCloseStart + tagCloseSize;

                for (int j = index; j <= tagCloseEnd; j++)
                {
                    if (j < tagOpenStart)
                    {
                        formatedText.Append(text[j].ToString());
                    }
                    else if (j >= tagOpenStart && j < tagOpenEnd)
                    {
                        continue;
                    }
                    else if (j >= tagOpenEnd && j < tagCloseStart)
                    {
                        formatedText.Append(text[j].ToString().ToUpper());
                    }
                    else if (j >= tagCloseStart && j < tagCloseEnd)
                    {
                        continue;
                    }
                }

                index = tagCloseEnd;
            }

            for (int i = formatedText.Length + countOfOpenningTags * tagOpenSize + countOfClosingTags * tagCloseSize; i < text.Length; i++)
            {
                formatedText.Append(text[i].ToString()); // Adding the characters adter the last tag.
            }
        }
        else
        {
            Console.WriteLine("EROOR! Mismatch of openning tags and closing tags numbers!");
            System.Environment.Exit(0);
        }

        return formatedText.ToString();
    }

    static int FindNumberOfSubstrings(string text, string subString)
    {
        int index = 0;
        int numberOfSubstrings = 0;

        while (index != -1)
        {
            index = text.IndexOf(subString, index + 1);
            numberOfSubstrings++;
        }

        return numberOfSubstrings - 1;
    }
}
