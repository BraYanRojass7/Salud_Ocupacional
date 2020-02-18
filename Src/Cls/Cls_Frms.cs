using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace App_SG_SST_V1_5.Src.Cls
{
    class Cls_Frms
    {
        MySqlConnection con;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        public String SQL, avance;


        //--VARIABLES PUBLICAS--//
        public String d = "", a = "", o = "", m = "", n = "", f = "", e = "";
        //--ABRIR SOPORTE--//
        public void soportes(String ruta)
        {
            try
            {
                Process.Start("explorer", ruta);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al abrir los soportes: " + e.Message);
            }

        }
        //--LEER TEXTO--//
        public void leer_txt(String desc, String avan, String obs, String marc, String nombre, String fecha, String estado)
        {

            try
            {
                //--DESCRIPCION--//
                using (StreamReader file = new StreamReader(desc))
                {
                    d = file.ReadToEnd();
                    file.Close();
                }
                //--AVANCE--//
                using (StreamReader file = new StreamReader(avan))
                {
                    a = file.ReadToEnd();
                    file.Close();
                }
                //--OBSERVACIONES--//
                using (StreamReader file = new StreamReader(obs))
                {
                    o = file.ReadToEnd();
                    file.Close();
                }
                //--MARCO--//
                using (StreamReader file = new StreamReader(marc))
                {
                    m = file.ReadToEnd();
                    file.Close();
                }
                //--NOMBRE--//
                using (StreamReader file = new StreamReader(nombre))
                {
                    n = file.ReadToEnd();
                    file.Close();
                }
                //--FECHA--//
                using (StreamReader file = new StreamReader(fecha))
                {
                    f = file.ReadToEnd();
                    file.Close();
                }
                //--ESTADO--//
                using (StreamReader file = new StreamReader(estado))
                {
                    e = file.ReadToEnd();
                    file.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al leer los datos del servidor: " + e.Message);
            }

        }
        //--EDITAR ESTADO DELICONO--//
        public void estado_img(String ruta)
        {

            try
            {
                using (StreamReader file = new StreamReader(ruta))
                {
                    e = file.ReadToEnd();
                    file.Close();
                }
                if (e.Equals("ACTIVO"))
                {
                    File.WriteAllText(ruta, "CANCEL");
                }
                else
                {
                    File.WriteAllText(ruta, "ACTIVO");
                }

                MessageBox.Show("Estado Cambiado Exitosamente", "ESTADO CAMBIADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al cambiar la imagen del estado: " + e.Message, "ERRORESTADO IMG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--GUARDAR LOS CAMBIOS--//
        public void guardar(String desc, String avan, String obs, String marco, String fecha, String nombre, String texto1, String texto2, String texto3, String texto4, String texto5, String texto6)
        {

            try
            {

                //--DESCRIPCION--//
                File.WriteAllText(desc, texto1);
                //--DESCRIPCION--//
                File.WriteAllText(avan, texto2);
                //--DESCRIPCION--//
                File.WriteAllText(obs, texto3);
                //--DESCRIPCION--//
                File.WriteAllText(marco, texto4);
                //--NOMBRE--//
                File.WriteAllText(nombre, texto5);
                //--FECHA--//
                File.WriteAllText(fecha, texto6);
                //--MENSAJE DE INFORMACION--//
                MessageBox.Show("Datos guardados correctamente", "GUARDADO CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al guardar los datos", "GUARDADO INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //--LEER--//
        public void leer(String sql)
        {
            try
            {
                con = new MySqlConnection("Server=localhost;Database=hseq;Uid=root;Pwd= ;");
                SQL = sql;

                comando = new MySqlCommand(SQL, con);
                //comando.Parameters.AddWithValue("@NOMBRE", "");

                con.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    avance = Convert.ToString(dr["avance_est"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error INSERT INTO -> " + ex.Message);
            }
            finally
            {
                con.Close();
                con = null;
                comando = null;
            }
        }
    }
}
