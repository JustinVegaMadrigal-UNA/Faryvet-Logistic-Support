﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaryvetLogisticSupport.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (DbContextOptions <ApplicationDbContext> options): base (options)
        {

        }
    }
}
