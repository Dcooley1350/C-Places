using Microsoft.AspNetCore.Mvc;
using Places.Models;
using System.Collections.Generic;

namespace Places.Controllers
{
 public class ItemsController : Controller
 {
   [HttpGet("/places")]
   public ActionResult Index()
   {
       List<PlacesInput> newPlaces = PlacesInput.GetAll();
       return View(newPlaces);
   }

    [HttpGet ("/places/new")]
    public ActionResult New()
    {
        return View();
    }

    [HttpPost ("/places")]
    public ActionResult Create(string place, string longt, string lat, string season)
    {
        PlacesInput newPlaces = new PlacesInput(place, longt, lat, season);
        return RedirectToAction("Index");
    }

    [HttpPost ("/places/delete")]
    public ActionResult DeleteAll()
    {
        PlacesInput.ClearAll();
        return View();
    }

 } 

}