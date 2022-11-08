using Gestion.Datops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Negocio
{
   public class ActividadEmpresas
    {
        private int _id;
        private string _descripcion;


        public ActividadEmpresas()
        {
            this.Init();
        }

        private void Init()
        {
            Descripcion = string.Empty;
        }

        public ActividadEmpresas(int id)
        {
            Id = id;
            
        }
        public ActividadEmpresas(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
       
    }
}
