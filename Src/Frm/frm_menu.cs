using System;
using System.IO;
using System.Windows.Forms;

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
                    cmb_mod_est.Items.Add("Gestion integral SG-SST (15%)");
                    //--SELECCIONO EL PRIMER ITEM--//
                    cmb_mod_est.SelectedIndex = 0;
                    break;
                case "II. Hacer":

                    //--ACTIVO--//
                    cmb_mod_est.Enabled = true;
                    //--LIMPIO LOS CAMPOS--//
                    cmb_mod_est.Items.Clear();
                    //--AGREGO DATOS--//
                    cmb_mod_est.Items.Add("Seleccionar");
                    cmb_mod_est.Items.Add("Gestión de la Salud (20%)");
                    cmb_mod_est.Items.Add("Gestión de peligros y riesgos (30%)");
                    cmb_mod_est.Items.Add("Gestión de amenazas (10%)");
                    //--SELECCIONO EL PRIMER ITEM--//
                    cmb_mod_est.SelectedIndex = 0;
                    break;
                case "III. Verificar":

                    //--ACTIVO--//
                    cmb_mod_est.Enabled = true;
                    //--LIMPIO LOS CAMPOS--//
                    cmb_mod_est.Items.Clear();
                    //--AGREGO DATOS--//
                    cmb_mod_est.Items.Add("Seleccionar");
                    cmb_mod_est.Items.Add("Verificación del SG-SST (5%)");
                    //--SELECCIONO EL PRIMER ITEM--//
                    cmb_mod_est.SelectedIndex = 0;
                    break;
                case "IV. Actuar":

                    //--ACTIVO--//
                    cmb_mod_est.Enabled = true;
                    //--LIMPIO LOS CAMPOS--//
                    cmb_mod_est.Items.Clear();
                    //--AGREGO DATOS--//
                    cmb_mod_est.Items.Add("Seleccionar");
                    cmb_mod_est.Items.Add("Mejoramiento (10%)");
                    //--SELECCIONO EL PRIMER ITEM--//
                    cmb_mod_est.SelectedIndex = 0;
                    break;

                default:
                    //----//
                    cmb_mod_est.Enabled = false;
                    cmb_est.Enabled = false;
                    //----//
                    cmb_est.Items.Clear();
                    cmb_mod_est.Items.Clear();
                    //----//
                    txt_desc_est.Clear();
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
                    cmb_est.Items.Add("2. Capacitación en el Sistema...");
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
                    cmb_est.Items.Add("5. Evaluación inicial ...");
                    cmb_est.Items.Add("7. Conservación ...");
                    cmb_est.Items.Add("8. Rendición de cuentas ...");
                    cmb_est.Items.Add("9. Normatividadnacional ...");
                    cmb_est.Items.Add("10. Comunicación ...");
                    cmb_est.Items.Add("11. Adquisiciones ...");
                    cmb_est.Items.Add("12. Contratación ...");
                    cmb_est.Items.Add("13. Gestión ...");
                    //----//
                    cmb_est.SelectedIndex = 0;
                    break;
                case "Gestión de la Salud (20%)":

                    //----//
                    cmb_est.Enabled = true;
                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Items.Add("Seleccionar");
                    cmb_est.Items.Add("14. Condiciones ...");
                    cmb_est.Items.Add("15. Registro ...");
                    cmb_est.Items.Add("16. Mecanismos ...");
                    //----//
                    cmb_est.SelectedIndex = 0;
                    break;
                case "Gestión de peligros y riesgos (30%)":

                    //----//
                    cmb_est.Enabled = true;
                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Items.Add("Seleccionar");
                    cmb_est.Items.Add("17. Identificación ...");
                    cmb_est.Items.Add("18. Medidas ...");
                    //----//
                    cmb_est.SelectedIndex = 0;
                    break;
                case "Gestión de amenazas (10%)":

                    //----//
                    cmb_est.Enabled = true;
                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Items.Add("Seleccionar");
                    cmb_est.Items.Add("19. Plan de prevención ...");
                    //----//
                    cmb_est.SelectedIndex = 0;
                    break;
                case "Verificación del SG-SST (5%)":

                    //----//
                    cmb_est.Enabled = true;
                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Items.Add("Seleccionar");
                    cmb_est.Items.Add("20. Gestión y resultado ...");
                    //----//
                    cmb_est.SelectedIndex = 0;
                    break;
                case "Mejoramiento (10%)":

                    //----//
                    cmb_est.Enabled = true;
                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Items.Add("Seleccionar");
                    cmb_est.Items.Add("21. Acciones ...");
                    //----//
                    cmb_est.SelectedIndex = 0;
                    break;
                default:
                    //----//
                    cmb_est.Items.Clear();
                    //----//
                    cmb_est.Enabled = false;
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
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\4Objetivos\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "5. Evaluación inicial ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\5Evaluación\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "7. Conservación ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\7Conservación\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "8. Rendición de cuentas ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\8Rendición\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "9. Normatividadnacional ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\9Normatividad\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "10. Comunicación ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\10Comunicación\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "11. Adquisiciones ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\11Adquisiciones\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "12. Contratación ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\12Contratación\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "13. Gestión ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_INTEGRAL_DEL_SG-SST_(15%)\13Gestión\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "14. Condiciones ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTIÓN_DE_LA_SALUD(20%)\14.Condiciones\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "15. Registro ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTIÓN_DE_LA_SALUD(20%)\15.Registro\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "16. Mecanismos ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTIÓN_DE_LA_SALUD(20%)\16.Mecanismos\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "17. Identificación ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTIÓN_DE_PELIGROS_Y_RIESGOS(30%)\17.Identificacion\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "18. Medidas ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTIÓN_DE_PELIGROS_Y_RIESGOS(30%)\18.Medidas\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "19. Plan de prevención ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\GESTION_DE_AMENAZAS(10%)\19.Plan\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "20. Gestión y resultado ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\VERIFICACIÓN_DEL_SG-SST(5%)\20.Gestión\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
                    break;
                case "21. Acciones ...":
                    //----//
                    txt_desc_est.Clear();
                    //----//
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\VERIFICACIÓN_DEL_SG-SST(5%)\20.Gestión\Descripcion.txt";
                    //----//
                    Leer_texto(ruta);
                    //----//
                    txt_desc_est.Enabled = true;
                    //----//
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
                    Plantilla.Frms.frm2 FRMS2 = new Plantilla.Frms.frm2();
                    //----//
                    FRMS2.Show();
                    //----//
                    break;
                case "4. Objetivos del Sistema...":
                    //----//
                    Plantilla.Frms.frm4 FRMS4 = new Plantilla.Frms.frm4();
                    //----//
                    FRMS4.Show();
                    //----//
                    break;
                case "5. Evaluación inicial ...":
                    //----//
                    Plantilla.Frms.frm5 FRMS5 = new Plantilla.Frms.frm5();
                    //----//
                    FRMS5.Show();
                    //----//
                    break;
                case "7. Conservación ...":
                    //----//
                    Plantilla.Frms.frm7 FRMS7 = new Plantilla.Frms.frm7();
                    //----//
                    FRMS7.Show();
                    //----//
                    break;
                case "8. Rendición de cuentas ...":
                    //----//
                    Plantilla.Frms.frm8 FRMS8 = new Plantilla.Frms.frm8();
                    //----//
                    FRMS8.Show();
                    //----//
                    break;
                case "9. Normatividadnacional ...":
                    //----//
                    Plantilla.Frms.frm9 FRMS9 = new Plantilla.Frms.frm9();
                    //----//
                    FRMS9.Show();
                    //----//
                    break;
                case "10. Comunicación ...":
                    //----//
                    Plantilla.Frms.frm10 FRMS10 = new Plantilla.Frms.frm10();
                    //----//
                    FRMS10.Show();
                    //----//
                    break;
                case "11. Adquisiciones ...":
                    //----//
                    Plantilla.Frms.frm11 FRMS11 = new Plantilla.Frms.frm11();
                    //----//
                    FRMS11.Show();
                    //----//
                    break;
                case "12. Contratación ...":
                    //----//
                    Plantilla.Frms.frm12 FRMS12 = new Plantilla.Frms.frm12();
                    //----//
                    FRMS12.Show();
                    //----//
                    break;
                case "13. Gestión ...":
                    //----//
                    Plantilla.Frms.frm13 FRMS13 = new Plantilla.Frms.frm13();
                    //----//
                    FRMS13.Show();
                    //----//
                    break;
                case "14. Condiciones ...":
                    //----//
                    Plantilla.Frms.frm14 FRMS14 = new Plantilla.Frms.frm14();
                    //----//
                    FRMS14.Show();
                    //----//
                    break;
                case "15. Registro ...":
                    //----//
                    Plantilla.Frms.frm15 FRMS15 = new Plantilla.Frms.frm15();
                    //----//
                    FRMS15.Show();
                    //----//
                    break;
                case "16. Mecanismos ...":
                    //----//
                    Plantilla.Frms.frm16 FRMS16 = new Plantilla.Frms.frm16();
                    //----//
                    FRMS16.Show();
                    //----//
                    break;
                case "17. Identificación ...":
                    //----//
                    Plantilla.Frms.frm17 FRMS17 = new Plantilla.Frms.frm17();
                    //----//
                    FRMS17.Show();
                    //----//
                    break;
                case "18. Medidas ...":
                    //----//
                    Plantilla.Frms.frm18 FRMS18 = new Plantilla.Frms.frm18();
                    //----//
                    FRMS18.Show();
                    //----//
                    break;
                case "19. Plan de prevención ...":
                    //----//
                    Plantilla.Frms.frm19 FRMS19 = new Plantilla.Frms.frm19();
                    //----//
                    FRMS19.Show();
                    //----//
                    break;
                case "20. Gestión y resultado ...":
                    //----//
                    Plantilla.Frms.frm20 FRMS20 = new Plantilla.Frms.frm20();
                    //----//
                    FRMS20.Show();
                    //----//
                    break;
                case "21. Acciones ...":
                    //----//
                    Plantilla.Frms.frm21 FRMS21 = new Plantilla.Frms.frm21();
                    //----//
                    FRMS21.Show();
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
