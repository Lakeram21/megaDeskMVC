using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk.Model;

namespace MegaDesk.Pages_DeskQuote
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskContext _context;

        public CreateModel(MegaDeskContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DeliveryId"] = new SelectList(_context.Set<Delivery>(), "DeliveryId", "DeliveryName");
        ViewData["DesktopMaterialId"] = new SelectList(_context.Set<DesktopMaterial>(), "DesktopMaterialId", "DesktopMaterialName");
            return Page();
        }

        [BindProperty]
        public Desk Desk { get; set; }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
        //   if (!ModelState.IsValid)
        //     {
        //         return Page();
        //     }

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            DeskQuote.DeskId = Desk.DeskId;
            
            DeskQuote.Desk = Desk;
            DeskQuote.QuoteDate = DateTime.Now;
            DeskQuote.QuotePrice = 1900;
            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
