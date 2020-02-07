using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.IO;

namespace App_SG_SST_V1_5
{

    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        //CREO UN OBJETO PARA INTERACTUAR CON LA CLASE
        Src.Cls.Cls_loguin OBJ = new Src.Cls.Cls_loguin();

        //--VALIDO EL CAMPO DE RECORDAR CONTRASEÑA--//
        private void frm_main_Load(object sender, EventArgs e)
        {
            //--VALIDO EL CAMPO DE RECORDAR CONTRASEÑA--//
            if (Properties.Settings.Default.User != "")
            {
                //--CHEKEO EL CUADRO--//
                chk_reco_contra.Checked = true;

                //--ASIGNO EL USUARIO A LA CAJA DE TEXTO, DEPENDIENDO SI EL USUARIO ASI LO ESPECIFICO--//
                txt_user.Text = Properties.Settings.Default.User;
            }
            else
            {
                //--DESCHEKEO EL CUADRO--//
                chk_reco_contra.Checked = false;
            }
        }

        //--VALIDO AL PRESIONAR ENTER SOBRE EL CAMPO--//
        private void txt_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //---EJECUTO EL CODIGO CUANDO EL USUARIO PRESIONA LA TECLA ENTER
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                /*
                ALMACENO EL VALOR DE LA VARIABLE DEVUELTO POR EL METODO EN OTRA VARIABLE
                MEDIANTE EL OBJETO INTERACTUO CON EL METODO EN LA CLASE, Y ENVIO LOS DATOS DE LOS CUADROS DE TEXTO
                */

                string Validacion = OBJ.Loguin(txt_user.Text, txt_pass.Text);

                if (Validacion.Equals("OK"))
                {
                    //SI TODOS LOS DATOS SON CORREECTOS DOY UN MESAJE DE BIENVENIDA
                    MessageBox.Show("Bienvanid@ " + txt_user.Text, "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //CREO UN OBJETO PARA INTERACTUAR CON EL FRAME DESEADO
                    Src.Frm.frm_menu menu = new Src.Frm.frm_menu();

                    //ABRO EL FRAME DESEADO MEDIANTE EL OBJETO PREVIAMENTE CREADO
                    menu.Show();

                    //CIERRO EL FRAME ACTUAL
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //--- ALMACENAMIENTO DEL USUARIO O RECORDAR USUARIO ---//

                if (chk_reco_contra.Checked == true)
                {
                    //--SI LA CONDICION SE CUMPLE ALMACENO LOS DATOS--//
                    Properties.Settings.Default.User = txt_user.Text;
                    //--GUARDO LOS CAMBIOS--//
                    Properties.Settings.Default.Save();

                }
                else
                {
                    //--GUARDO UN CAMPO VACIO--//
                    Properties.Settings.Default.User = "";
                    //--GUARDO LOS CAMBIOS--//
                    Properties.Settings.Default.Save();

                }

            }
        }

        //--VALIDO AL DARLE CLICK AL BOTON--//
        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            /*
            ALMACENO EL VALOR DE LA VARIABLE DEVUELTO POR EL METODO EN OTRA VARIABLE
            MEDIANTE EL OBJETO INTERACTUO CON EL METODO EN LA CLASE, Y ENVIO LOS DATOS DE LOS CUADROS DE TEXTO
            */

            string Validacion = OBJ.Loguin(txt_user.Text, txt_pass.Text);

            if (Validacion.Equals("OK"))
            {
                //SI TODOS LOS DATOS SON CORREECTOS DOY UN MESAJE DE BIENVENIDA
                MessageBox.Show("Bienvanid@ " + txt_user.Text, "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //CREO UN OBJETO PARA INTERACTUAR CON EL FRAME DESEADO
                Src.Frm.frm_menu menu = new Src.Frm.frm_menu();

                //ABRO EL FRAME DESEADO MEDIANTE EL OBJETO PREVIAMENTE CREADO
                menu.Show();

                //CIERRO EL FRAME ACTUAL
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //--- ALMACENAMIENTO DEL USUARIO O RECORDAR USUARIO ---//

            if (chk_reco_contra.Checked == true)
            {
                //----//
                Properties.Settings.Default.User = txt_user.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.User = "";
                Properties.Settings.Default.Save();

            }
        }

        //--SALGO AL PRESIONAR EL BOTON--//
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //--SALGO DE LA APLICACION--//
            Application.Exit();

        }

