using System;
using System.Text;
using System.Text.RegularExpressions;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder("", identifier.Length);
        for (int i = 0; i < identifier.Length; i++)
        {
            string c = identifier[i].ToString();
            if (c == " ")
            {
                c = "_";
            }
            if (c == "-" && i != identifier.Length - 1)
            {
                c = "";
                c = identifier[++i].ToString().ToUpper();
            }
            if (c == "\0")
            {
                c = "CTRL";
            }
                
            sb.Append(c);
        }
        
        string res = sb.ToString();
        res = Regex.Replace(res, "\\W|\\d", "");
        res = Regex.Replace(res, "[α-ω]", "");
        return res;
    }
}
