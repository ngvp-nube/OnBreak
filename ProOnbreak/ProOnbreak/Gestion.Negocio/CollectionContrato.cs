using Gestion.Datops;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Negocio
{
    public class CollectionContrato
    {
        BreakOnEntities bd = new BreakOnEntities();


        public bool Crear(Contratos con)
        {
            try
            {
                Contrato contrato = new Contrato();

                contrato.RutCliente = con.RutCliente;
                contrato.Numero = con.Numero;
                contrato.NombreEvento = con.NombreEvento;
                contrato.Direccion = con.Direccion;
                contrato.Asistentes = con.Asistentes;
                contrato.PersonalAdicional = con.PersonalAdicional;
                contrato.ValorTotalContrato = con.ValorTotalContrato;
                contrato.Observaciones = con.Observaciones;
                contrato.FechaHoraInicio = con.FechaHoraInicio;
                contrato.FechaHoraTermino = con.FechaHoraTermino;
                contrato.IdModalidad = con.ModalidadServicio.IdModalidad;
                contrato.IdTipoEvento = con.TipoEvento.Id;
               
                contrato.Termino = con.Termino;
                contrato.Creacion = con.CracionContrato;
                contrato.Realizado = con.Realizado;
                bd.Contrato.Add(contrato);
                this.bd.SaveChanges();
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Contratos> ListarContratos()
        {
            return (from t in this.bd.Contrato
                   
                    select new Contratos()
                    {
                        RutCliente= t.RutCliente,
                        Numero = t.Numero,
                        NombreEvento=t.NombreEvento,
                        Direccion=t.Direccion,
                        Asistentes=t.Asistentes,
                        PersonalAdicional=t.PersonalAdicional,
                        ValorTotalContrato=t.ValorTotalContrato,
                        FechaHoraInicio=t.FechaHoraInicio,
                        FechaHoraTermino=t.FechaHoraTermino,
                        CracionContrato= t.Creacion,
                        Realizado =t.Realizado,
                         
                        ModalidadServicio = new ModalidadServicios()
                        {
                            IdModalidad=t.IdModalidad,
                            NombreModalidad=t.ModalidadServicio.Nombre,
                            ValorBase=t.ModalidadServicio.ValorBase,
                            PersonalBase=t.ModalidadServicio.PersonalBase
                            
                        }
                        ,
                        TipoEvento = new TipoEventos()
                        {
                            Id=t.ModalidadServicio.IdTipoEvento,
                            Descripcion=t.ModalidadServicio.TipoEvento.Descripcion
                        }



                    }).ToList();
        }
        

        public List<Contratos> FiltrarContratosxNumero(string numero)
        {
            List<Contratos> contrato = (from c in ListarContratos()
                                        where c.Numero.ToLower().Contains(numero)
                                        select c).ToList();
            return contrato;
        }


        public List<Contratos> FiltrarContratosRut(string rut)
        {
            List<Contratos> contrato = (from c in ListarContratos()
                                       where c.RutCliente.ToLower().Contains(rut)
                                       select c).ToList();
            return contrato;
        }


        public List<Contratos> FiltrarxTipoEventos(int id)
        {
            return (from t in this.bd.Contrato
                    where t.IdTipoEvento==id
                    select new Contratos()
                    {
                        RutCliente = t.RutCliente,
                        Numero = t.Numero,
                        NombreEvento = t.NombreEvento,
                        Direccion = t.Direccion,
                        Asistentes = t.Asistentes,
                        PersonalAdicional = t.PersonalAdicional,
                        ValorTotalContrato = t.ValorTotalContrato,
                        FechaHoraInicio = t.FechaHoraInicio,
                        FechaHoraTermino = t.FechaHoraTermino,
                        CracionContrato = t.Creacion,
                        Realizado = t.Realizado,

                        ModalidadServicio = new ModalidadServicios()
                        {
                            IdModalidad = t.IdModalidad,
                            NombreModalidad = t.ModalidadServicio.Nombre,
                            ValorBase = t.ModalidadServicio.ValorBase,
                            PersonalBase = t.ModalidadServicio.PersonalBase

                        }
                        ,
                        TipoEvento = new TipoEventos()
                        {
                            Id = t.ModalidadServicio.IdTipoEvento,
                            Descripcion = t.ModalidadServicio.TipoEvento.Descripcion
                        }



                    }).ToList();
        }


        public List<ModalidadServicios> ListarModalidadServicios()
        {
            return (from t in this.bd.ModalidadServicio
                 
                    select new ModalidadServicios()
                    {
                        
                        IdModalidad = t.IdModalidad,
                        NombreModalidad = t.Nombre,
                        PersonalBase=t.PersonalBase,
                        ValorBase=t.ValorBase
                        
                        
                       
                    }).ToList();
        }


        public List<TipoEventos> ListarTipoEventos()
        {
            return (from t in this.bd.TipoEvento

                    select new TipoEventos()
                    {
                        Id = t.IdTipoEvento,
                        Descripcion = t.Descripcion

                    }).ToList();
        }


        public List<ModalidadServicios> Listar(int id)
        {
            return (from t in this.bd.ModalidadServicio
                    where t.IdTipoEvento == id
                    select new ModalidadServicios()
                    {

                        IdModalidad = t.IdModalidad,
                        NombreModalidad = t.Nombre,
                        PersonalBase = t.PersonalBase,
                        ValorBase = t.ValorBase,
                        
                     
                    }).ToList();
        }



        public Contrato Buscar (string rut)
        {
            var aux = (from t in this.bd.Contrato
                       where t.RutCliente==rut
                       select t);
            if (aux.Count() > 0 )
            {
                return aux.First();
            }
            else
            {
                return null;
            }
        }


        public Contrato BuscarPorRut(string rut)
        {
            var aux = (from t in this.bd.Contrato
                       where t.RutCliente==rut
                       select t);
            if (aux.Count() > 0)
            {
                return aux.First();
            }
            else
            {
                return null;
            }
        }



    }
}
