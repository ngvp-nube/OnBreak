using Gestion.Datops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Negocio
{
   public class ClientesCollection
    {
        BreakOnEntities bd = new BreakOnEntities();

        

        public bool Crear(Clientes c)
        {
            try
            {
                Cliente cliente = new Cliente();

                cliente.RutCliente = c.RutCliente;
                cliente.NombreContacto = c.NombreContacto;
                cliente.MailContacto = c.Mailcontacto;
                cliente.RazonSocial = c.RazonSocial;
                cliente.Telefono = c.Telefono;
                cliente.Direccion = c.Direccion;
                cliente.IdTipoEmpresa = c.TipoEmpresa.Id;
                cliente.IdActividadEmpresa = c.ActividadEmpresa.Id;
                bd.Cliente.Add(cliente);
                this.bd.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool Eliminar(string rut)
        {
            try
            {
                Cliente cliente = this.bd.Cliente.Find(rut);
                bd.Cliente.Remove(cliente);
                this.bd.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<ActividadEmpresas> ListarActividadEmpresa()
        {
            return (from t in this.bd.ActividadEmpresa
                    select new ActividadEmpresas()
                    {
                        Id = t.IdActividadEmpresa,
                        Descripcion = t.Descripcion
                    }).ToList();
        }
        public List<TipoEmpresas> ListarTipoEmpresas()
        {
            return (from t in this.bd.TipoEmpresa
                    select new TipoEmpresas()
                    {
                        Id = t.IdTipoEmpresa,
                        Descripcion = t.Descripcion
                    }).ToList();
        }

        public List<Clientes> ListarClientes()
        {
            return (from t in this.bd.Cliente
             
                    select new Clientes()
                    {
                        RutCliente = t.RutCliente,
                        Direccion = t.Direccion,
                        Mailcontacto = t.MailContacto,
                        RazonSocial = t.RazonSocial,
                        Telefono = t.Telefono,
                        NombreContacto = t.NombreContacto,

                        ActividadEmpresa = new ActividadEmpresas()
                        {
                            Id = t.ActividadEmpresa.IdActividadEmpresa,
                            Descripcion = t.ActividadEmpresa.Descripcion
                        }
                        ,
                        TipoEmpresa = new TipoEmpresas()
                        {
                            Id = t.TipoEmpresa.IdTipoEmpresa,
                            Descripcion = t.TipoEmpresa.Descripcion
                        }

                    }).ToList();
        }

        public List<Clientes> FiltrarporActividadEmpresa(int id)
        {
            return (from t in this.bd.Cliente
                    where t.IdActividadEmpresa==id
                    select new Clientes()
                    {
                        RutCliente = t.RutCliente,
                        Direccion = t.Direccion,
                        Mailcontacto = t.MailContacto,
                        RazonSocial = t.RazonSocial,
                        Telefono = t.Telefono,
                        NombreContacto = t.NombreContacto,

                        ActividadEmpresa = new ActividadEmpresas()
                        {
                            Id = t.ActividadEmpresa.IdActividadEmpresa,
                            Descripcion = t.ActividadEmpresa.Descripcion
                        }
                        ,
                        TipoEmpresa = new TipoEmpresas()
                        {
                            Id = t.TipoEmpresa.IdTipoEmpresa,
                            Descripcion = t.TipoEmpresa.Descripcion
                        }

                    }).ToList();
        }
        public List<Clientes> FiltrarporTipoEmpresa(int id)
        {
            return (from t in this.bd.Cliente
                    where t.IdTipoEmpresa == id
                    select new Clientes()
                    {
                        RutCliente = t.RutCliente,
                        Direccion = t.Direccion,
                        Mailcontacto = t.MailContacto,
                        RazonSocial = t.RazonSocial,
                        Telefono = t.Telefono,
                        NombreContacto = t.NombreContacto,

                        ActividadEmpresa = new ActividadEmpresas()
                        {
                            Id = t.ActividadEmpresa.IdActividadEmpresa,
                            Descripcion = t.ActividadEmpresa.Descripcion
                        }
                        ,
                        TipoEmpresa = new TipoEmpresas()
                        {
                            Id = t.TipoEmpresa.IdTipoEmpresa,
                            Descripcion = t.TipoEmpresa.Descripcion
                        }

                    }).ToList();
        }
        
    }
}
