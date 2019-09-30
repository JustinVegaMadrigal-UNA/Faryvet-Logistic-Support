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

        public async Task OnGet(String numeroCedula)
        {
            Console.WriteLine(numeroCedula);
            FARYVET_FLS_Conductor = await _dbContext.FARYVET_FLS_Conductor.FindAsync(numeroCedula) ;
        }
    }
}