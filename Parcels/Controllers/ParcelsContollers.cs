using Microsoft.AspNetCore.Mvc;
using Parcels.Models;
// using System.Collections.Generic;

namespace Parcels.Controllers
{
  public class ParcelsController : Controller
  {

    // [HttpGet("/parcels")]
    // public ActionResult Index()
    // {
    //   List<Parcel> myGarage = Parcel.GetAll();
    //   return View(myGarage);
    // }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int width, int length, int height, int weight)
    {
      Parcel myParcel = new Parcel(width, length, height, weight);
      return RedirectToAction("Index");
    }
  }
}