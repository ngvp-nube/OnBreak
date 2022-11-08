using Gestion.Datops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Negocio
{
   public class Contratos
    {
        private string _numero;
      
        private string _rutCliente;
        private string _nombreEvento;
        private DateTime _fechaHoraInicio;
        private DateTime _fechaHoraTermino;
        private int _asistentes;
        private DateTime _cracionContrato;
        private string _direccion;
        private int _personalAdicional;
        private Double _valorTotalContrato;
        private DateTime _termino;
        private string _observaciones;
 
        private Boolean _realizado;
        private TipoEventos _tipoEvento;
        private ModalidadServicios _modalidadServicio;

        public Contratos()
        {
            this.Init();
        }
        public void Init()
        {
            Numero = string.Empty;
            RutCliente = string.Empty;
            NombreEvento = string.Empty;
            FechaHoraInicio = DateTime.Today;
            FechaHoraTermino = DateTime.Today;
            Asistentes = 0;
            CracionContrato = DateTime.Today;
            Direccion = string.Empty;
            PersonalAdicional = 0;
            ValorTotalContrato = 0;
            Termino = DateTime.Today;
            Observaciones = string.Empty;
            
            Realizado = true;
            TipoEvento = new TipoEventos();
            ModalidadServicio = new ModalidadServicios();
        }
        public Contratos(string numero, string rutCliente, string nombreEvento, DateTime fechaHoraInicio, DateTime fechaHoraTermino, int asistentes, DateTime cracionContrato, string direccion, int personalAdicional, Double valorTotalContrato, DateTime termino, string observaciones,  TipoEventos tipoEvento, ModalidadServicios modalidadServicio, bool realizado)
        {
             Numero = numero;
             RutCliente = rutCliente;
             NombreEvento = nombreEvento;
             FechaHoraInicio = fechaHoraInicio;
             FechaHoraTermino = fechaHoraTermino;
             Asistentes = asistentes;
             CracionContrato = cracionContrato;
             Direccion = direccion;
             PersonalAdicional = personalAdicional;
             ValorTotalContrato = valorTotalContrato;
             Termino = termino;
             Observaciones = observaciones;
       
             TipoEvento = tipoEvento;
              ModalidadServicio = modalidadServicio;
             Realizado = realizado;
        }

        

        public string Numero{ get => _numero; set => _numero = value; }
        public string RutCliente { get => _rutCliente; set => _rutCliente = value; }
        public string NombreEvento { get => _nombreEvento; set => _nombreEvento = value; }
        public DateTime FechaHoraInicio { get => _fechaHoraInicio; set => _fechaHoraInicio= value; }
        public DateTime FechaHoraTermino { get => _fechaHoraTermino; set => _fechaHoraTermino = value; }
        public int Asistentes { get => _asistentes; set => _asistentes = value; }
        public DateTime CracionContrato { get => _cracionContrato; set => _cracionContrato = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public int PersonalAdicional { get => _personalAdicional; set => _personalAdicional = value; }
        public Double ValorTotalContrato { get => _valorTotalContrato; set => _valorTotalContrato = value; }
        public DateTime Termino { get => _termino; set => _termino = value; }
        public string Observaciones { get => _observaciones; set => _observaciones = value; }

        public TipoEventos TipoEvento { get => _tipoEvento; set => _tipoEvento = value; }
        public ModalidadServicios ModalidadServicio { get => _modalidadServicio; set => _modalidadServicio = value; }
        public bool Realizado { get => _realizado; set => _realizado = value; }

       

    }
}
