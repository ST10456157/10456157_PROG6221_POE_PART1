using System;
using NAudio.Wave;

namespace CyberAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play voice greeting
            try
            {
                using (var audioFile = new AudioFileReader("greeting.wav"))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(100); // Wait for audio to finish
                    }
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error playing greeting audio: " + ex.Message);
                Console.ResetColor();
            }

            // ASCII Art Greeting
            Console.WriteLine(@"
  ___  _  _  ____  ____  ____  ____  ____  ___  _  _  ____  __  ____  _  _     __   _  _   __   ____  ____  __ _  ____  ____  ____    ____   __  ____ 
 / __)( \/ )(  _ \(  __)(  _ \/ ___)(  __)/ __)/ )( \(  _ \(  )(_  _)( \/ )   / _\ / )( \ / _\ (  _ \(  __)(  ( \(  __)/ ___)/ ___)  (  _ \ /  \(_  _)
( (__  )  /  ) _ ( ) _)  )   /\___ \ ) _)( (__ ) \/ ( )   / )(   )(   )  /   /    \\ /\ //    \ )   / ) _) /    / ) _) \___ \\___ \   ) _ ((  O ) )(  
 \___)(__/  (____/(____)(__\_)(____/(____)\___)\____/(__\_)(__) (__) (__/    \_/\_/(_/\_)\_/\_/(__\_)(____)\_)__)(____)(____/(____/  (____/ \__/ (__)
");

            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot! ");

            // Ask for user's name
            Console.Write("What’s your name? ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name)) name = "Friend";

            Console.WriteLine($"Hello, {name}! I'm here to help you stay safe online. 💻Ask me anything about cybersecurity. Type 'exit' to leave. ");

        }
    }
}

    
        


