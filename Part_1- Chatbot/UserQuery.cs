using System;

public class UserQuery
{
	public UserQuery()
	{
        //prompt the user to input their name
        Console.WriteLine("\nEnter your name");

        //validate the user input to ensure that it is not empty or whitespace, and if it is, prompt the user to enter their name again until a valid input is received.
        string Name = Console.ReadLine() ?? string.Empty;
        while (string.IsNullOrWhiteSpace(Name))
        {
            Console.WriteLine("Please tell me your name so I can address you properly.");
            Console.Write("Enter your name: ");
            Name = Console.ReadLine() ?? string.Empty;
        }
        //greet the user by name and introduce the chatbot's purpose
        Console.WriteLine($"Hello {Name}! I am your chabot assistance, here to answer your questions regarding cybersecurity");

        //initialize a variable to store the user's answer and use a do-while loop to allow the user to ask multiple questions until they choose to exit the program.
        string answer;
        do
        {
            // Provide a list of question options to the user and allow them to select one each time
            Console.WriteLine("\nPlease select a question from the following options:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("0. What is your purpose and how can you assist me with cybersecurity-related questions?");
            Console.WriteLine("1. What are the best practices for creating strong passwords?");
            Console.WriteLine("2. What are some common cybersecurity threats and how can I protect against them?");
            Console.WriteLine("3. How can I protect my personal information online?");
            Console.WriteLine("4. What should I do if I think my computer has been infected with malware?");
            Console.WriteLine("5. How can I stay safe while using public Wi-Fi?");
            Console.WriteLine("6. What are some common signs of a phishing attack and how can I avoid falling victim to one?");
            Console.WriteLine("7. How can I protect my online accounts from being hacked?");
            Console.WriteLine("8. What are some common cybersecurity best practices for businesses and organizations?");
            Console.WriteLine("9. How can I stay up to date on the latest cybersecurity threats and trends?");
            Console.ResetColor();

            // Validate the user's input to ensure that it is a number between 0 and 9, and if it is not, prompt the user to enter a valid input.
            var input = Console.ReadLine() ?? string.Empty;
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine($"Unfortunately {Name} i am still being developed, i may be unable to assist you with your input. Please enter a number between 0 and 9 for the moment.");
            }
            // Use a switch statement to provide the appropriate response based on the user's selection.
            else
            {
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("I am a chatbot designed to assist you with cybersecurity-related questions. I can provide information on best practices, common threats, and how to protect against them. Feel free to ask me any questions you may have about cybersecurity!");
                        break;
                    case 1:
                        Console.WriteLine("Best practices for creating strong passwords include using a combination of upper and lower case letters, numbers, and special characters. Avoid using easily guessable information such as your name or birthdate, and consider using a password manager to generate and store complex passwords.");
                        break;
                    case 2:
                        Console.WriteLine("Common cybersecurity threats include malware, phishing attacks, and ransomware. To protect against these threats, it's important to keep your software and operating system up to date, use strong passwords, and be cautious when clicking on links or downloading attachments from unknown sources.");
                        break;
                    case 3:
                        Console.WriteLine("To protect your personal information online, be cautious about sharing sensitive information such as your address or phone number. Use strong passwords and enable two-factor authentication on your accounts, and be mindful of the privacy settings on social media platforms.");
                        break;
                    case 4:
                        Console.WriteLine("If you think your computer has been infected with malware, it's important to run a full scan with your antivirus software and remove any detected threats. You should also change your passwords and monitor your accounts for any suspicious activity.");
                        break;
                    case 5:
                        Console.WriteLine("To stay safe while using public Wi-Fi, avoid accessing sensitive information such as online banking or shopping accounts. Use a virtual private network (VPN) to encrypt your internet connection and consider using a personal hotspot instead of public Wi-Fi when possible.");
                        break;
                    case 6:
                        Console.WriteLine("Common signs of a phishing attack include receiving unsolicited emails or messages that ask for personal information or contain suspicious links. To avoid falling victim to a phishing attack, be cautious when clicking on links or downloading attachments from unknown sources, and verify the legitimacy of any requests for personal information.");
                        break;
                    case 7:
                        Console.WriteLine("To protect your online accounts from being hacked, use strong passwords and enable two-factor authentication. Be cautious about sharing personal information online and monitor your accounts for any suspicious activity.");
                        break;
                    case 8:
                        Console.WriteLine("Common cybersecurity best practices for businesses and organizations include implementing strong access controls, regularly updating software and systems, and providing cybersecurity training for employees. It's also important to have a response plan in place in case of a cybersecurity incident.");
                        break;
                    case 9:
                        Console.WriteLine("To stay up to date on the latest cybersecurity threats and trends, consider following reputable cybersecurity news sources and blogs, attending industry conferences and events, and participating in online forums and communities focused on cybersecurity.");
                        break;
                    default:
                        Console.WriteLine("Unfortunately i am still being developed, thus please for the moment enter values from 0 to 9 .");
                        break;
                }
            }
            // After providing the response, ask the user if they would like to ask another question and repeat the process until they choose to exit.
            Console.WriteLine("\nWould you like to ask another question? (Yes/No)");
            answer = Console.ReadLine()?.Trim() ?? "N";
        }//use case-sensitive to check if the user 's answer is either "yes" or "y" or "no" or "n" or any other variation of these responses, and if it is not, prompt the user to enter a valid input until a valid input is received.
        while(answer.Equals("yes", StringComparison.OrdinalIgnoreCase) || answer.Equals("y", StringComparison.OrdinalIgnoreCase) || answer.Equals("no", StringComparison.OrdinalIgnoreCase) || answer.Equals("n", StringComparison.OrdinalIgnoreCase) || answer.Equals("Y" , StringComparison.OrdinalIgnoreCase) || answer.Equals("Yes", StringComparison.OrdinalIgnoreCase) || answer.Equals("N", StringComparison.OrdinalIgnoreCase) || answer.Equals("No", StringComparison.OrdinalIgnoreCase) || string.IsNullOrWhiteSpace(answer));
        // If the user chooses to exit, thank them for their time and end the program.
        Console.WriteLine("Thank you for your time. Stay safe.");
    }
}
