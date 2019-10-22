using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaryvetLogisticSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FaryvetLogisticSupport.Pages.VehiculosTransporte
{
    public class EditVehiculoTransporteModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;

        public EditVehiculoTransporteModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public FARYVET_FLS_VehiculoTransporte FARYVET_FLS_VehiculoTransporte { get; set; }

        public async Task OnGet(String NumeroPlaca)
        {
            FARYVET_FLS_VehiculoTransporte = await _dbContext.FARYVET_FLS_VehiculoTransporte.FindAsync(NumeroPlaca);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var VehiculoDB = await _dbContext.FARYVET_FLS_VehiculoTransporte.FindAsync(FARYVET_FLS_VehiculoTransporte.NumeroPlaca);
                VehiculoDB.Marca = FARYVET_FLS_VehiculoTransporte.Marca;
                VehiculoDB.Modelo = FARYVET_FLS_VehiculoTransporte.Modelo;
                VehiculoDB.AnnioFabricacion = FARYVET_FLS_VehiculoTransporte.AnnioFabricacion;
                VehiculoDB.CapacidadCarga = FARYVET_FLS_VehiculoTransporte.CapacidadCarga;
                VehiculoDB.CapacidadCombustible = FARYVET_FLS_VehiculoTransporte.CapacidadCombustible;
                VehiculoDB.FechaRiteve = FARYVET_FLS_VehiculoTransporte.FechaRiteve;
                VehiculoDB.CostoMarchamo = FARYVET_FLS_VehiculoTransporte.CostoMarchamo;
                VehiculoDB.CVOSenasa = FARYVET_FLS_VehiculoTransporte.CVOSenasa;
                VehiculoDB.Estado = FARYVET_FLS_VehiculoTransporte.Estado;
                VehiculoDB.Comentario = FARYVET_FLS_VehiculoTransporte.Comentario;
                VehiculoDB.LicenciaRequerida = FARYVET_FLS_VehiculoTransporte.LicenciaRequerida;

                await _dbContext.SaveChangesAsync();
                return RedirectToPage("../Index");
            }
            return RedirectToPage();
        }
    }
}