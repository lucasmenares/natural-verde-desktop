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



    public class DiaDao
    {

        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = naturalverde ; USER ID = naturalverde");

        

        public DiaDao()
        {

        }

        public bool agregarDia(Dia dia)

        {
            bool respuesta = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ADD_DIA", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("DIA", OracleType.VarChar).Value = dia.dia;
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


        public bool eliminarDia(int codigo)
        {
            bool respuesta = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("delete from DIA where codigo = " + codigo, ora);

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

        public List<Dia> listadoDia()
        {
            List<Dia> lista = new List<Dia>();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM DIA", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Dia dia = new Dia()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        dia = Convert.ToString(rdr["DIA"])
                    };
                    lista.Add(dia);
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

        public List<Dia> listadoDiaFiltrar(String nombre)
        {

            List<Dia> listaFiltrada = new List<Dia>();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM DIA WHERE UPPER(DIA) LIKE UPPER('%" + nombre + "%')", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Dia dia = new Dia()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        dia = Convert.ToString(rdr["DIA"])
                    };
                    listaFiltrada.Add(dia);
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

            return listaFiltrada;

        }
    }
}
