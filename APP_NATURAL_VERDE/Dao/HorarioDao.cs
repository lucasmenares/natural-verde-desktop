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
    class HorarioDao
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = naturalverde ; USER ID = naturalverde");

        public HorarioDao()
        {

        }

        public bool agregarHorario(Horario horario)
        {
            bool respuesta = false;
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SP_ADD_HORARIO", ora);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("HORA", OracleType.VarChar).Value = horario.hora;
                comando.Parameters.Add("CODIGO_DIA", OracleType.Int32).Value = horario.codigo_dia;
                comando.Parameters.Add("CODIGO_EQUIPO", OracleType.Int32).Value = horario.codigo_equipo;
                comando.Parameters.Add("CODIGO_PROYECTO", OracleType.Int32).Value = horario.codigo_proyecto;
                if (comando.ExecuteNonQuery() > 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            } finally
            {
                ora.Close();
            }
            return respuesta;
        }

        public List<Horario> listarHorario()
        {
            List<Horario> listaHorario = new List<Horario>();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("select horario.codigo as \"Codigo Horario\", dia.dia as \"Dia\", horario.hora as \"Hora\", equipo.nombre as \"Equipo\", proyecto.nombre as \"Proyecto\" from horario inner join dia on horario.codigo_dia = dia.codigo inner join equipo on horario.codigo_equipo = equipo.codigo left join proyecto on horario.codigo_proyecto = proyecto.codigo order by \"Codigo Horario\" desc", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Horario horario = new Horario()
                    {
                        codigo = Convert.ToInt32(rdr["Codigo Horario"]),
                        dia = Convert.ToString(rdr["Dia"]),
                        hora = Convert.ToString(rdr["Hora"]),
                        equipo = Convert.ToString(rdr["Equipo"]),
                        proyecto = Convert.ToString(rdr["Proyecto"])
                    };
                    listaHorario.Add(horario);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            } finally
            {
                ora.Close();
            }
            return listaHorario;
        }

        public List<Horario> filtrarHorario(String dia, String hora, int disponible)
        {
            List<Horario> listaHorario = new List<Horario>();
            try
            {
                ora.Open();
                String baseQuery = "select horario.codigo as \"Codigo Horario\", dia.dia as \"Dia\", horario.hora as \"Hora\", equipo.nombre as \"Equipo\", proyecto.nombre as \"Proyecto\" from horario inner join dia on horario.codigo_dia = dia.codigo inner join equipo on horario.codigo_equipo = equipo.codigo left join proyecto on horario.codigo_proyecto = proyecto.codigo where 1=1 ";
                if (dia.Length > 0)
                {
                    baseQuery += "and UPPER(dia.dia) LIKE UPPER('%" + dia + "%') ";
                }

                if(hora.Length > 0)
                {
                    baseQuery += "and UPPER(horario.hora) LIKE UPPER('%" + hora + "%') ";
                }

                if (disponible == 1)
                {
                    baseQuery += "and proyecto.nombre IS NULL ";
                }

                if (disponible == 2)
                {
                    baseQuery += "and proyecto.nombre IS NOT NULL ";
                }
                baseQuery += "order by \"Codigo Horario\" desc";
                OracleCommand comando = new OracleCommand(baseQuery, ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Horario horario = new Horario()
                    {
                        codigo = Convert.ToInt32(rdr["Codigo Horario"]),
                        dia = Convert.ToString(rdr["Dia"]),
                        hora = Convert.ToString(rdr["Hora"]),
                        equipo = Convert.ToString(rdr["Equipo"]),
                        proyecto = Convert.ToString(rdr["Proyecto"])
                    };
                    listaHorario.Add(horario);
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
            return listaHorario;
        }

        public ResultadoBD eliminarHorario(int codigo)
        {
            ResultadoBD resultado = new ResultadoBD();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("select codigo, codigo_proyecto from horario where codigo = " + codigo, ora);
                OracleDataReader rdr = comando.ExecuteReader();
                if (!rdr.HasRows)
                {
                    resultado.mensaje = "El horario con ese código especificado no existe";
                    return resultado;
                }
                rdr.Read();
                OracleNumber codigo_proyecto = rdr.GetOracleNumber(1);
                if (!codigo_proyecto.IsNull)
                {
                    resultado.mensaje = "El horario tiene un proyecto asociado";
                    return resultado;
                }
                comando = new OracleCommand("delete from horario where codigo = " + codigo, ora);
                if(comando.ExecuteNonQuery() > 0)
                {
                    resultado.respuesta = true;
                    resultado.mensaje = "Se ha eliminado correctamente";
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
            return resultado;
        }


    }
}
