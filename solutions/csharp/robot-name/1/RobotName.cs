public class Robot
{
    private static string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static HashSet<string> NameSet = new HashSet<string>();
    private void generate_name()
    {
        string name;
        do {
            Random rand = new Random();
            name = "";
            name += Chars[rand.Next(0, Chars.Length)];
            name += Chars[rand.Next(0, Chars.Length)];
            name += rand.Next(10);
            name += rand.Next(10);
            name += rand.Next(10);
        } while (!NameSet.Add(name));
        Name = name;
    }

    public Robot ()
    {
        generate_name();
    }
    
    public string Name;

    public void Reset()
    {
        generate_name();
    }
}