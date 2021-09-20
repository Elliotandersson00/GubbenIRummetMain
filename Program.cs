﻿using System;
using System.Reflection.Metadata.Ecma335;

namespace GubbenIRummet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int answersFalse = 0;
            int answer;
            bool gameOver = false;
            GameTitle();
            while (!gameOver)
            {
                Question question1 = new Question("Vad heter världen mest använda sökmotor?\n 1 = Google\n 2 = Bing\n 3 = Edge", 1);
                Console.WriteLine(question1.Questions);
                answer = int.Parse(Console.ReadLine());
                if (question1.CheckAnswer(answer) != true)
                {
                    Console.WriteLine("Fel svar, försök igen!");
                    answersFalse++;
                    continue;
                }
                Console.WriteLine("Rätt! Nästa fråga:");

                Question question2 = new Question("I datatyperna Float och Double kan du lagra??\n 1 = Endast heltal, Double kan lagra dubbelt så stora heltal som float\n 2 = Decimaltal\n 3 = Teckensträngar, Double kan lagra två strängar", 2);
                Console.WriteLine(question2.Questions);
                answer = int.Parse(Console.ReadLine());
                if (question2.CheckAnswer(answer) != true)
                {
                    Console.WriteLine("Fel svar, försök igen!");
                    answersFalse++;
                    continue;
                }
                Console.WriteLine("Rätt! Nästa fråga:");
                Question question3 = new Question("Hur många binära siffror innehåller en klassisk IP-adress??\n 1 = 16\n 2 = 64\n 3 = 32", 3);
                Console.WriteLine(question3.Questions);
                answer = int.Parse(Console.ReadLine());
                if (question3.CheckAnswer(answer) != true)
                {
                    Console.WriteLine("Fel svar, försök igen!");
                    answersFalse++;
                    continue;
                }
                Console.WriteLine("Rätt! Nästa fråga:");
                Question question4 = new Question("Vad är källkod?\n 1 = Kod till källardörren\n 2 = Den kod du skriver i t.ex Visual studio\n 3 = Ett slags hemligt tecken som endast de 'riktiga' programmerarna känner till. Tidigare arbetade programmerare ofta på källarvåningen därav uttrycket källkod", 2);
                Console.WriteLine(question4.Questions);
                answer = int.Parse(Console.ReadLine());
                if (question4.CheckAnswer(answer) != true)
                {
                    Console.WriteLine("Fel svar, försök igen!");
                    answersFalse++;
                    continue;
                }
                Console.WriteLine("Rätt! Nästa fråga:");
                Question question5 = new Question("Vad menas med kompilering?\n 1 = Omvandling från ett programspråk till maskinkod\n 2 = Ett sätt att komprimera program\n 3 = När du ger en variabel ett nytt värde görs en kompilering", 1);
                Console.WriteLine(question5.Questions);
                answer = int.Parse(Console.ReadLine());
                if (question5.CheckAnswer(answer) != true)
                {
                    Console.WriteLine("Fel svar, försök igen!");
                    answersFalse++;
                    continue;
                }

                // Lägg in fler frågor här.

                Console.WriteLine($"Grattis! Du svarade bara fel {answersFalse} gånger!");
                Console.ReadLine();
            }

            static void GameTitle()
            {
                Console.WriteLine("Välkommen Till Spelet.");
                Console.WriteLine("Tryck På Valfri Knapp:");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}