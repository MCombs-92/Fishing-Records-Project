using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fishing_Records.Models {


    public class FRDBContext : DbContext {

        public DbSet<Fish> Fish { get; set; }

    }
}