using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace TarokScoreTesting
{
    public static class GameScreen
    {
        public static void TheScreen(List<Player> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Score for {player.Name} = {player.Cup}");

            }
            Console.WriteLine("Update? press 1. \n");
            Console.WriteLine("Restart? press 2. \n");

            
        }

        public static int ExtraCards(int mimimum)
        {
            int extraCards = 0;
            bool success = false;
            Console.WriteLine("Any extra cards above minimum\n");
            Console.WriteLine("Write 0 for none. \n");
            while (!success)
            {
                success = Int32.TryParse(Console.ReadLine(), out extraCards);
                if (!success)
                {
                    Console.WriteLine("Invalid. Please input a number. \n");
                    Console.WriteLine("example: 1, 3, 6, 8. As a standalone number.");

                }
                if (mimimum + extraCards > 22)
                {
                    Console.WriteLine($"Invalid number. Too many cards. Your total was {mimimum + extraCards}.");
                    success = false;
                }
            }


            return extraCards;
        }
        public static List<Player> CreatePlayers()
        {

            List<Player> players = new List<Player>();
            int i = 1;

            while (players.Count < 3)
            {

                //Console.Write($"Please write Player {i} Name \n"); Console.ReadLine()
                Player player = new Player("Player 1");
                players.Add(player);
                i++;
                var mockPlayer2 = new Mock<Player>();
                mockPlayer2.SetupProperty(p => p.Cup, 0);
                mockPlayer2.SetupProperty(p => p.Name, "Player 2");
                players.Add(mockPlayer2.Object);
                i++;
                var mockPlayer3 = new Mock<Player>();
                mockPlayer3.SetupProperty(p => p.Cup, 0);
                mockPlayer3.SetupProperty(p => p.Name, "Player 3");
                players.Add(mockPlayer3.Object);
                i++;
            }
            return players;
        }
        public static Player ChoosePlayer(List<Player> players)
        {
            Player returnPlayer;
            Console.WriteLine("\nWho makes a declaration? Please input number\n");
            int i = 1;
            foreach (var player in players)
            {
                
                Console.WriteLine(i+". " + player.Name+ ". \n");
                i++;
            }

            string key = Console.ReadKey().KeyChar.ToString();

            while (true)
            {
                if (key == "1")
                {
                    return players[0];
                }
                if(key == "2")
                {
                    return players[1];
                }
                if (key == "3")
                {
                    return players[2];
                }
            }
           

        }
        public static int ChooseDeclaration()
        {
            bool success = false;
            int result = 0;
            Console.WriteLine("\nChoose declaration: \n");

            Console.WriteLine(
                "1: Ten or more Taroks \n" +
                "2: Three or Matadors\n" +
                "3: Four Kings \n" +
                "4: Half in Kings \n" +
                "5: Full Cavalry \n" +
                "6: Half Cavalry \n" +
                "7: Overfull Cavalry \n" +
                "8: Overfull in Kings\n"
                );
            
            while (!success)
            {
                success = Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out result);
                if (!success)
                {
                    Console.WriteLine("\nInvalid. Please input a valid number. \n");

                }
                if (result > 8 || result < 1)
                {
                    Console.WriteLine("\nInvalid number.\n");
                    success = false;
                }
                
            }
            return result;

        }
    }
}
