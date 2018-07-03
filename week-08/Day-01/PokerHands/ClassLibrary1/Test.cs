using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokerHandsApp;

namespace PokerHandsTest
{
    [TestFixture]
    public class Test
    {

        Poker poker = new Poker();

        [Test]
        public void CheckIfSplitInputIs12()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            bool output = poker.CheckInputLength12(input);
            Assert.AreEqual(true, output);
        }

        [Test]
        public void GetHandOfWhitePlayer()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            List<string> output = poker.GetHandOfWhitePlayer(input);
            Assert.AreEqual(new List<string> { "2C", "3H", "4S", "8C", "AH" }, output);
        }

        [Test]
        public void GetHandOfBlackPlayer()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            List<string> output = poker.GetHandOfBlackPlayer(input);
            Assert.AreEqual(new List<string> { "2H", "3D", "5S", "9C", "KD" }, output);
        }

        [Test]
        public void GetValueOfCardWithNumber_5()
        {
            string input = "5D";
            int output = poker.GetValue(input);
            Assert.AreEqual(5,output);
        }

        [Test]
        public void GetValueOfCardWithFigure_K()
        {
            string input = "KD";
            int output = poker.GetValue(input);
            Assert.AreEqual(13, output);
        }

        [Test]
        public void GetHandValuesOfPlayer_OnlyNumbers()
        {
            List<string> input = new List<string>() { "2H", "3D", "5S", "9C", "8D" };
            List<int> output = poker.GetHandValues(input);
            Assert.AreEqual(new List<int> { 2, 3, 5, 9, 8 }, output);
        }

        [Test]
        public void GetHandValuesOfPlayer_NumbAndFigures()
        {
            List<string> input = new List<string>() { "2H", "TD", "5S", "KC", "8D" };
            List<int> output = poker.GetHandValues(input);
            Assert.AreEqual(new List<int> { 2, 10, 5, 13, 8 }, output);
        }
    }
}
