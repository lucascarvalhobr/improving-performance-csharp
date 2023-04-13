using System.Text;

namespace CSharpPerformance.Code;
public class StringWorker
{
    /// <summary>
    /// 
    /// This method is bad because a string is immutable, whenever the code calls for it to be changed, a new string must be created
    /// Any operation in a string will result in a new string
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public string BuildStringBadly(string text)
    {
        for (var i = 0; i < 50; i++)
        {
            text += " " + "test";
        }

        return text;
    }

    //strings are immutable
    public string BuildStringBetter(string value)
    {
        var sb = new StringBuilder(value);

        for (var i = 0; i < 50; i++)
        {
            sb.Append(' ');
            sb.Append(value);
        }

        return sb.ToString();
    }

    public (string lastName, string firstName) SplitNameUsingSubstring(string name)
    {
        var commaPost = name.IndexOf(',');
        var lastName = name.Substring(0, commaPost);
        var firstName = name.Substring(commaPost + 2);

        return (lastName, firstName);
    }

    public (string lastName, string firstName) SplitNameUsingSplitMethod(string name)
    {
        var nameArray = name.Split(',');

        return (nameArray[0].Trim(), nameArray[1].Trim());
    }

    public (string lastName, string firstName) SplitNameUsingSpan(string name)
    {
        ReadOnlySpan<char> nameSpan = name.AsSpan();

        var lastName = nameSpan.Slice(0, name.IndexOf(',')).ToString();
        var firstName = nameSpan.Slice(name.IndexOf(',') + 2).ToString();

        return (lastName, firstName);
    }
}
