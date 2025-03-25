using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers

{
public class FirstController(string? id) : Controller
{
        private readonly string? id = id;

        public string? Name { get; private set; }
        public string? Class { get; private set; }
        public string? MSV { get; private set; }

        public IActionResult Create()
    { 
       return View();
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Create(FirstController std)
    {
        ViewBag.first = "Id:" + std.id + "Name" + std.Name + "Class" + std.Class + "MSV" + std.MSV;
        return View();
    }
}
}