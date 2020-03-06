using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StaticPageBigData.Models;

namespace StaticPageBigData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        // GET: UrlModels
        public async Task<IActionResult> Index()
        {
            MainPageModel page = new MainPageModel();
            page.UrlModels = await _context.UrlModels.ToListAsync();
            return View(page);
        }

        // GET: UrlModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urlModel = await _context.UrlModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urlModel == null)
            {
                return NotFound();
            }

            return View(urlModel);
        }

        // GET: UrlModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UrlModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Url")] UrlModel urlModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(urlModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(urlModel);
        }

        // GET: UrlModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urlModel = await _context.UrlModels.FindAsync(id);
            if (urlModel == null)
            {
                return NotFound();
            }
            return View(urlModel);
        }

        // POST: UrlModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Url")] UrlModel urlModel)
        {
            if (id != urlModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(urlModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UrlModelExists(urlModel.Id))
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
            return View(urlModel);
        }

        // GET: UrlModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var urlModel = await _context.UrlModels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urlModel == null)
            {
                return NotFound();
            }
            
            return View(urlModel);
        }

        // POST: UrlModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var urlModel = await _context.UrlModels.FindAsync(id);
            _context.UrlModels.Remove(urlModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UrlModelExists(int id)
        {
            return _context.UrlModels.Any(e => e.Id == id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
