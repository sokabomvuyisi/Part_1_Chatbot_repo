# Part_1_Chatbot_repo
# Cybersecurity Chatbot: Cyber-press
- This is a console-based cybersecurity chatbot built in C# (.NET 8) that educates users on cybersecurity best practices through an interactive question-and-answer interface. The application features ASCII art, an audio greeting, colour-coded console output, and personalised user interaction.
# Table of Contents
- About project
- Features
- Project structure
- Author
  
# About project
- i created a command-line chatbot designed to help everyday users understand cybersecurity. It responds to ten common cybersecurity questions covering topics such as password safety, phishing attacks, malware, public Wi-Fi risks, and more for the time being.
  
# Features
- ASCII Art Banner — A visually styled welcome banner displayed on launch
- Audio Greeting — Plays a WAV greeting file on startup (if available)
- Personalised Interaction — Asks for the user's name and uses it throughout the session
- 10 Cybersecurity Q&A Topics — Covering passwords, threats, phishing, malware, Wi-Fi safety, and more
- Input Validation — Handles invalid menu choices, empty name input, and unrecognised yes/no responses
- Colour-Coded Console UI — Green for questions, cyan for responses, yellow for warnings
- Looping Conversation — Users can ask multiple questions in one session
- Graceful Exit — Personalised farewell message when the user chooses to leave
  
# Project Structure
CyberGuardChatbot/
│
├── Chatbot.cs          
├── Audioplay.cs        
├── UserQuery.cs        
├── greeting.wav        
└── README.md  

# Author
- Mvuyisi Sokabo
- Date submitted: 13 April 2026
