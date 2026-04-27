public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string message, string delimiter)
    {
        return message.Split(delimiter)[1];
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string message, string start, string end)
    {
        string temp = message.Split(start)[1];
        return temp.Split(end)[0];
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string input)
    {
        return input.SubstringAfter(": ");
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string input)
    {
        return input.SubstringBetween("[", "]");
    }
}