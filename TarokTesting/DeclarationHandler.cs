using System;
using System.Collections.Generic;
using System.Text;

namespace TarokScoreTesting
{
    public static class DeclarationHandler
    {
        
        #region Methods
        public static void TenOrMoreTaroks(List<Player> theList, Player activePlayer)
        {
            int extraCards;

            extraCards = GameScreen.ExtraCards(10);
            int result = 10 + (extraCards * 5);
            foreach (var player in theList)
            {
                //IF IT LOOKS STUPID, BUT IT WORKS, IT AINTS STUPID!
                player.Cup -= result;
                activePlayer.Cup += result;
            }
            
        }
        public static void ThreeOrMoreMatadors(List<Player> theList, Player activePlayer)
        {
            int extraCards;

            extraCards = GameScreen.ExtraCards(3);
            int result = 10 + (extraCards * 5);
            foreach (var player in theList)
            {
                //IF IT LOOKS STUPID, BUT IT WORKS, IT AINT STUPID!
                player.Cup -= result;
                activePlayer.Cup += result;
            }
        }

        public static void MasterMethod(List<Player> theList, Player activePlayer, int type)
        {
            //Half Kings + Half cavalry = 5
            //Four Kings + Full cavalry = 10
            //Overfull Kings + Overfull cavalry = 15
            
            int BasePoints = 5;
            int result = type * BasePoints;
            foreach (var player in theList)
            {
                //IF IT LOOKS STUPID, BUT IT WORKS, IT AINT STUPID!
                player.Cup -= result;
                activePlayer.Cup += result;
            }
        }

        
        #endregion
    }
}
