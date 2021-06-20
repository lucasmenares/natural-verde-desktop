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

        public ResultadoBD eliminarEquipo(int codigo)
        {
            ResultadoBD resultado = new ResultadoBD();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("select codigo from equipo where codigo = " + codigo, ora);
                OracleDataReader rdr = comando.ExecuteReader();
                if (!rdr.HasRows)
                {
                    resultado.mensaje = "El equipo con ese código especificado no existe";
                    return resultado;
                }
                comando = new OracleCommand("select codigo, codigo_equipo from horario where codigo_equipo = " + codigo, ora);
                rdr = comando.ExecuteReader();
                if (rdr.HasRows)
                {
                    resultado.mensaje = "No puedes eliminar un equipo con horarios asociados";
                    return resultado;
                }
                comando = new OracleCommand("delete from EQUIPO where codigo = " + codigo, ora);
                if (comando.ExecuteNonQuery() > 0)
                {
                    resultado.mensaje = "Se ha eliminado el equipo correctamente";
                    resultado.respuesta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                ora.Close();
            }
            return resultado;
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
