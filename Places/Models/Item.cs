using System.Collections.Generic;

namespace Places.Models
{
    public class PlacesInput
    {
        public string PlaceName { get; set; }
        public string LongT { get; set; }
        public string Lat { get; set; }
        public string Season { get; set; }
        public string JournalEntry { get; set; }
        public int Id { get; }
        private static List<PlacesInput> _placesList = new List<PlacesInput> {};

        public PlacesInput(string placeName, string longT, string lat, string season, string journalEntry)
        {
            PlaceName = placeName;
            LongT = longT;
            Lat = lat;
            Season = season;
            JournalEntry = journalEntry;
            _placesList.Add(this);
            Id = _placesList.Count;                      

        }
        public static List<PlacesInput> GetAll()
        {
            return _placesList;
        }
        public static void ClearAll()
        {
            _placesList.Clear();
        }

        public static PlacesInput Show(int searchID)
        {
            return _placesList[searchID - 1];
        }
    }
}