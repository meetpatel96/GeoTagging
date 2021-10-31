using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GeoTagging.Models;

namespace GeoTagging.Controllers
{
    public class GeonamesController : Controller
    {
        private readonly geonamesContext _context;

        public GeonamesController(geonamesContext context)
        {
            _context = context;
        }

        // GET: Geonames
        public async Task<IActionResult> Index()
        {
            return View(await _context.Geoname.ToListAsync());
        }

        // GET: Geonames/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geoname = await _context.Geoname
                .FirstOrDefaultAsync(m => m.Geonameid == id);
            if (geoname == null)
            {
                return NotFound();
            }

            return View(geoname);
        }

        // GET: Geonames/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Geonames/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Geonameid,Name,Asciiname,Alternatenames,Latitude,Longitude,Fclass,Fcode,Country,Admin1,Admin2,Admin3,Admin4,Population,Admin1Geonameid,Admin2Geonameid,CountryGeonameid")] Geoname geoname)
        {
            if (ModelState.IsValid)
            {
                _context.Add(geoname);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(geoname);
        }

        // GET: Geonames/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geoname = await _context.Geoname.FindAsync(id);
            if (geoname == null)
            {
                return NotFound();
            }
            return View(geoname);
        }

        // POST: Geonames/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Geonameid,Name,Asciiname,Alternatenames,Latitude,Longitude,Fclass,Fcode,Country,Admin1,Admin2,Admin3,Admin4,Population,Admin1Geonameid,Admin2Geonameid,CountryGeonameid")] Geoname geoname)
        {
            if (id != geoname.Geonameid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(geoname);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeonameExists(geoname.Geonameid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(geoname);
        }

        // GET: Geonames/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var geoname = await _context.Geoname
                .FirstOrDefaultAsync(m => m.Geonameid == id);
            if (geoname == null)
            {
                return NotFound();
            }

            return View(geoname);
        }

        // POST: Geonames/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var geoname = await _context.Geoname.FindAsync(id);
            _context.Geoname.Remove(geoname);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeonameExists(int id)
        {
            return _context.Geoname.Any(e => e.Geonameid == id);
        }
    }
}
