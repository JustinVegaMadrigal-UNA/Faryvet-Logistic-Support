﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FaryvetLogisticSupport.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FaryvetLogisticSupport.Pages.Conductores
{
    public class IndexConductoresModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext ;

        public IndexConductoresModel (ApplicationDbContext dbContext)
        {
            _dbContext = dbContext ;
        }

        public IEnumerable <FARYVET_FLS_Conductor> FARYVET_FLS_Conductores { get; set; }
        
        public async Task OnGet ( )
        {
            FARYVET_FLS_Conductores = await _dbContext.FARYVET_FLS_Conductor.ToListAsync ( ) ;
        }

        public async Task<ActionResult> OnPostDelete(string NumeroIdentificacion)
        {
            var ConductorDB = await _dbContext.FARYVET_FLS_Conductor.FindAsync(NumeroIdentificacion);
            if(ConductorDB == null)
            {
                return NotFound();
            }

            _dbContext.FARYVET_FLS_Conductor.Remove(ConductorDB);
            await _dbContext.SaveChangesAsync();
            return RedirectToPage("IndexConductores");
        }
        public ActionResult GetList()
        {
            var conductores = _dbContext.FARYVET_FLS_Conductor.ToList();
            return new JsonResult(conductores);
        }
    }
}