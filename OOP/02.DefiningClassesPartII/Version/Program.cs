/* 11) Create a [Version] attribute that can be applied to structures, classes, interfaces, 
enumerations and methods and holds a version in the format major.minor (e.g. 2.11). 
Apply the version attribute to a sample class and display its version at runtime.
*/

using System;

[VersionLabel(1, 12)]
public class Program
{
    public static void Main()
    {
        Type type = typeof(Program);
        object[] attributes = type.GetCustomAttributes(false);
        foreach (VersionLabel attribute in attributes)
        {
            Console.WriteLine("Class {0} version is {1}", type, attribute.Versions);
        }
    }
}
