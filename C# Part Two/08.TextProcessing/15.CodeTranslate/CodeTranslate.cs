// Write a program that replaces in a HTML document given as string all the tags 
// <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;
using System.Text.RegularExpressions;

class CodeTranslate
{
    static void Main(string[] args)
    {
        string link = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        
        Console.WriteLine(link);
        Console.WriteLine();
        Console.WriteLine(Regex.Replace(link, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"));
    }
}