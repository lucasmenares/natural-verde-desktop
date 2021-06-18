using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using APP_NATURAL_VERDE.Clases;

namespace APP_NATURAL_VERDE.Dao
{
    public class ServicioDao
    {

        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = naturalverde ; USER ID = naturalverde");

        public ServicioDao()
        {

        }


        public bool agregarServicio(Servicio servicio)

        {
            bool respuesta = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ADD_SERVICIO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE", OracleType.VarChar).Value = servicio.nombre;
                if (comando.ExecuteNonQuery() > 0)
                {
                    respuesta = true;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                ora.Close();

            }

            return respuesta;
        }

        public bool eliminarServicio(int codigo)
        {
            bool respuesta = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("delete from SERVICIO where codigo = " + codigo, ora);

                if (comando.ExecuteNonQuery() > 0)
                {
                    respuesta = true;

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ora.Close();
            }
            return respuesta;
        }


        public List<Servicio> listadoServicio()
        {
            List<Servicio> lista = new List<Servicio>();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM SERVICIO", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Servicio servicio = new Servicio()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        nombre = Convert.ToString(rdr["NOMBRE"])
                    };
                    lista.Add(servicio);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ora.Close();
            }

            return lista;
        }


        public List<Servicio> listadoServicioFiltrar(String nombre)
        {

            List<Servicio> listaFiltrada = new List<Servicio>();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM SERVICIO WHERE UPPER(NOMBRE) LIKE UPPER('%" + nombre + "%')", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Servicio servicio = new Servicio()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        nombre = Convert.ToString(rdr["NOMBRE"])
                    };
                    listaFiltrada.Add(servicio);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                ora.Close();
            }

            return listaFiltrada;

        }

    }
}
