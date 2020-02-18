using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SG_SST_V1_5.Src.Frm.Plantilla.Frms
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
            cmb_itemest.SelectedIndex = 0;   
        }

        //--OBJETO PARA INTERACTUAR CON LA CLASE--//
        Cls.Cls_Frms clase = new Cls.Cls_Frms();

        //--MOSTRAR TEXTOS-100%-//
        private void cmb_itemest_SelectedIndexChanged(object sender, EventArgs e)
        {
            //--MOSTRAR TEXTO EN LOS CAMPOS--//
            estado_lectura(true, true, true, true, true, true);
            cursor();
            switch (cmb_itemest.SelectedItem)
            {

                case "Seleccionar":
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(false, false, false, false, false, false);
                    //--LIMPIAR LOS CAMPOS DE TEXTO--//
                    limpiar();
                    //--IMAGEN QUE SE MUESTRA--//
                    pic_estado.Image = Properties.Resources.help_question;
                    //--COLOR DE LOS BOTONES (RGB)--//
                    color_pic("a", "a");
                    //--TIPO DE CURSOR EN LOS CAMPOS--//
                    break;

                case "1.2.1 Programa ...":
                    //--COLORES DE LOS BOTONES--//
                    color_pic("v", "r");
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(true, true, true, true, true, false);
                    //--RUTAS DE LOS TEXTOS--//
                    string descripcion = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Descripción_Item.txt";
                    String avance = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Avance.txt";
                    String Observaciones = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Observaciones.txt";
                    String Marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Marco_legal.txt";
                    String nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Nombre.txt";
                    String fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Fecha.txt";
                    String estado = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Estado.txt";
                    //--OBTENER Y MOSTRAR LOS TEXTOS--//
                    clase.leer_txt(descripcion, avance, Observaciones, Marco, nombre, fecha, estado);
                    mostrar_txt();
                    //----//
                    break;

                case "1.2.2 Capacitación ...":

                    //--COLOR DE LOS BOTONES--//
                    color_pic("v", "r");
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(true, true, true, true, true, false);
                    //--RUTAS DE LOS ARCHIVOSS--//
                    descripcion = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Descripción_Item.txt";
                    avance = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Avance.txt";
                    Observaciones = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Observaciones.txt";
                    Marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Fecha.txt";
                    estado = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Estado.txt";
                    //--OBTENER Y MOSTRAR LOS TEXTOS--//
                    clase.leer_txt(descripcion, avance, Observaciones, Marco, nombre, fecha, estado);
                    mostrar_txt();
                    break;

            }
        }
        //--MOSTRAR LOS SOPORTES DEL ITEM--//
        private void pic_soportes_Click(object sender, EventArgs e)
        {
            soportes();
        }
        //--EDITAR LOS CAMPOS--//
        private void pic_editar_Click_1(object sender, EventArgs e)
        {
            Editar();
        }
        //--GUARDAR LOS CAMBIOS--//

        private void pic_guardar_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }
        //--CAMBIAR LA IMAGEN DEL ESTADO--//
        private void pic_estado_Click_1(object sender, EventArgs e)
        {
            String ruta;
            if (pic_editar.Enabled == false)
            {
                switch (cmb_itemest.SelectedItem)
                {

                    case "1.2.1 Programa ...":
                        ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Estado.txt";
                        clase.estado_img(ruta);
                        break;
                    case "1.2.2 Capacitación ...":
                        ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Estado.txt";
                        clase.estado_img(ruta);
                        break;
                    default:
                        MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        //---------------- METODOS -----------------//

        //--ESTADOS (SOLO LECTURAO O EDITABLE)--//
        public void estado_lectura(Boolean avan, Boolean desc, Boolean marco, Boolean observa, Boolean nombre, Boolean fecha)
        {
            txt_avance.ReadOnly = avan;
            txt_desc.ReadOnly = desc;
            txt_marco.ReadOnly = marco;
            txt_observa.ReadOnly = observa;
            txt_nombre.ReadOnly = nombre;
            txt_fecha.ReadOnly = fecha;
        }
        //--ASIGNACION DE LOS CURSORES DEPENDIENDO DEL ESTADO DEL CAMPO DE TEXTO--//
        public void cursor()
        {
            if (txt_avance.ReadOnly == true && txt_desc.ReadOnly == true && txt_marco.ReadOnly == true && txt_observa.ReadOnly == true && txt_nombre.ReadOnly == true && txt_fecha.ReadOnly == true)
            {
                cursor_no();
            }
            else
            {
                cursor_editar();
            }
        }
        //--TIPOS DE CURSORES--//
        public void cursor_no()
        {
            txt_avance.Cursor = Cursors.No;
            txt_desc.Cursor = Cursors.No;
            txt_marco.Cursor = Cursors.No;
            txt_observa.Cursor = Cursors.No;
            txt_nombre.Cursor = Cursors.No;
            txt_fecha.Cursor = Cursors.No;
        }
        public void cursor_editar()
        {
            txt_avance.Cursor = Cursors.IBeam;
            txt_desc.Cursor = Cursors.IBeam;
            txt_marco.Cursor = Cursors.IBeam;
            txt_observa.Cursor = Cursors.IBeam;
            txt_nombre.Cursor = Cursors.IBeam;
            txt_fecha.Cursor = Cursors.IBeam;
        }
        //--ACTIVAR O DESACTIVAR CAMPOS--//
        public void txt_estados(Boolean avance, Boolean desc, Boolean marco, Boolean observa, Boolean editar, Boolean guardar)
        {

            txt_avance.Enabled = avance;
            txt_desc.Enabled = desc;
            txt_marco.Enabled = marco;
            txt_observa.Enabled = observa;
            pic_editar.Enabled = editar;
            pic_guardar.Enabled = guardar;
        }
        //--LIMPIAR CAMPOS--//
        void limpiar()
        {
            txt_desc.Clear();
            txt_avance.Clear();
            txt_observa.Clear();
            txt_marco.Clear();
            //--LIMPIAR LAS ETIQUETAS--//
            txt_nombre.Text = "------";
            txt_fecha.Text = "--/--/----";
        }
        //--COLOR DE LOS BOTONES--//
        public void color_pic(String editar, String guardar)
        {

            switch (editar)
            {
                case "r":
                    pic_editar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\Src\imgs\editar_r.png");
                    break;
                case "v":
                    pic_editar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\Src\imgs\editar_v.png");
                    break;
                default:
                    pic_editar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\Src\imgs\editar.png");
                    break;
            }
            switch (guardar)
            {
                case "r":
                    pic_guardar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\Src\imgs\guardar_r.png");
                    break;
                case "v":
                    pic_guardar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\Src\imgs\guardar_v.png");
                    break;
                default:
                    pic_guardar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\Src\imgs\guardar.png");
                    break;
            }


        }
        //--MOSTRAR CAMPOS--//
        void mostrar_txt()
        {

            //--DESCRIPCION--//
            txt_desc.Text = clase.d;
            //--AVANCE--//
            txt_avance.Text = clase.a;
            //--OBSERVACION--//       
            txt_observa.Text = clase.o;
            //--MARCO--//      
            txt_marco.Text = clase.m;
            //--Nombre--//           
            txt_nombre.Text = clase.n;
            //--Fecha--//
            txt_fecha.Text = clase.f;
            //--Estado--// 
            if (clase.e.Equals("ACTIVO"))
            {
                pic_estado.Image = Properties.Resources._checked;
            }
            else
            {
                pic_estado.Image = Properties.Resources.cancel;
            }
        }
        //--SOPORTES--//
        public void soportes()
        {
            String ruta;
            switch (cmb_itemest.SelectedItem)
            {
                case "1.2.1 Programa ...":
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Soportes";
                    clase.soportes(ruta);
                    break;
                case "1.2.2 Capacitación ...":
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Soportes";
                    clase.soportes(ruta);
                    break;
            }
        }
        //--EDITAR--//
        void Editar()
        {
            //--ESTADO DE LOS BOTONES EDITAR Y GUARDAR--//
            pic_editar.Enabled = false;
            pic_guardar.Enabled = true;
            //--COLOR DE LOS BOTONES EDITAR Y GUARDAR--//
            color_pic("r", "v");
            //--ESTADO (EDITABLE O NO) DE LOS CAMPOS DE TEXTO--//
            txt_avance.ReadOnly = false;
            txt_desc.ReadOnly = false;
            txt_marco.ReadOnly = false;
            txt_observa.ReadOnly = false;
            txt_nombre.ReadOnly = false;
            txt_fecha.ReadOnly = false;
            //--TIPO DE CURSOR DE LOS CAMPOS--//
            txt_avance.Cursor = Cursors.IBeam;
            txt_desc.Cursor = Cursors.IBeam;
            txt_marco.Cursor = Cursors.IBeam;
            txt_observa.Cursor = Cursors.IBeam;
            txt_nombre.Cursor = Cursors.IBeam;
            txt_fecha.Cursor = Cursors.IBeam;
        }
        //--GUARDAR--//
        void Guardar()
        {
            //--ESTADO DE LOS BOTONES EDITAR Y GUARDAR--//
            pic_editar.Enabled = true;
            pic_guardar.Enabled = false;
            //--COLOR DE LOS BOTONES EDITAR Y GUARDAR--//
            color_pic("v", "r");
            //--ESTADO (EDITABLE O NO) DE LOS CAMPOS DE TEXTO--//
            estado_lectura(true, true, true, true, true, true);
            //--TIPO DE CURSOR DE LOS CAMPOS--//
            cursor();
            //--VARIABLES PARA LAS RUTAS--//
            string desc = "";
            String avan = "";
            String observa = "";
            String marco = "";
            String nombre = "";
            String fecha = "";
            String texto1, texto2, texto3, texto4, texto5, texto6;
            //--RUTA DEL ARCHIVO DEPENDIENDO DEL ELEMENTO SELECCIONADO--//
            switch (cmb_itemest.SelectedItem)
            {

                case "1.2.1 Programa ...":

                    //--RUTA DE LOS ARCHIVOS--//
                    desc = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Descripción_Item.txt";
                    avan = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Avance.txt";
                    observa = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Observaciones.txt";
                    marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.1Programa Capacitación\Fecha.txt";
                    texto1 = txt_desc.Text;
                    texto2 = txt_avance.Text;
                    texto3 = txt_observa.Text;
                    texto4 = txt_marco.Text;
                    texto5 = txt_nombre.Text;
                    texto6 = txt_fecha.Text;
                    clase.guardar(desc, avan, observa, marco, fecha, nombre, texto1, texto2, texto3, texto4, texto5, texto6);
                    break;
                case "1.2.2 Capacitación ...":

                    //--RUTA DE LOS ARCHIVOS--//
                    desc = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Descripción_Item.txt";
                    avan = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Avance.txt";
                    observa = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Observaciones.txt";
                    marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\2.Capacitacion\1.2.2Capacitación\Fecha.txt";
                    texto1 = txt_desc.Text;
                    texto2 = txt_avance.Text;
                    texto3 = txt_observa.Text;
                    texto4 = txt_marco.Text;
                    texto5 = txt_nombre.Text;
                    texto6 = txt_fecha.Text;
                    clase.guardar(desc, avan, observa, marco, fecha, nombre, texto1, texto2, texto3, texto4, texto5, texto6);
                    break;
            }
        }


    }
}
