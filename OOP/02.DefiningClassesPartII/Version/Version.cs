using System;
using System.Linq;

[AttributeUsage(AttributeTargets.Struct | AttributeTargets.Interface |
AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method)]
public class VersionLabel : System.Attribute
{
    private int major;
    public int Major 
    { 
        get { return major; }
        set { major = value; } 
    }

    private int minor;
    public int Minor
    {
        get { return minor; }
        set { minor = value; }
    }

    private string versions;
    public string Versions
    {
        get { return versions; }
    }

    public VersionLabel(int major, int minor)
    {
        this.major = major;
        this.minor = minor;
        this.versions = string.Format("{0}.{1}", major, minor);
    }
}
