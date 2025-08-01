using System;

static class LogLine
{
    public static string Message(string logLine) => logLine.Split(": ")[1].Trim();

    public static string LogLevel(string logLine) => logLine.Split("]")[0].Substring(1).ToLower();

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string log = LogLevel(logLine);                                
        return $"{message} ({log})";
    }
}