        //--SALGO AL PRESIONAR EL BOTON--//
        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //--SALGO DE LA APLICACION--//
            Application.Exit();
        }

        //--SALGO AL PRESIONAR EL BOTON--//
        private void lblSalir_Click(object sender, EventArgs e)
        {
            //--SALGO DE LA APLICACION--//
            Application.Exit();
        }

        //--SALGO AL PRESIONAR EL BOTON--//
        private void pic_boton_Click(object sender, EventArgs e)
        {
            //--SALGO DE LA APLICACION--//
            Application.Exit();
        }

        //--ACCION AL PRESIONAR EL BOTON INGRESAR--//
        private void lbl_ingresar_Click(object sender, EventArgs e)
        {
            /*
            ALMACENO EL VALOR DE LA VARIABLE DEVUELTO POR EL METODO EN OTRA VARIABLE
            MEDIANTE EL OBJETO INTERACTUO CON EL METODO EN LA CLASE, Y ENVIO LOS DATOS DE LOS CUADROS DE TEXTO
            */

            string Validacion = OBJ.Loguin(txt_user.Text, txt_pass.Text);

            if (Validacion.Equals("OK"))
            {
                //SI TODOS LOS DATOS SON CORREECTOS DOY UN MESAJE DE BIENVENIDA
                MessageBox.Show("Bienvanid@ " + txt_user.Text, "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //CREO UN OBJETO PARA INTERACTUAR CON EL FRAME DESEADO
                Src.Frm.frm_menu menu = new Src.Frm.frm_menu();

                //ABRO EL FRAME DESEADO MEDIANTE EL OBJETO PREVIAMENTE CREADO
                menu.Show();

                //CIERRO EL FRAME ACTUAL
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //--- ALMACENAMIENTO DEL USUARIO O RECORDAR USUARIO ---//

            if (chk_reco_contra.Checked == true)
            {
                //----//
                Properties.Settings.Default.User = txt_user.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.User = "";
                Properties.Settings.Default.Save();

            }

        }

        //--ACCION AL PRESIONAR EL BOTON INSPECCIONAR--//
        private void ppic_ingresar_Click(object sender, EventArgs e)
        {
            /*
            ALMACENO EL VALOR DE LA VARIABLE DEVUELTO POR EL METODO EN OTRA VARIABLE
            MEDIANTE EL OBJETO INTERACTUO CON EL METODO EN LA CLASE, Y ENVIO LOS DATOS DE LOS CUADROS DE TEXTO
            */

            string Validacion = OBJ.Loguin(txt_user.Text, txt_pass.Text);

            if (Validacion.Equals("OK"))
            {
                //SI TODOS LOS DATOS SON CORREECTOS DOY UN MESAJE DE BIENVENIDA
                MessageBox.Show("Bienvanid@ " + txt_user.Text, "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //CREO UN OBJETO PARA INTERACTUAR CON EL FRAME DESEADO
                Src.Frm.frm_menu menu = new Src.Frm.frm_menu();

                //ABRO EL FRAME DESEADO MEDIANTE EL OBJETO PREVIAMENTE CREADO
                menu.Show();

                //CIERRO EL FRAME ACTUAL
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //--- ALMACENAMIENTO DEL USUARIO O RECORDAR USUARIO ---//

            if (chk_reco_contra.Checked == true)
            {
                //----//
                Properties.Settings.Default.User = txt_user.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.User = "";
                Properties.Settings.Default.Save();

            }

        }

        //--ACCION AL PRSIONAR LA IMAGEN DE GENTE UTIL--//
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
