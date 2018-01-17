﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        public IActionResult Results(string searchType, string searchTerm)
        {
            ViewBag.jobs =  searchType != "all" ? JobData.FindByColumnAndValue(searchType, searchTerm)
                : JobData.FindByValue(searchTerm);
            ViewBag.columns = ListController.columnChoices;
            return View("Index");
        }

        // TODO #1 - Create a Results action method to process 
        // search request and display results

    }
}
