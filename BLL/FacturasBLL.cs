using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaFacturacion.Models;
using SistemaFacturacion.DAL;
using System.Linq.Expressions;

namespace SistemaFacturacion.BLL
{
    public class FacturasBLL
    {
        public static bool Guardar(Facturas facturas)
        {
            if (!Existe(facturas.FacturaId))
                return Insertar(facturas);
            else
                return Modificar(facturas);
        }

        private static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Facturas.Any(e => e.FacturaId == id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        private static bool Insertar(Facturas facturas)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Facturas.Add(facturas);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private static bool Modificar(Facturas facturas)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(facturas).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var factura = contexto.Facturas.Find(id);
                if (factura != null)
                {
                    contexto.Facturas.Remove(factura);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        public static Facturas Buscar(int id)
        {
            Facturas facturas;
            Contexto contexto = new Contexto();

            try
            {
                facturas = contexto.Facturas.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return facturas;
        }

        public static List<Facturas> GetList(Expression<Func<Facturas, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Facturas> lista = new List<Facturas>();

            try
            {
                lista = contexto.Facturas.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Facturas> GetFacturas()
        {
            Contexto contexto = new Contexto();
            List<Facturas> lista = new List<Facturas>();

            try
            {
                lista = contexto.Facturas.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
