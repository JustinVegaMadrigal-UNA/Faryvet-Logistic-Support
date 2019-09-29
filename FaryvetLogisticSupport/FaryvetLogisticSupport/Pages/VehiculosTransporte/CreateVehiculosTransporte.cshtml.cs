using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaryvetLogisticSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FaryvetLogisticSupport.Pages.VehiculosTransporte
{
    public class CreateVehiculosTransporteModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public CreateVehiculosTransporteModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [BindProperty]
        public FARYVET_FLS_VehiculoTransporte FARYVET_FLS_VehiculoTransporte { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _dbContext.Add(FARYVET_FLS_VehiculoTransporte);
            await _dbContext.SaveChangesAsync();
            return RedirectToPage("../Index");
        }
    }
}