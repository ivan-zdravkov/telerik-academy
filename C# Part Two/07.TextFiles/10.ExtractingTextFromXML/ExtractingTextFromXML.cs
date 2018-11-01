// Write a program that extracts from given XML file all the text without the tags.

using System;
using System.IO;
using System.Text;

class ExtractingTextFromXML
{
    static void Main()
    {
        try
        {
            StreamReader reader = new StreamReader("../../File.xml");
            using (reader)
            {
                string rawText = reader.ReadToEnd();
                StringBuilder outputText = new StringBuilder();
                bool outsideTag = true;
                for (int i = 0; i < rawText.Length; i++)
                {
                    bool isWritten = false;
                    if (outsideTag)
                    {
                        if (rawText[i] == '<')
                        {
                            outsideTag = false;
                        }
                        else
                        {
                            outputText.Append(rawText[i]);
                            isWritten = true;
                        }
                    }
                    else
                    {
                        if (rawText[i] == '>')
                        {
                            outsideTag = true;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (isWritten)
                    {
                        if (i != rawText.Length - 1)
                        {
                            if (rawText[i + 1] == '<')
                            {
                                outputText.Append(" ");
                            }
                        }
                    }
                }
                Console.WriteLine(rawText);
                Console.WriteLine(outputText.ToString());
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}