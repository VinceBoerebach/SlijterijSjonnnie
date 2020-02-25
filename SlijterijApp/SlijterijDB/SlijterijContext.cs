using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SlijterijApp.Models;

namespace SlijterijApp.SlijterijDB
{
    public class SlijterijContext : DbContext
    {
        public SlijterijContext() : base("SlijterijContext")
        {

        }

        public DbSet<WhiskeyModel> Whiskeys { get; set; }

    }
}