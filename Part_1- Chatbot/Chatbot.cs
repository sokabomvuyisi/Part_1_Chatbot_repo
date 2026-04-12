using System;

//Main method to call Audio player and UserQuery
public class Chatbot
{
    public static void Main(string[] args)
    {
        //Chatbot logo
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(@"===================================================================================================================");
        Console.WriteLine(@"                                                       
(_______)    | |                                                        
 _      _   _| |__  _____  ____    _____    ____   ____ _____  ___  ___ 
| |    | | | |  _ \| ___ |/ ___)  (_____)  |  _ \ / ___) ___ |/___)/___)
| |____| |_| | |_) ) ____| |               | |_| | |   | ____|___ |___ |
 \______)__  |____/|_____)_|               |  __/|_|   |_____|___/(___/ 
       (____/                              |_|                            ");
        Console.WriteLine(@"====================================================================================================================");

        //call audio play in the main method
        try
        {
            var audio = new Audioplay();
            audio.PlayGreeting();
        }
        catch
 {
     Console.ForegroundColor = ConsoleColor.DarkYellow;
     Console.WriteLine("[Audio]: Could not play greeting audio.");
     Console.ResetColor();
 }

        // call UserQuery in the main method
        new UserQuery();
    }
}
