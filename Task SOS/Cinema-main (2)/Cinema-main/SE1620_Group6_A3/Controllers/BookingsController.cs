using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SE1620_Group6_A3.Models;

namespace SE1620_Group6_A3.Controllers
{
    public class BookingsController : Controller
    {
        private readonly CinemaContext _context;

        public BookingsController(CinemaContext context)
        {
            _context = context;
        }

        // GET: Bookings
        public async Task<IActionResult> Index(int? id)
        {
            var cinemaContext = _context.Bookings.Where(b => b.ShowId == id);
            HttpContext.Session.SetInt32("id", (int)id);
            List<Booking> list = await cinemaContext.ToListAsync();
            ViewBag.listBook = list;
            List<int> ints = new List<int>();
            foreach (Booking booking in list)
            {
                for(int i = 0; i < booking.SeatStatus.Length; i++)
                {
                    if (booking.SeatStatus[i].ToString().Equals("1"))
                    {
                        ints.Add(i);
                    }
                }
            }
            ViewBag.id = id;
            ViewBag.list = ints;
            return View(await cinemaContext.ToListAsync());
        }

        // GET: Bookings/Details/5
        // GET: Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Booking book = _context.Bookings.Find(id);
            ViewBag.Name = book.Name;
            ViewBag.Amount = book.Amount;
            List<int> list = new List<int>();
            ViewBag.SeatStatus = book.SeatStatus;
            return View(book);
        }

        // GET: Bookings/Create
        public async Task<IActionResult> Create()
        {
            int id = (int)HttpContext.Session.GetInt32("id");
            var cinemaContext = _context.Bookings.Where(b => b.ShowId == id);
            List<Booking> list = await cinemaContext.ToListAsync();
            List<int> ints = new List<int>();
            foreach (Booking booking in list)
            {
                for (int i = 0; i < booking.SeatStatus.Length; i++)
                {
                    if (booking.SeatStatus[i].ToString().Equals("1"))
                    {
                        ints.Add(i);
                    }
                }
            }
            int[] check = new int[0];
            ViewBag.check = check;
            ViewBag.id = id;
            ViewBag.list = ints;
            HttpContext.Session.SetInt32("Amount", 0);
            HttpContext.Session.SetString("index", "");

            return View();
        }

        // POST: Bookings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookingId,ShowId,Name,SeatStatus,Amount")] Booking booking, int? test, int[]? check, String name, String Seat)
        {
            int id = (int)HttpContext.Session.GetInt32("id");
            var cinemaContext = _context.Bookings.Where(b => b.ShowId == id);
            List<Booking> list = await cinemaContext.ToListAsync();
            List<int> ints = new List<int>();
            int Amount = (int)HttpContext.Session.GetInt32("Amount");
            HttpContext.Session.SetInt32("Amount", check.Length*10);
            foreach (Booking book in list)
            {
                for (int i = 0; i < book.SeatStatus.Length; i++)
                {
                    if (book.SeatStatus[i].ToString().Equals("1"))
                    {
                        ints.Add(i);
                    }
                }
            }
            String SeatStatus = "";
            for(int i = 0; i < 100; i++)
            {
                int c = 0;
                for(int j = 0; j < check.Length; j++)
                {
                    if(i == check[j])
                    {
                        c = 1;
                    }
                }
                if (c == 0)
                {
                    SeatStatus += "0";
                }
                else
                {
                    SeatStatus += "1";
                }
            }
            HttpContext.Session.SetString("index", SeatStatus);
            ViewBag.check = check;
            ViewBag.id = id;
            ViewBag.list = ints;
            
            if (ModelState.IsValid && test == 1)
            {
                Booking book1 = new Booking();
                book1.SeatStatus = Seat;
                book1.ShowId = id;
                book1.Amount = Amount;
                book1.Name = name;
                _context.Add(book1);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new {id = id});
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", booking.ShowId);
            return View(booking);
        }



        // GET: Bookings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            int showid = (int)HttpContext.Session.GetInt32("id");
            Booking book = _context.Bookings.Find(id);
            var cinemaContext = _context.Bookings.Where(b => b.ShowId == showid && b.BookingId != id);
            List<Booking> list = await cinemaContext.ToListAsync();
            List<int> ints = new List<int>();
            HttpContext.Session.SetString("name", book.Name);
            ViewBag.id = id;
            int[] check = new int[10];
            int k = 0;
            for (int i = 0; i < book.SeatStatus.Length; i++)
            {
                if (book.SeatStatus[i].ToString().Equals("1"))
                {
                    check[k] = i;
                    k++;
                }
            }

            for (int i = k; i < check.Length; i++)
            {
                check[i] = -1;
            }
            ViewBag.check = check;
            HttpContext.Session.SetInt32("Amount", k * 10);
            foreach (Booking book1 in list)
            {
                for (int i = 0; i < book1.SeatStatus.Length; i++)
                {
                    if (book1.SeatStatus[i].ToString().Equals("1"))
                    {
                        ints.Add(i);
                    }
                }
            }
            
            ViewBag.list = ints;
            if (book == null)
            {
                return NotFound();
            }
            ViewData["ShowId"] = new SelectList(_context.Shows, "ShowId", "ShowId", book.ShowId);
            return View();
        }

        // POST: Bookings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BookingId,ShowId,Name,SeatStatus,Amount")] Booking booking, int? test, int[]? check, String name, String Seat)
        {

            int showId = (int)HttpContext.Session.GetInt32("id");
            var cinemaContext = _context.Bookings.Where(b => b.ShowId == showId && b.BookingId != id);
            List<Booking> list = await cinemaContext.ToListAsync();
            List<int> ints = new List<int>();
            int Amount = (int)HttpContext.Session.GetInt32("Amount");
            HttpContext.Session.SetInt32("Amount", check.Length * 10);
            foreach (Booking book in list)
            {
                for (int i = 0; i < book.SeatStatus.Length; i++)
                {
                    if (book.SeatStatus[i].ToString().Equals("1"))
                    {
                        ints.Add(i);
                    }
                }
            }
            String SeatStatus = "";
            for (int i = 0; i < 100; i++)
            {
                int c = 0;
                for (int j = 0; j < check.Length; j++)
                {
                    if (i == check[j])
                    {
                        c = 1;
                    }
                }
                if (c == 0)
                {
                    SeatStatus += "0";
                }
                else
                {
                    SeatStatus += "1";
                }
            }
            HttpContext.Session.SetString("index", SeatStatus);
            ViewBag.check = check;
            ViewBag.id = id;
            ViewBag.list = ints;

            if (ModelState.IsValid && test == 1)
            {
                try
                {
                    booking.BookingId = id;
                    booking.ShowId = showId;
                    booking.SeatStatus = Seat;
                    booking.Amount = Amount;
                    booking.Name = name;
                    _context.Update(booking);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookingExists(booking.BookingId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new { id = showId });
            }
            return View();
        }

        // GET: Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Booking book = _context.Bookings.Find(id);
            ViewBag.Name = book.Name;
            ViewBag.Amount = book.Amount;
            List<int> list = new List<int>();
            ViewBag.SeatStatus = book.SeatStatus;
            
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            int showId = (int)HttpContext.Session.GetInt32("id");
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { id = showId });
        }

        private bool BookingExists(int id)
        {
            return _context.Bookings.Any(e => e.BookingId == id);
        }
    }
}
