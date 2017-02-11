using RegistroPatronRespositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RegistroPatronRespositorio.DAL
{
    public class RegistrosDb : DbContext
    {
        public RegistrosDb() : base("ConStr")
        {

        }

        public DbSet<Usuarios> Usuario { get; set; }
    }
}
