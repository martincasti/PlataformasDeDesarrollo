using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetallesServicies
    {
        private DataContext context;
        public DetallesServicies(DataContext contxt)
        {

            context = contxt;
        }

        public async Task<List<Detalles>> ListaDetalle()
        {
            var ctx = new DataContext();
            var lista = ctx.Detalles.ToList();


            return lista;
        }

        public Detalles AddDetalle(int idDet, string fech, string tiemp)
        {
            var ctx = new DataContext();
            var detalle = new Detalles
            {
                idDetalle = idDet,
                fecha = fech,
                tiempo = tiemp
            };
            ctx.Set<Detalles>().Add(detalle);
            ctx.SaveChanges();
            return detalle;
        }

        public Detalles updateDetalle(int idDet, string fech, string timep)
        {
            var ctx = new DataContext();
            var detalle = ctx.Detalles.Where(i => i.idDetalle == idDet).FirstOrDefault();
            return detalle;
        }

        /*
        public Detalle[] GetDetalles()
        {
            Detalle[] resultado = new Detalle[3];

            resultado[0] = new Detalle(01, "10/03/2020", "2 horas");
            resultado[1] = new Detalle(02, "09/11/2021", "1 hora");
            resultado[2] = new Detalle(03, "09/12/2021", "3 horas");

            return resultado;
        }*/

    }
}
