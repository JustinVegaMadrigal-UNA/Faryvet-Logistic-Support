using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaryvetLogisticSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FaryvetLogisticSupport.Pages.Facturas
{
    public class FacturasEspecialesModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public FacturasEspecialesModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Factura> Facturas { get; set; }

        public async Task OnGet()
        {
            Facturas = await _dbContext.FLS_Facturas.ToListAsync();
        }

        public async Task<ActionResult> OnPostDelete(string id)
        {
            var FacturaDB = await _dbContext.FLS_Facturas.FindAsync(id);
            if (FacturaDB == null)
            {
                return NotFound();
            }

            _dbContext.FLS_Facturas.Remove(FacturaDB);
            await _dbContext.SaveChangesAsync();
            return RedirectToPage("FacturasEspeciales");
        }

        public ActionResult GetList()
        {
            var facturas = _dbContext.FLS_Facturas.ToList();
            return new JsonResult(facturas);
        }
    }
}