using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TarokScoreTesting
{
    public class Gameloop
    {

        #region InstanceFields
        List<Player> _players;
        #endregion

        #region Loop
        public void Loop()
        {
            
            while (true)
            {
                bool GameOn = true;

                _players = GameScreen.CreatePlayers();
                
                while (GameOn)
                {
                    int stop = 0;
                    //The thing that happens
                    GameScreen.TheScreen(_players);
                    //new game = break;
                    string key = Console.ReadKey().KeyChar.ToString();
                    if (key == "1")
                    {
                        //"1: Ten or more Taroks /n" +
                        //"2: Three or Matadors/n" +
                       //"3: Four Kings /n" +
                       //"4: Half in Kings /n" +
                       //"5: Full Cavalry /n" +
                       //"6: Half Cavalry /n" +
                       //"7: Overfull Cavalry /n" +
                       //"8: Overfull in Kings"
                        Player pl = GameScreen.ChoosePlayer(_players);

                        int choice = GameScreen.ChooseDeclaration();
                        if(choice == 1)
                        { DeclarationHandler.TenOrMoreTaroks(_players, pl); }
                        if (choice == 2)
                        { DeclarationHandler.ThreeOrMoreMatadors(_players, pl); }
                        if (choice == 3 || choice == 5)
                        { DeclarationHandler.MasterMethod(_players, pl, 2); }
                        if (choice == 4 || choice == 6)
                        { DeclarationHandler.MasterMethod(_players, pl, 1); }
                        if (choice == 7 || choice == 8)
                        { DeclarationHandler.MasterMethod(_players, pl, 3); }

                    }
                    if (key == "2")
                    {
                        GameOn = false;
                        Console.WriteLine();
                    }

                    
                }

                

            }

        }
        #endregion
        #region Methods
        
        #endregion
    }
}
