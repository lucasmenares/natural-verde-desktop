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
    public class EquipoDao
    {

        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = naturalverde ; USER ID = naturalverde");

        public EquipoDao()
        {

        }

        public bool AgregarEquipo(Equipo equipo)

        {
            bool respuesta = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ADD_EQUIPO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE", OracleType.VarChar).Value = equipo.nombre;
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

        public bool eliminarEquipo (int codigo)
        {
            bool respuesta = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("delete from EQUIPO where codigo = "+codigo, ora);

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


        public List<Equipo> listadoEquipo()
        {
            List<Equipo> lista = new List<Equipo>();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM EQUIPO", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())  
                {
                    Equipo equipo = new Equipo()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        nombre = Convert.ToString(rdr["NOMBRE"])
                    };
                    lista.Add(equipo);
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

        public List<Equipo> listadoEquipoFiltrar(String nombre)
        {

            List<Equipo> listaFiltrada = new List<Equipo>();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM EQUIPO WHERE UPPER(NOMBRE) LIKE UPPER('%" + nombre+ "%')", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Equipo equipo = new Equipo()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        nombre = Convert.ToString(rdr["NOMBRE"])
                    };
                    listaFiltrada.Add(equipo);
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
