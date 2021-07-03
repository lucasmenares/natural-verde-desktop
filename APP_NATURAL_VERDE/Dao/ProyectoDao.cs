using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;
using APP_NATURAL_VERDE.Clases;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using System.Net.Http;

namespace APP_NATURAL_VERDE.Dao
{
    public class ProyectoDao
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = naturalverde ; USER ID = naturalverde");

        public ProyectoDao()
        {

        }

        public ResultadoBD agregarPresupuesto(int codigo_proyecto, int precio)
        {
            ResultadoBD resultado = new ResultadoBD();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT CODIGO, ESTADO FROM PROYECTO WHERE CODIGO = "+codigo_proyecto,ora);
                OracleDataReader rdr = comando.ExecuteReader();
                if (!rdr.HasRows)
                {
                    resultado.mensaje = "El proyecto con el codigo asociado no existe";
                    return resultado;
                }
                if (rdr.Read())
                {
                    String estado = Convert.ToString(rdr["ESTADO"]);
                    if(estado != "Espera de visita")
                    {
                        resultado.mensaje = "No se puede agregar a un presupuesto que no esté en estado 'Espera de visita'";
                        return resultado;
                    }
                    comando = new OracleCommand("UPDATE PROYECTO SET PRECIO = " + precio + ", ESTADO = 'Esperando pago' WHERE CODIGO = " + codigo_proyecto, ora);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        resultado.mensaje = "Se asignó el precio al proyecto correctamente";
                        resultado.respuesta = true;
                    }
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

        public ResultadoBD terminarProyecto(int codigo_proyecto)
        {
            ResultadoBD resultado = new ResultadoBD();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT CODIGO, ESTADO FROM PROYECTO WHERE CODIGO = " + codigo_proyecto, ora);
                OracleDataReader rdr = comando.ExecuteReader();
                if (!rdr.HasRows)
                {
                    resultado.mensaje = "El proyecto con el codigo asociado no existe";
                    return resultado;
                }
                if (rdr.Read())
                {
                    String estado = Convert.ToString(rdr["ESTADO"]);
                    if (estado != "Realizando")
                    {
                        resultado.mensaje = "No puedes terminar un proyecto que no esté en estado 'Realizando'";
                        return resultado;
                    }
                    comando = new OracleCommand("UPDATE PROYECTO SET ESTADO = 'Realizado'" + " WHERE CODIGO = " + codigo_proyecto, ora);
                    if (comando.ExecuteNonQuery() > 0)
                    {
                        resultado.mensaje = "Se terminó el proyecto correctamente";
                        resultado.respuesta = true;
                    }
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
            return resultado;
        }

        public List<Proyecto> listarProyectos()
        {
            List<Proyecto> lista = new List<Proyecto>();
            try
            {
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM PROYECTO ORDER BY CODIGO DESC", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Proyecto proyecto = new Proyecto()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        codigo_usuario = Convert.ToInt32(rdr["CODIGO_USUARIO"]),
                        codigo_servicio = Convert.ToInt32(rdr["CODIGO_SERVICIO"]),
                        codigo_horario = Convert.ToInt32(rdr["CODIGO_HORARIO"]),
                        nombre = Convert.ToString(rdr["NOMBRE"]),
                        presupuesto = Convert.ToString(rdr["PRESUPUESTO"]),
                        estado =  Convert.ToString(rdr["ESTADO"]),
                        direccion = Convert.ToString(rdr["DIRECCION"]),
                        descripcion = Convert.ToString(rdr["DESCRIPCION"]),
                        precio = Convert.ToInt32(rdr["PRECIO"])
                    };
                    lista.Add(proyecto);
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
            return lista;
        }
    }
}
