using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cadar_Iuliana_Lab2.Data;
using Cadar_Iuliana_Lab2.Models;

namespace Cadar_Iuliana_Lab2.Pages.Categories
{
    public class CreateModel : PageModel
    {
        private readonly Cadar_Iuliana_Lab2.Data.Cadar_Iuliana_Lab2Context _context;

        public CreateModel(Cadar_Iuliana_Lab2.Data.Cadar_Iuliana_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
