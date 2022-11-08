using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Negocio
{
    public class TipoEmpresas
    {
        private int _id;
        private string _descripcion;

        public TipoEmpresas()
        {
            this.Init();

        }

        private void Init()
        {
            Descripcion = string.Empty;
        }

        public TipoEmpresas(int id)
        {
            Id = id;
            
        }
        public TipoEmpresas(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
    }
}
