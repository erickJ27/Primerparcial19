using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using primerparcial19.Models;
using primerparcial19.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace primerparcial19.Controllers
{
    public class InscripcionController
    {

        public bool Guardar(Inscripciones inscripciones)
        {
            bool paso = false;
            if (inscripciones.InscripcionId == 0)
                paso =Insertar(inscripciones);
            else
                paso =Modificar(inscripciones);

            return paso;
        }
        private bool Insertar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();

             db.Incripcion.Add(inscripciones);
            paso = db.SaveChanges() > 0;


            return paso;
        }
        private bool Modificar(Inscripciones inscripciones)
        {
            bool paso = false;
            Contexto db = new Contexto();
            db.Entry(inscripciones).State = EntityState.Modified;
            paso = db.SaveChanges() > 0;

            return paso;
        }

        public Inscripciones Buscar(int Id)
        {

            Contexto db = new Contexto();
            Inscripciones ins;
            ins = db.Incripcion.Find(Id);

            return ins;

        }
        public bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            Inscripciones inscripciones=db.Incripcion.Find(Id);
            db.Entry(inscripciones).State = EntityState.Deleted;
            paso = db.SaveChanges() > 0;

            return paso;

        }
        public List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> expression)
        {
            List<Inscripciones> lista = new List<Inscripciones>();
            Contexto db = new Contexto();

            lista = db.Incripcion.Where(expression).ToList();

            return lista;
        }


    }
}
