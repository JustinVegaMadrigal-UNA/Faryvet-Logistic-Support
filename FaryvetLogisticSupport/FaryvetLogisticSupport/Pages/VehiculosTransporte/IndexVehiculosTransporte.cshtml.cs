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
    }
}