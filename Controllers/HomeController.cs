﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC101.Models;

namespace MVC101.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
        ViewData["days"] = days;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Bogus()
    {
        string[] days = {"Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun"};
        // ViewData["days"] = days;
        ViewData["author"] = "sam";
        ViewBag.Date = DateTime.Now;
        return View(days);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
