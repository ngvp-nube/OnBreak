using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Negocio
{
   public class ModalidadServicios
    {
        private string _idModalidad;
        private int _idtipoEvento;
        private string _nombreModalidad;
        private double _valorBase;
        private int _personalBase;

        public ModalidadServicios()
        {
            this.Init();

        }

        private void Init()
        {
            NombreModalidad = string.Empty;
            ValorBase = 0;
            PersonalBase = 0;
        }

        public ModalidadServicios(string idModalidad)
        {
            IdModalidad = idModalidad;
        }


        public ModalidadServicios(string idModalidad, string nombreModalidad, double valorBase, int personalBase)
        {
            IdModalidad = idModalidad;
            NombreModalidad = nombreModalidad;
            ValorBase = valorBase;
            PersonalBase = personalBase;
        }

        public ModalidadServicios(int idtipoEvento)
        {
           TipoEvento = idtipoEvento;
        }

        public string IdModalidad { get => _idModalidad; set => _idModalidad = value; }
        public string NombreModalidad { get => _nombreModalidad; set => _nombreModalidad = value; }
        public double ValorBase { get => _valorBase; set => _valorBase = value; }
        public int PersonalBase { get => _personalBase; set => _personalBase = value; }
        public int TipoEvento { get => _idtipoEvento; set => _idtipoEvento = value; }
      
    }
}
