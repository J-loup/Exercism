using System;
using System.Collections.Generic;

public static class Languages
{
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages()
    {
        string[] input = {"C#", "Clojure", "Elm"};
        return new List<string>(input); 
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages) => languages.Count;

    public static bool HasLanguage(List<string> languages, string language)
    {
        var found = languages.Find(x => x.Contains(language));
        return found == null ? false : true;
    }

    public static List<string> ReverseList(List<string> languages)
    {
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages) => languages.Count > 0 && (languages[0] == "C#" || (languages[1] == "C#" && languages.Count >= 2 && languages.Count <= 3));

    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        foreach(string language in languages)
        {
            var list = languages.FindAll(x => x.Contains(language));
            if (list.Count > 1)
            {
                return false;
            }
        }
    
        return true;
    }
}
