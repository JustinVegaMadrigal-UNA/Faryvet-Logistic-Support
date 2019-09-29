using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaryvetLogisticSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FaryvetLogisticSupport.Pages.Conductores
{
    public class CreateConductoresModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext ;
        public CreateConductoresModel (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ;
        }
        [BindProperty]
        public FARYVET_FLS_Conductor FARYVET_FLS_Conductor { get; set; }
        public void OnGet()
        {

        }

        public async Task <IActionResult> OnPost ( )
        {
            if (!ModelState.IsValid)
            {
                return Page ( ) ;
            }
            _dbContext.Add ( FARYVET_FLS_Conductor) ;
            await _dbContext.SaveChangesAsync ( ) ;
            return RedirectToPage ("../Index") ;
        }
    }
}