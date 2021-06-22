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
    class InsumoDao
    {
        public InsumoDao()
        {
            
        }

        public List<Insumo> listarInsumos()
        {
            List<Insumo> listaRetornada = new List<Insumo>();
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44316/");
            var requestGET = httpClient.GetAsync("api/insumo").Result;
            if (requestGET.IsSuccessStatusCode)
            {
                var cadena = requestGET.Content.ReadAsStringAsync().Result;
                var lista = JsonConvert.DeserializeObject<List<Insumo>>(cadena);
                foreach(var ins in lista)
                {
                    Insumo insumo = new Insumo()
                    {
                        codigo = ins.codigo,
                        nombre = ins.nombre,
                        stock = ins.stock,
                        precio = ins.precio
                    };
                    listaRetornada.Add(insumo);
                }
            }
            return listaRetornada;
        }

        public List<Insumo> listarProyectoInsumo()
        {
            List<Insumo> lista = new List<Insumo>();
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = naturalverde ; USER ID = naturalverde");
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT PROYECTO_INSUMO.CODIGO, PROYECTO_INSUMO.CODIGO_INSUMO AS \"CODIGO INSUMO\", PROYECTO_INSUMO.NOMBRE AS \"NOMBRE INSUMO\", PROYECTO_INSUMO.CODIGO_PROYECTO, PROYECTO.NOMBRE AS \"NOMBRE PROYECTO\", PROYECTO_INSUMO.CANTIDAD, PROYECTO_INSUMO.PRECIO FROM PROYECTO_INSUMO INNER JOIN PROYECTO ON CODIGO_PROYECTO = PROYECTO.CODIGO ORDER BY CODIGO DESC", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Insumo insumo = new Insumo()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        codigo_insumo = Convert.ToInt32(rdr["CODIGO INSUMO"]),
                        nombre = Convert.ToString(rdr["NOMBRE INSUMO"]),
                        codigo_proyecto = Convert.ToInt32(rdr["CODIGO_PROYECTO"]),
                        nombre_proyecto = Convert.ToString(rdr["NOMBRE PROYECTO"]),
                        stock = Convert.ToInt32(rdr["CANTIDAD"]),
                        precio = Convert.ToInt32(rdr["PRECIO"])
                    };
                    lista.Add(insumo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return lista;
        }

        public List<Insumo> filtrarProyectoInsumo(int codigo_proyecto)
        {
            List<Insumo> lista = new List<Insumo>();
            try
            {
                OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = naturalverde ; USER ID = naturalverde");
                ora.Open();
                OracleCommand comando = new OracleCommand("SELECT PROYECTO_INSUMO.CODIGO, PROYECTO_INSUMO.CODIGO_INSUMO AS \"CODIGO INSUMO\", PROYECTO_INSUMO.NOMBRE AS \"NOMBRE INSUMO\", PROYECTO_INSUMO.CODIGO_PROYECTO, PROYECTO.NOMBRE AS \"NOMBRE PROYECTO\", PROYECTO_INSUMO.CANTIDAD, PROYECTO_INSUMO.PRECIO FROM PROYECTO_INSUMO INNER JOIN PROYECTO ON CODIGO_PROYECTO = PROYECTO.CODIGO WHERE PROYECTO_INSUMO.CODIGO_PROYECTO = "+codigo_proyecto+ " ORDER BY CODIGO DESC", ora);
                OracleDataReader rdr = comando.ExecuteReader();
                while (rdr.Read())
                {
                    Insumo insumo = new Insumo()
                    {
                        codigo = Convert.ToInt32(rdr["CODIGO"]),
                        codigo_insumo = Convert.ToInt32(rdr["CODIGO INSUMO"]),
                        nombre = Convert.ToString(rdr["NOMBRE INSUMO"]),
                        codigo_proyecto = Convert.ToInt32(rdr["CODIGO_PROYECTO"]),
                        nombre_proyecto = Convert.ToString(rdr["NOMBRE PROYECTO"]),
                        stock = Convert.ToInt32(rdr["CANTIDAD"]),
                        precio = Convert.ToInt32(rdr["PRECIO"])
                    };
                    lista.Add(insumo);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            return lista;
        }

        public RespuestaInsumos agregaInsumoAProyecto(int codigo_proyecto, int codigo_insumo, int cantidad)
        {

            RespuestaInsumos respuestaRetornada = new RespuestaInsumos();

            OracleConnection ora = new OracleConnection("DATA SOURCE = xe ; PASSWORD = naturalverde ; USER ID = naturalverde");
            ora.Open();

            OracleCommand comando = new OracleCommand("SELECT CODIGO FROM PROYECTO WHERE CODIGO =" + codigo_proyecto, ora);
            OracleDataReader rdr = comando.ExecuteReader();
            if (!rdr.HasRows)
            {
                respuestaRetornada.mensaje = "El proyecto con el código especificado no existe";
                return respuestaRetornada;
            }
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:44316/");
            var requestGET = httpClient.GetAsync("api/Insumo?codigo="+codigo_insumo+"&stock="+cantidad).Result;
            if (requestGET.IsSuccessStatusCode)
            {
                var cadena = requestGET.Content.ReadAsStringAsync().Result;
                RespuestaInsumos respuesta = JsonConvert.DeserializeObject<RespuestaInsumos>(cadena);
                if (respuesta.respuesta)
                {
                    requestGET = httpClient.GetAsync("api/Insumo?codigo=" + codigo_insumo).Result;
                    var cadena2 = requestGET.Content.ReadAsStringAsync().Result;
                    Insumo respuesta2 = JsonConvert.DeserializeObject<Insumo>(cadena2);
                    comando = new OracleCommand("SELECT CODIGO_PROYECTO, CODIGO_INSUMO FROM PROYECTO_INSUMO WHERE CODIGO_PROYECTO =" + codigo_proyecto + " AND CODIGO_INSUMO = " + codigo_insumo, ora);
                    rdr = comando.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        comando = new OracleCommand("UPDATE PROYECTO_INSUMO SET CANTIDAD = " + cantidad + " + (select cantidad from proyecto_insumo where codigo_proyecto =" + codigo_proyecto + " and  codigo_insumo = " + codigo_insumo + ") WHERE CODIGO_PROYECTO= " + codigo_proyecto + " AND CODIGO_INSUMO =" + codigo_insumo, ora);
                        comando.ExecuteNonQuery();
                    }
                    else
                    {
                        comando = new OracleCommand("SP_ADD_PROYECTO_INSUMO", ora);
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.Add("CODIGO_PROYECTO", OracleType.Int32).Value = codigo_proyecto;
                        comando.Parameters.Add("NOMBRE", OracleType.VarChar).Value = respuesta2.nombre;
                        comando.Parameters.Add("CANTIDAD", OracleType.Int32).Value = cantidad;
                        comando.Parameters.Add("PRECIO", OracleType.Int32).Value = respuesta2.precio;
                        comando.Parameters.Add("CODIGO_INSUMO", OracleType.Int32).Value = codigo_insumo;
                        comando.ExecuteNonQuery();
                    }
                }
                respuestaRetornada.respuesta = respuesta.respuesta;
                respuestaRetornada.mensaje = respuesta.mensaje;
                respuestaRetornada.stock = respuesta.stock;
            }
            return respuestaRetornada;
        }
    }
}
