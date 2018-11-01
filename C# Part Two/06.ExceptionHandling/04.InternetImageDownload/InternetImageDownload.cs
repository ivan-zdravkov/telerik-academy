// Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. 
// Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class InternetImageDownload
{
    static string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                string URL = "http://www.devbg.org/img/Logo-BASD.jpg";
                string fileName = "Logo-BASD.jpg";
                string filePath = desktop + "\\" + fileName;

                webClient.DownloadFile(URL, filePath);

                Console.WriteLine("DONE");
                Console.WriteLine("File downloaded at {0}", filePath);
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid Address!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Simultaneously method call on multiple threads!");
            }
        }
    }
}
