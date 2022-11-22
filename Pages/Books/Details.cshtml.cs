using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cadar_Iuliana_Lab2.Data;
using Cadar_Iuliana_Lab2.Models;

namespace Cadar_Iuliana_Lab2.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Cadar_Iuliana_Lab2.Data.Cadar_Iuliana_Lab2Context _context;

        public DetailsModel(Cadar_Iuliana_Lab2.Data.Cadar_Iuliana_Lab2Context context)
        {
            _context = context;
        }

      public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);
            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }
    }
}
