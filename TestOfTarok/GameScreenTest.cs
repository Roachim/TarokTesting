using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TarokScoreTesting;

namespace TestOfTarok
{
    [TestClass]
    public class GameScreenTest
    {


        [TestMethod]
        public void CreatePlayers_Successful_ListOfPlayers()
        {
            //Arrange

            List<Player> players;
            int expectedNumberOfPlayers = 3;

            //Act

            players = GameScreen.CreatePlayers();

            //Assert
            Assert.AreEqual(expectedNumberOfPlayers, players.Count);


        }



    }
}
