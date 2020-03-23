using Microsoft.AspNetCore.Mvc;
using DoctorsOffice.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace DoctorsOffice.Controllers
{
  public class SpecialtysController : Controller
  {
    private readonly DoctorsOfficeContext _db;

    public SpecialtysController(DoctorsOfficeContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Specialty.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Specialty specialty)
    {
      _db.Specialty.Add(specialty);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}