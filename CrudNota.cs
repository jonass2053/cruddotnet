using CURD_DOCNET.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CURD_DOCNET
{
    public class CrudNota
    {

        public static string Cadena = @"Server=DESKTOP-48MN1T8;Database=TALENDIG;Trusted_Connection=True;";
        public static string ErroMsj = "Se ha producido un error..";



        #region  GetAll


        public static List<Nota> GetAll()
        {
            
            List<Nota> DataList = new List<Nota>();

            using (SqlConnection conn = new SqlConnection(Cadena))
            {
                try
                {
                    conn.Open();
                    using(SqlCommand cmd = new SqlCommand("select * from notas"))
                    {
                        cmd.Connection = conn;
                        SqlDataReader rd = cmd.ExecuteReader();
                        
                            while (rd.Read())
                            {
                                Nota nota = new Nota();
                                nota.Id =Convert.ToInt32(rd["id"]);
                                nota.Nombre = rd["nombre"].ToString();
                                nota.Apellido = rd["apellido"].ToString();
                                nota.Matricula = rd["matricula"].ToString();
                                nota.Curso = rd["curso"].ToString();
                                nota.nota = int.Parse(rd["nota"].ToString());
                                DataList.Add(nota);

                            }


                        
                        
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ErroMsj + ex);
                }
                
            }

               return DataList;

        }
        #endregion

        #region  GetById

        public static Nota GetById(int id)
        {
            Nota nota = new Nota();

            using (SqlConnection conn = new SqlConnection(Cadena))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand($"select * from notas where id={id}")) 
                    {
                        cmd.Connection = conn;
                        SqlDataReader rd = cmd.ExecuteReader();
                        
                            if(rd.Read())
                            {
                                
                                nota.Id = int.Parse(rd["id"].ToString());
                                nota.Nombre = rd["nombre"].ToString();
                                nota.Apellido = rd["apellido"].ToString();
                                nota.Matricula = rd["matricula"].ToString();
                                nota.Curso = rd["curso"].ToString();
                                nota.nota = int.Parse(rd["nota"].ToString());
                               

                            }


                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ErroMsj + ex);
                }

            }

            return nota;

        }
        #endregion



    }
}

           