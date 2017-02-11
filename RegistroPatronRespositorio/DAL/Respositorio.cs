using RegistroPatronRespositorio.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;

namespace RegistroPatronRespositorio.DAL
{
    public class Respositorio<TEntity> : IRespository<TEntity> where TEntity : class
    {

        RegistrosDb Contex = null;
        public Respositorio()
        {
            Contex = new RegistrosDb();
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Contex.Set<TEntity>();
            }
        }

        public TEntity Guardar(TEntity laEntidad)
        {
            TEntity Result = null;

            try
            {
                EntitySet.Add(laEntidad);
                Contex.SaveChanges();
                Result = laEntidad;
            }
            catch { }

            return Result;
        }

        public bool Modificar(TEntity laEntidad)
        {
            bool Result = false;

            try
            {
                EntitySet.Attach(laEntidad);

                Contex.Entry<TEntity>(laEntidad).State = EntityState.Modified;

                Result = Contex.SaveChanges() > 0;
            }
            catch { }

            return Result;
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            TEntity Result = null;

            try
            {
                Result = EntitySet.FirstOrDefault(criterioBusqueda);
            }
            catch { }

            return Result;
        }

        public bool Eliminar(TEntity laEntidad)
        {
            bool Result = false;

            try
            {
                //para que el contexto lo considere como si estubiera recien agregado
                EntitySet.Attach(laEntidad);
                EntitySet.Remove(laEntidad);
                Result = Contex.SaveChanges() > 0;
            }
            catch { }

            return Result;
        }

        public List<TEntity> Lista(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            List<TEntity> Result = null;
            try
            {
                Result = EntitySet.Where(criterioBusqueda).ToList();
            }
            catch { }

            return Result;
        }

        public void Dispose()
        {
            if (Contex != null)
                Contex.Dispose();
        }
    }
}
