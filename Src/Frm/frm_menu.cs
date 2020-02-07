using System;
using System.Windows.Forms;
using System.IO;

namespace App_SG_SST_V1_5.Src.Frm
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
            cmb_ciclo.SelectedIndex = 0;
        }

        //--VALIDACION DEL CICLO ESCOGIDO POR EL USUARIO--//
        private void cmb_ciclo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //----//
            switch (cmb_ciclo.SelectedItem)
            {
                //----//
                case "Seleccionar":

                    //----//
                    cmb_mod_est.Enabled = false;
                    cmb_est.Enabled = false;
                    //----//
                    cmb_est.Items.Clear();
                    cmb_mod_est.Items.Clear();
                    //----//
                    txt_desc_est.Clear();
                    break;

                case "I. Planear":

                    //--ACTIVO--//
                    cmb_mod_est.Enabled = true;
                    //--LIMPIO LOS CAMPOS--//
                    cmb_mod_est.Items.Clear();
                    //--AGREGO DATOS--//
                    cmb_mod_est.Items.Add("Seleccionar");
                    cmb_mod_est.Items.Add("Recursos (10%)");
                    //cmb_mod_est.Items.Add("Gestion integral SG-SST (15%)");
                    //--SELECCIONO EL PRIMER ITEM--//
                    cmb_mod_est.SelectedIndex = 0;
                    break;

            }
        }

        //--VALIDACION DEL MODULO DEL ESTANDAR--//
        private void cmb_mod_est_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //----//
            switch (cmb_mod_est.SelectedItem)
            {
                case "Seleccionar":

                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Enabled = false;

                    break;

                case "Recursos (10%)":

                    //----//
                    cmb_est.Enabled = true;
                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Items.Add("Seleccionar");
                    cmb_est.Items.Add("1. Recursos Financieros...");
                    //cmb_est.Items.Add("2. Capacitación en el Sistema...");
                    //----//
                    cmb_est.SelectedIndex = 0;
                    break;

                case "Gestion integral SG-SST (15%)":

                    //----//
                    cmb_est.Enabled = true;
                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Items.Add("Seleccionar");
                    cmb_est.Items.Add("4. Objetivos del Sistema...");
                    cmb_est.Items.Add("5. ");
                    cmb_est.Items.Add("6. ");
                    cmb_est.Items.Add("7. ");
                    cmb_est.Items.Add("8. ");
                    cmb_est.Items.Add("9. ");
                    cmb_est.Items.Add("10. ");
                    cmb_est.Items.Add("11. ");
                    cmb_est.Items.Add("12. ");
                    cmb_est.Items.Add("13. ");
                    //----//
                    cmb_est.SelectedIndex = 0;
                    break;
            }
        }

        //--VALIDQACION DEL ESTANDAR--//
        private void cmb_est_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //----//
            switch (cmb_est.SelectedItem)
            {
                case "Seleccionar":

                    //----//
                    txt_desc_est.Clear();
                    //----//
                    txt_desc_est.Enabled = false;
                    //----//
                    break;

                case "1. Recursos Financieros...":

                    //----//
                    txt_desc_est.Clear();
                    //----//
                    string ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;

                case "2. Capacitación en el Sistema...":

                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                
                case "4. Objetivos del Sistema...":

                    //----//
                    txt_desc_est.Clear();
                    //----//
                    txt_desc_est.Text = "Objetivos del Sistema de Gestión de la Seguridad y la Salud en el Trabajo SG-SST (1%)";
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
            }
        }

        //--ACCION AL PRESIONAR EL BOTON INSPECCIONAR--//
        private void btn_inspec_Click(object sender, EventArgs e)
        {
            //----//
            switch (cmb_est.SelectedItem)
            {
                case "Seleccionar":

                    //----//
                    MessageBox.Show("Debe seleccionar un estandar primero", "SELECCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "1. Recursos Financieros...":

                    //----//
                    Plantilla.Frms.frm_1 FRMS = new Plantilla.Frms.frm_1();
                    //----//
                    FRMS.Show();
                    //----//
                    break;
                
                case "2. Capacitación en el Sistema...":

                    //----//
                    //Plantilla.Frms.frm_2 FRMS2 = new Plantilla.Frms.frm_2();
                    //----//
                    //FRMS2.Show();
                    //----//
                    break;
                
                case "4. Objetivos del Sistema...":

                    //----//
                    //Plantilla.Frms.frm_4 FRMS4 = new Plantilla.Frms.frm_4();
                    //----//
                    //FRMS4.Show();
                    //----//
                    break;
                
                default:

                    //----//
                    MessageBox.Show("Debe seleccionar un estandar primero", "SELECCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        //--ACCION AL PRESIONAR EL BOTON SALIR--//
        private void btn_salir_Click(object sender, EventArgs e)
        {
            //----//
            Application.Exit();
        }

        //--ACCION AL CERRAR LA APLICACION--//
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            //----//
            Application.Exit();
        }

        //--ACCION AL PRESIONAR EL BOTON SALIR--//
        private void lblSalir_Click(object sender, EventArgs e)
        {
            //----//
            Application.Exit();
        }

        //--ACCION AL PRESIONAR EL BOTON SALIR--//
        private void pic_Salir_Click(object sender, EventArgs e)
        {
            //----//
            Application.Exit();
        }

        //--ACCION AL PRESIONAR EL BOTON INSPECCIONAR--//
        private void lbl_Inspec_Click(object sender, EventArgs e)
        {
            //----//
            switch (cmb_est.SelectedItem)
            {
                case "Seleccionar":

                    //----//
                    MessageBox.Show("Debe seleccionar un estandar primero", "SELECCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "1. Recursos Financieros...":

                    //----//
                    Plantilla.Frms.frm_1 FRMS = new Plantilla.Frms.frm_1();
                    //----//
                    FRMS.Show();
                    //----//
                    break;

                case "2. Capacitación en el Sistema...":

                    //----//
                    //Plantilla.Frms.frm_2 FRMS2 = new Plantilla.Frms.frm_2();
                    //----//
                    //FRMS2.Show();
                    //----//
                    break;

                case "4. Objetivos del Sistema...":

                    //----//
                    //Plantilla.Frms.frm_4 FRMS4 = new Plantilla.Frms.frm_4();
                    //----//
                    //FRMS4.Show();
                    //----//
                    break;

                default:

                    //----//
                    MessageBox.Show("Debe seleccionar un estandar primero", "SELECCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        //--ACCION AL PRESIONAR EL BOTON INSPECCIONAR--//
        private void pic_Inspec_Click(object sender, EventArgs e)
        {
            //----//
            switch (cmb_est.SelectedItem)
            {
                case "Seleccionar":

                    //----//
                    MessageBox.Show("Debe seleccionar un estandar primero", "SELECCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case "1. Recursos Financieros...":

                    //----//
                    Plantilla.Frms.frm_1 FRMS = new Plantilla.Frms.frm_1();
                    //----//
                    FRMS.Show();
                    //----//
                    break;

                case "2. Capacitación en el Sistema...":

                    //----//
                   //Plantilla.Frms.frm_2 FRMS2 = new Plantilla.Frms.frm_2();
                    //----//
                    //FRMS2.Show();
                    //----//
                    break;

                case "4. Objetivos del Sistema...":

                    //----//
                    //Plantilla.Frms.frm_4 FRMS4 = new Plantilla.Frms.frm_4();
                    //----//
                    //FRMS4.Show();
                    //----//
                    break;

                default:

                    //----//
                    MessageBox.Show("Debe seleccionar un estandar primero", "SELECCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        //--LEER LOS DOCUMENTOS E IMPRIMIRLOS EN PANTALLA--//
        public void Leer_texto(string ruta)
        {
            String line = "";
            using (StreamReader file = new StreamReader(ruta))
            {
                line = file.ReadToEnd();
                txt_desc_est.Text = line;
                file.Close();
            }
        }
    }

    
}
