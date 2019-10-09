
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System;
using System.Linq;
using System.Collections.Generic;


namespace Places.Tests
{
    [TestClass]
    public class PlacesTest
    {
        PlacesInput newPlaces;
        string name;
        string longT;
        string lat;
        string season;
        string journal;

        [TestInitialize]
        public void Setup()
        {
            name = "Aruba";
            longT = "12.5211";
            lat = "69.9683";
            season = "summer";
            journal = "This was AWESOME";
            newPlaces = new PlacesInput(name,longT,lat,season,journal);
        }
        [TestCleanup]
        public void TearDown()
        {
            newPlaces = null;
            PlacesInput.ClearAll();
        }
        [TestMethod]
        public void Constructor_TestsTheConstructor_PlacesInput()
        {
            Assert.AreEqual(newPlaces.GetType(),typeof(PlacesInput));
        }

        [TestMethod]
        public void GetPlaces_ReturnPlaces_ItemList()
        {

            List<PlacesInput> result = PlacesInput.GetAll();
            foreach(PlacesInput i in result)
            {
                Console.WriteLine(i.PlaceName);
            }

            List<PlacesInput> newList = new List<PlacesInput>{newPlaces};
           CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetID_WeShouldBeAbleToGetTheID_Int()
        {
            int result = newPlaces.Id;
            Assert.AreEqual(1, result);
        }
        
    }
}