using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble2Joueurs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scrabble2Joueurs.Tests
{
    [TestClass()]
    public class JoueurTests
    {
        [TestMethod()]
        public void JoueurTest()
        {
            // Arrange & Act
            Joueur j = new Joueur("Testeur");

            // Assert
            Assert.IsNotNull(j.GetLesMots());
            Assert.AreEqual(0, j.GetTotalPoints());
            Assert.AreEqual(0, j.GetNbMots());
        }

        [TestMethod()]
        public void AjouterMotTest()
        {
            Joueur j1 = new Joueur("Moi");
            string mot = "UNITAIRE";

            j1.AjouterMot(mot);

            Assert.AreEqual(1, j1.GetNbMots());
            Assert.IsTrue(j1.GetLesMots().Contains(mot));
        }

        [TestMethod()]
        public void GetTotalPointsTest()
        {
            Joueur j1 = new Joueur("Bonsoir");

            j1.AjouterMot("ABC");
            j1.AjouterMot("DE");

            Assert.AreEqual(5, j1.GetTotalPoints());
        }

        [TestMethod()]
        public void GetNbMotsTest()
        {
            Joueur j1 = new Joueur("Bonjour");
            j1.AjouterMot("Un");
            j1.AjouterMot("Deux");
            int nb = j1.GetNbMots();
            Assert.AreEqual(2, nb);
        }

        [TestMethod()]
        public void GetLesMotsTest()
        {
            Joueur j1 = new Joueur("Aurevoir");
            j1.AjouterMot("Test");

            List<string> liste = j1.GetLesMots();

            Assert.IsInstanceOfType(liste, typeof(List<string>));
            Assert.AreEqual(1, liste.Count);
        }

        [TestMethod()]
        public void MotMeilleurTest()
        {
            Joueur j1 = new Joueur("Salut");
            j1.AjouterMot("Petit");
            j1.AjouterMot("Magnifique");
            j1.AjouterMot("Moyen");

            Assert.AreEqual("Magnifique", j1.MotMeilleur());
        }
    }
}