static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.ReplaceLineEndings("").Split(": ")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        switch (logLine.Split("]")[0])
        {
            case "[ERROR" : return "error";
            case "[WARNING" : return "warning";
            case "[INFO": return "info";
        }

        return "";
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
