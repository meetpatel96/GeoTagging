using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GeoTagging.Models;

namespace GeoTagging.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly geonamesContext _context;

        public HomeController(ILogger<HomeController> logger, geonamesContext context)
        {
            _logger = logger;
            _context = context;
        }

        /// <summary>
        /// Dont't need to do anything here, since i'm dynamically loaing in the info using JSON and Javascript
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
           return View();
        }

        /// <summary>
        /// The MAIN method that does 85% of all the data handling and returing the correct Geoids based on the query result
        /// </summary>
        /// <param name="countryName"></param>
        /// <param name="stateName"></param>
        /// <param name="countyName"></param>
        /// <param name="locationName"></param>
        /// <returns></returns>
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult GetGeonameId(string countryName, string stateName, string countyName, string locationName)
        {
          

            string country = countryName;
            string state = stateName;
            string county = countyName;
            string location = locationName;

            // instantiate and declare an empty query first
            IQueryable<int> query = Enumerable.Empty<int>().AsQueryable();

            //Passing the correct values back into the View
            ViewData["Country"] = countryName;
            ViewData["State"] = stateName;
            ViewData["County"] = countyName;
            ViewData["Location"] = locationName;

            //All the if statements are checking which fields are empty and passing the Query based on the correct condition
            if (string.IsNullOrEmpty(country) != true && string.IsNullOrEmpty(state) != true && string.IsNullOrEmpty(county) != true && string.IsNullOrEmpty(location) != true)
            {
                query = from s in _context.Geoname
                        where s.Country == country & s.Admin1 == state & s.Admin2 == county & s.Name.ToLower() == location.ToLower()
                        select s.Geonameid;
                ViewData["GeoId"] = query;
                return View();
            }

            if (string.IsNullOrEmpty(state) == true && string.IsNullOrEmpty(county) == true)
            {
                query = from s in _context.Geoname
                        where s.Country == country & s.Name.ToLower() == location.ToLower()
                        select s.Geonameid;
                ViewData["GeoId"] = query;
                return View();
            }

            if (string.IsNullOrEmpty(state) == true)
            {
                query = from s in _context.Geoname
                        where s.Country == country & s.Admin2 == county & s.Name.ToLower() == location.ToLower()
                        select s.Geonameid;
                ViewData["GeoId"] = query;
                return View();
            }

            if (string.IsNullOrEmpty(county) == true)
            {
                query = from s in _context.Geoname
                        where s.Country == country & s.Admin1 == state & s.Name.ToLower() == location.ToLower()
                        select s.Geonameid;
                ViewData["GeoId"] = query;
                return View();
            }

            return View();
        }

        /// <summary>
        /// Retreiving all the countries from the database 
        /// </summary>
        /// <returns>All Country as JSON results</returns>
        public JsonResult GetCountryList()
        {
            var country = from s in _context.Country
                          select new { s.IsoCode, s.Name, s.Geonameid };

            return Json(country);
        }

        /// <summary>
        /// Retreiving all the States from the database based on the Country Geoid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>All States within the given country</returns>
        public JsonResult GetStatesList(string id)
        {
            var states = from s in _context.Admin1mapping
                         where s.Country == id
                         select new { s.Name, s.Admin1, s.Country, s.Geonameid };

            return Json(states);
        }

        /// <summary>
        /// Retreiving all the Countys from the database based on the State Geoid
        /// </summary>
        /// <param name="id"></param>
        /// <returns>All Countys within the give State</returns>
        public JsonResult GetCountyList(string id)
        {
            var county = from s in _context.Admin2mapping
                         where s.Admin1 == id
                         select new { s.Admin2name, s.Admin2, s.Admin1, s.Country, s.Geonameid };

            return Json(county);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
