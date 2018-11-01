// Write a program that parses an URL address given in the format and extracts from it the 
// [protocol], [server] and [resource] elements. 
// For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
// [protocol] = "http"
// [server] = "www.devbg.org"
// [resource] = "/forum/index.php"

using System;
using System.Text;

class ExtractingURL
{
    static void Main()
    {
        string url = "http://www.devbg.org/forum/index.php";
        string protocol = String.Empty;
        string server = String.Empty;
        string resource = String.Empty;

        int currentIndex = 0;
        StringBuilder temp = new StringBuilder();

        for (int i = currentIndex; i < url.Length; i++)
        {
            if (url[i] != ':')
            {
                temp.Append(url[i]);
            }
            else
            {
                currentIndex = i + 3;
                break;
            }
        }
        protocol = temp.ToString();
        temp.Clear();

        for (int i = currentIndex; i < url.Length; i++)
        {
            if (url[i] != '/')
            {
                temp.Append(url[i]);
            }
            else
            {
                currentIndex = i;
                break;
            }
        }
        server = temp.ToString();
        temp.Clear();

        for (int i = currentIndex; i < url.Length; i++)
        {
            temp.Append(url[i]);
        }
        resource = temp.ToString();

        Console.WriteLine(protocol);
        Console.WriteLine(server);
        Console.WriteLine(resource);
    }
}