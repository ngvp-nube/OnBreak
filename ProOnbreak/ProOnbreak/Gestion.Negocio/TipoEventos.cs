using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Negocio
{
   public class TipoEventos
    {
        private int _id;
        private string _descripcion;
        public TipoEventos()
        {
            this.Init();
        }

        public void Init()
        {
            Descripcion = string.Empty;
        }

        public TipoEventos(int id)
        {
            Id = id;
        }
        public TipoEventos(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
