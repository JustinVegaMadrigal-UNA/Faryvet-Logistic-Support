using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaryvetLogisticSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FaryvetLogisticSupport.Pages.VehiculosTransporte
{
    public class IndexVehiculosTransporteModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public IndexVehiculosTransporteModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<FARYVET_FLS_VehiculoTransporte> FARYVET_FLS_VehiculoTransporte { get; set; }

        public async Task OnGet()
        {
            FARYVET_FLS_VehiculoTransporte = await _dbContext.FARYVET_FLS_VehiculoTransporte.ToListAsync();
        }

        public async Task<ActionResult> OnPostDelete(string NumeroPlaca)
        {
            var VehiculoDB = await _dbContext.FARYVET_FLS_VehiculoTransporte.FindAsync(NumeroPlaca);
            if (VehiculoDB == null)
            {
                return NotFound();
            }

            _dbContext.FARYVET_FLS_VehiculoTransporte.Remove(VehiculoDB);
            await _dbContext.SaveChangesAsync();
            return RedirectToPage("IndexVehiculosTransporte");
        }

        public ActionResult GetList()
        {
            var vehiculos = _dbContext.FARYVET_FLS_VehiculoTransporte.ToList();
            return new JsonResult(vehiculos);
        }
    }
}