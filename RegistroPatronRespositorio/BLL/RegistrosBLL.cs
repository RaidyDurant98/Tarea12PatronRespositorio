using RegistroPatronRespositorio.DAL;
using RegistroPatronRespositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroPatronRespositorio.BLL
{
    public class RegistrosBLL
    {
        public static bool Guardar(Usuarios nuevo)
        {
            bool retorno = false;
            using (var repositorio = new Respositorio<Usuarios>())
            {
                retorno = repositorio.Guardar(nuevo) != null;
            }
            return retorno;
        }
    }
}
