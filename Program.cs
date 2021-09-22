﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Diagnostics;
using System.Drawing;
using System.Media;

namespace GubbenIRummet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Game currentGame = new Game();
            currentGame.Start();

            
            int answersFalse = 0;
            int answer;
            bool gameOver = false;
            GameTitle();
            while (!gameOver)
            {
                Question question1 = new Question("     Vad heter världen mest använda sökmotor?\n 1 = Google\n 2 = Bing\n 3 = Edge", 1);
                Console.WriteLine(question1.Questions);
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (question1.CheckAnswer(answer) != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel svar, försök igen!");
                        Console.ResetColor();
                        answersFalse++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning!");
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rätt! Nästa fråga:");
                Console.ResetColor();

                Question question2 = new Question("     I datatyperna Float och Double kan du lagra??\n 1 = Endast heltal, Double kan lagra dubbelt så stora heltal som float\n 2 = Decimaltal\n 3 = Teckensträngar, Double kan lagra två strängar", 2);
                Console.WriteLine(question2.Questions);
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (question2.CheckAnswer(answer) != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel svar, försök igen!");
                        Console.ResetColor();
                        answersFalse++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning!");
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rätt! Nästa fråga:");
                Console.ResetColor();
                Question question3 = new Question("     Hur många binära siffror innehåller en klassisk IP-adress??\n 1 = 16\n 2 = 64\n 3 = 32", 3);
                Console.WriteLine(question3.Questions);
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (question3.CheckAnswer(answer) != true)
                    {
                        Console.WriteLine("Fel svar, försök igen!");
                        answersFalse++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning!");
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rätt! Nästa fråga:");
                Console.ResetColor();
                Question question4 = new Question("     Vad är källkod?\n 1 = Kod till källardörren\n 2 = Den kod du skriver i t.ex Visual studio\n 3 = Ett slags hemligt tecken som endast de 'riktiga' programmerarna känner till. Tidigare arbetade programmerare ofta på källarvåningen därav uttrycket källkod", 2);
                Console.WriteLine(question4.Questions);
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (question4.CheckAnswer(answer) != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel svar, försök igen!");
                        Console.ResetColor();
                        answersFalse++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning!");
                    continue;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rätt! Nästa fråga:");
                Console.ResetColor();
                Question question5 = new Question("     Vad menas med kompilering?\n 1 = Omvandling från ett programspråk till maskinkod\n 2 = Ett sätt att komprimera program\n 3 = När du ger en variabel ett nytt värde görs en kompilering", 1);
                Console.WriteLine(question5.Questions);
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    if (question5.CheckAnswer(answer) != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fel svar, försök igen!");
                        Console.ResetColor();
                        answersFalse++;
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Felaktig inmatning!");
                    continue;
                }

                // Lägg in fler frågor här.

                if (answersFalse < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    SoundPlayer victoryNoise = new SoundPlayer("applause_y.wav");
                    victoryNoise.Load();
                    victoryNoise.Play();

                    Console.WriteLine("     Grattis! Du svarade inte fel någon gång!");
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    SoundPlayer victoryNoise = new SoundPlayer("applause_y.wav");
                    victoryNoise.Load();
                    victoryNoise.Play();

                    Console.WriteLine($"     Grattis! Du svarade bara fel {answersFalse} gånger!");
                    Console.ReadLine();
                }
            }

            static void GameTitle()
            {
                Console.WriteLine("     Välkommen Till Spelet.");
                Console.WriteLine("     Tryck På Valfri Knapp:");
                Console.ReadLine();

            }

            static bool ParsingInt(int answer)
            {
                answer = int.Parse(Console.ReadLine());
                if (int.TryParse(Console.ReadLine(), out answer))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}