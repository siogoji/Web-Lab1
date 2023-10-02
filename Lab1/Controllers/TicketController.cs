using Lab1.Data;
using Lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class TicketController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TicketController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Booking()
        {
            // Створіть ViewModel і передайте його в представлення для відображення форми
            var viewModel = new Ticket();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Booking(Ticket viewModel)
        {
            if (ModelState.IsValid)
            {
                // Створіть новий об'єкт Ticket на основі даних з ViewModel
                var ticket = new Ticket
                {
                    PassengerName = viewModel.PassengerName,
                    DepartureCity = viewModel.DepartureCity,
                    ArrivalCity = viewModel.ArrivalCity,
                    // Інші дані про квиток, які вам потрібні
                };

                // Додайте квиток до бази даних
                _context.Tickets.Add(ticket);
                _context.SaveChanges();

                if (!string.IsNullOrEmpty(viewModel.PassengerName))
                {
                    // Додайте повідомлення в ViewData, тільки якщо PassengerName не порожнє
                    ViewData["SuccessMessage"] = $"Дякуємо, {viewModel.PassengerName}, за бронювання!";
                }

                // Поверніть користувача на головну сторінку або іншу сторінку після бронювання
                return View("Booking", viewModel);
            }

            // Якщо ModelState не є дійсним, поверніть користувача назад до форми з помилками
            return View(viewModel);
        }
    }
}
