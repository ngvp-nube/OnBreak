using Gestion.Datops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Negocio
{
    public class Clientes
    {
        
        private string rutCliente;
        private string razonSocial;
        private string nombreContacto;
        private string mailcontacto;
        private string direccion;
        private string telefono;
        private ActividadEmpresas _actividadEmpresa;
        private TipoEmpresas _tipoempresa;

        public Clientes()
        {
            this.Init();
        }

        private void Init()
        {
            RutCliente = string.Empty;
            RazonSocial = string.Empty;
            NombreContacto= string.Empty;
            Mailcontacto = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            TipoEmpresa = new TipoEmpresas();
            ActividadEmpresa = new ActividadEmpresas();

        }

        public Clientes(string rutCliente, string razonSocial, string nombreContacto, string mailcontacto, string direccion, string telefono, ActividadEmpresas actividadEmpresa, TipoEmpresas tipoempresa )
        {
            RutCliente = rutCliente;
            RazonSocial = razonSocial;
            NombreContacto = nombreContacto;
            Mailcontacto = mailcontacto;
            Direccion = direccion;
            Telefono = telefono;
            ActividadEmpresa = actividadEmpresa;
            TipoEmpresa = tipoempresa;
            
        }

        

        public string RutCliente { get => rutCliente; set => rutCliente = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public string NombreContacto { get => nombreContacto; set => nombreContacto = value; }
        public string Mailcontacto { get => mailcontacto; set => mailcontacto = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public ActividadEmpresas ActividadEmpresa { get => _actividadEmpresa; set => _actividadEmpresa = value; }
        public TipoEmpresas TipoEmpresa { get => _tipoempresa; set => _tipoempresa = value; }
        
    }
}
