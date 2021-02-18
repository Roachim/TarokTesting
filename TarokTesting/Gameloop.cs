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
                    GameScreen.TheScreen(_players);
                    string key = Console.ReadKey().KeyChar.ToString();
                    if (key == "1")
                    {
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
