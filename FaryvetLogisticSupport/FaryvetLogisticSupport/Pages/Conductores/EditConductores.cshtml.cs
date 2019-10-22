using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaryvetLogisticSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FaryvetLogisticSupport.Pages.Conductores
{
    public class EditConductoresModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext ;

        public EditConductoresModel (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ;
        }

        [BindProperty]
        public FARYVET_FLS_Conductor FARYVET_FLS_Conductor { get; set; }

        public async Task OnGet(String NumeroIdentificacion)
        {
            FARYVET_FLS_Conductor = await _dbContext.FARYVET_FLS_Conductor.FindAsync(NumeroIdentificacion) ;
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var ConductorDB = await _dbContext.FARYVET_FLS_Conductor.FindAsync(FARYVET_FLS_Conductor.NumeroIdentificacion);
                ConductorDB.Nombre = FARYVET_FLS_Conductor.Nombre;
                ConductorDB.PrimerApellido = FARYVET_FLS_Conductor.PrimerApellido;
                ConductorDB.SegundoApellido = FARYVET_FLS_Conductor.SegundoApellido;
                ConductorDB.FechaContratacion = FARYVET_FLS_Conductor.FechaContratacion;
                ConductorDB.Estado = FARYVET_FLS_Conductor.Estado;


                await _dbContext.SaveChangesAsync();
                return RedirectToPage("../Index");
            }
            return RedirectToPage();
        }
    }
}