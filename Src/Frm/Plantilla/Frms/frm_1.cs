using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace App_SG_SST_V1_5.Src.Frm.Plantilla.Frms
{
    public partial class frm_1 : Form
    {

        public frm_1()
        {
            InitializeComponent();
            cmb_itemest.SelectedIndex = 0;
            

        }

        //--OBJETO PARA INTERACTUAR CON LA CLASE--//
        Cls.Cls_Frms clase = new Cls.Cls_Frms();
        //--MOSTRAR TEXTOS-100%-//
        private void cmb_marcolegal_SelectedIndexChanged(object sender, EventArgs e)
        {
            //--MOSTRAR TEXTO EN LOS CAMPOS--//
            estado_lectura(true, true, true, true,true,true);
            cursor();
            switch (cmb_itemest.SelectedItem)
            {

                case "Seleccionar":
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(false, false, false,false,false,false);
                    //--LIMPIAR LOS CAMPOS DE TEXTO--//
                    limpiar();                    
                    //--IMAGEN QUE SE MUESTRA--//
                    pic_estado.Image = Properties.Resources.help_question;
                    //--COLOR DE LOS BOTONES (RGB)--//
                    color_pic("a","a");
                    //--TIPO DE CURSOR EN LOS CAMPOS--//
                    break;

                case "1.1.3 Asignacion ...":
                    //--COLORES DE LOS BOTONES--//
                    color_pic("v","r");
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(true,true,true,true,true,false);
                    //--RUTAS DE LOS TEXTOS--//
                    string descripcion = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Descripción_Item.txt"; 
                    String avance = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Avance.txt"; 
                    String Observaciones = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Observaciones.txt"; 
                    String Marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Marco_legal.txt"; 
                    String nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Nombre.txt"; 
                    String fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Fecha.txt";
                    String estado = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Estado.txt";
                    //--OBTENER Y MOSTRAR LOS TEXTOS--//
                    clase.leer_txt(descripcion,avance,Observaciones,Marco,nombre,fecha,estado);
                    mostrar_txt();
                    //----//
                    break;

                case "1.1.5 Pago ...":
                    //--COLOR DE LOS BOTONES--//
                    color_pic("v", "r");
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(true, true, true, true, true, false);
                    //--RUTAS DE LOS ARCHIVOSS--//
                    descripcion = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Descripción_Item.txt";
                    avance = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Avance.txt";
                    Observaciones = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Observaciones.txt";
                    Marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Fecha.txt";
                    estado = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Estado.txt";
                    //--OBTENER Y MOSTRAR LOS TEXTOS--//
                    clase.leer_txt(descripcion, avance, Observaciones, Marco, nombre, fecha, estado);
                    mostrar_txt();
                    //----//
                    break;

                case "1.1.6 Conformación ...":

                    //--COLOR DE LOS BOTONES--//
                    color_pic("v", "r");
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(true, true, true, true, true, false);
                    //--RUTAS DE LOS ARCHIVOSS--//
                    descripcion = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Descripción_Item.txt";
                    avance = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Avance.txt";
                    Observaciones = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Observaciones.txt";
                    Marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Fecha.txt";
                    estado = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Estado.txt";
                    //--OBTENER Y MOSTRAR LOS TEXTOS--//
                    clase.leer_txt(descripcion, avance, Observaciones, Marco, nombre, fecha, estado);
                    mostrar_txt();
                    break;

                case "1.1.7 Capacitación ...":

                    //--COLOR DE LOS BOTONES--//
                    color_pic("v", "r");
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(true, true, true, true, true, false);
                    //--RUTAS DE LOS ARCHIVOSS--//
                    descripcion = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Descripción_Item.txt";
                    avance = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Avance.txt";
                    Observaciones = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Observaciones.txt";
                    Marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Fecha.txt";
                    estado = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Estado.txt";
                    //--OBTENER Y MOSTRAR LOS TEXTOS--//
                    clase.leer_txt(descripcion, avance, Observaciones, Marco, nombre, fecha, estado);
                    mostrar_txt();
                    break;

                case "1.1.8 Conformación ...":

                    //--COLOR DE LOS BOTONES--//
                    color_pic("v", "r");
                    //--ESTADO DE LOS CAMPOS--//
                    txt_estados(true, true, true, true, true, false);
                    //--RUTAS DE LOS ARCHIVOSS--//
                    descripcion = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Descripción_Item.txt";
                    avance = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Avance.txt";
                    Observaciones = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Observaciones.txt";
                    Marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Fecha.txt";
                    estado = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Estado.txt";
                    ///--OBTENER Y MOSTRAR LOS TEXTOS--//
                    clase.leer_txt(descripcion, avance, Observaciones, Marco, nombre, fecha, estado);
                    mostrar_txt();
                    break;
            }
        }
        //--MOSTRAR LOS SOPORTES DEL ITEM--//
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            soportes();
        }
        //--EDITAR LOS CAMPOS--//
        private void pic_editar_Click(object sender, EventArgs e)
        {
            Editar();
        }
        //--GUARDAR LOS CAMBIOS--//
        private void pic_guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        //--CAMBIAR LA IMAGEN DEL ESTADO--//
        private void pic_estado_Click(object sender, EventArgs e)
        {
            String ruta;
            if (pic_editar.Enabled == false)
            {
                switch (cmb_itemest.SelectedItem)
                {

                    case "1.1.3 Asignacion ...":
                        ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Estado.txt";
                        clase.estado_img(ruta);
                        break;
                    case "1.1.5 Pago ...":
                        ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Estado.txt";
                        clase.estado_img(ruta);
                        break;
                    case "1.1.6 Conformación ...":
                        ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Estado.txt";
                        clase.estado_img(ruta);
                        break;
                    case "1.1.7 Capacitación ...":
                        ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Estado.txt";
                        clase.estado_img(ruta);
                        break;
                    case "1.1.8 Conformación ...":
                        ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Estado.txt";
                        clase.estado_img(ruta);
                        break;

                    default:
                        MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
                        
        }

        //-------------------------METODOS----------------------------------//


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
        //--MOSTRAR CAMPOS--//
        void mostrar_txt() {

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
                else {
                    pic_estado.Image = Properties.Resources.cancel;
                }
        }
        //--EDITAR--//
        void Editar() {
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
        void Guardar() {
            //--ESTADO DE LOS BOTONES EDITAR Y GUARDAR--//
            pic_editar.Enabled = true;
            pic_guardar.Enabled = false;
            //--COLOR DE LOS BOTONES EDITAR Y GUARDAR--//
            color_pic("v", "r");
            //--ESTADO (EDITABLE O NO) DE LOS CAMPOS DE TEXTO--//
            estado_lectura(true,true,true,true,true,true);
            //--TIPO DE CURSOR DE LOS CAMPOS--//
            cursor();
            //--VARIABLES PARA LAS RUTAS--//
            string desc = "";
            String avan = "";
            String observa = "";
            String marco = "";
            String nombre = "";
            String fecha = "";
            String texto1, texto2, texto3, texto4,texto5,texto6;
            //--RUTA DEL ARCHIVO DEPENDIENDO DEL ELEMENTO SELECCIONADO--//
            switch (cmb_itemest.SelectedItem) {

                case "1.1.3 Asignacion ...":

                    //--RUTA DE LOS ARCHIVOS--//
                    desc = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Descripción_Item.txt";
                    avan = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Avance.txt";
                    observa = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Observaciones.txt";
                    marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Fecha.txt";
                    texto1 = txt_desc.Text;
                    texto2 = txt_avance.Text;
                    texto3 = txt_observa.Text;
                    texto4 = txt_marco.Text;
                    texto5 = txt_nombre.Text;
                    texto6 = txt_fecha.Text;
                    clase.guardar(desc, avan, observa, marco, fecha, nombre, texto1, texto2, texto3, texto4, texto5, texto6);
                    break;
                case "1.1.5 Pago ...":

                    //--RUTA DE LOS ARCHIVOS--//
                    desc = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Descripción_Item.txt";
                    avan = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Avance.txt";
                    observa = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Observaciones.txt";
                    marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Fecha.txt"; 
                    texto1 = txt_desc.Text;
                    texto2 = txt_avance.Text;
                    texto3 = txt_observa.Text;
                    texto4 = txt_marco.Text;
                    texto5 = txt_nombre.Text;
                    texto6 = txt_fecha.Text;
                    clase.guardar(desc, avan, observa, marco, fecha, nombre, texto1, texto2, texto3, texto4, texto5, texto6);
                    break;
                case "1.1.6 Conformación ...":

                    //--RUTA DE LOS ARCHIVOS--//
                    desc = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Descripción_Item.txt";
                    avan = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Avance.txt";
                    observa = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Observaciones.txt";
                    marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Fecha.txt";
                    texto1 = txt_desc.Text;
                    texto2 = txt_avance.Text;
                    texto3 = txt_observa.Text;
                    texto4 = txt_marco.Text;
                    texto5 = txt_nombre.Text;
                    texto6 = txt_fecha.Text;

                    clase.guardar(desc, avan, observa, marco, fecha, nombre, texto1, texto2, texto3, texto4, texto5, texto6);
                    break;
                case "1.1.7 Capacitación ...":

                    //--RUTA DE LOS ARCHIVOS--//
                    desc = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Descripción_Item.txt";
                    avan = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Avance.txt";
                    observa = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Observaciones.txt";
                    marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Nombre.txt";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Fecha.txt";
                    texto1 = txt_desc.Text;
                    texto2 = txt_avance.Text;
                    texto3 = txt_observa.Text;
                    texto4 = txt_marco.Text;
                    texto5 = txt_nombre.Text;
                    texto6 = txt_fecha.Text;
                    clase.guardar(desc, avan, observa, marco, fecha, nombre, texto1, texto2, texto3, texto4, texto5, texto6);
                    break;
                case "1.1.8 Conformación ...":

                    //--RUTA DE LOS ARCHIVOS--//
                    desc = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Descripción_Item.txt";
                    avan = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Avance.txt";
                    observa = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Observaciones.txt";
                    marco = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Marco_legal.txt";
                    nombre = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\1.1.3Asignación";
                    fecha = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\fecha.txt";
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
        //--LIMPIAR CAMPOS--//
        void limpiar() {
            txt_desc.Clear();
            txt_avance.Clear();
            txt_observa.Clear();
            txt_marco.Clear();
            //--LIMPIAR LAS ETIQUETAS--//
            txt_nombre.Text = "------";
            txt_fecha.Text = "--/--/----";
        }
        //--ESTADOS (SOLO LECTURAO O EDITABLE)--//
        public void estado_lectura(Boolean avan, Boolean desc, Boolean marco, Boolean observa,Boolean nombre,Boolean fecha)
        {
            txt_avance.ReadOnly = avan;
            txt_desc.ReadOnly = desc;
            txt_marco.ReadOnly = marco;
            txt_observa.ReadOnly = observa;
            txt_nombre.ReadOnly = nombre;
            txt_fecha.ReadOnly = fecha;
        }
        //--TIPOS DE CURSORES--//
        public void cursor_no() {
            txt_avance.Cursor = Cursors.No;
            txt_desc.Cursor = Cursors.No;
            txt_marco.Cursor = Cursors.No;
            txt_observa.Cursor = Cursors.No;
            txt_nombre.Cursor = Cursors.No;
            txt_fecha.Cursor = Cursors.No;
        }
        public void cursor_editar() {
            txt_avance.Cursor = Cursors.IBeam;
            txt_desc.Cursor = Cursors.IBeam;
            txt_marco.Cursor = Cursors.IBeam;
            txt_observa.Cursor = Cursors.IBeam;
            txt_nombre.Cursor = Cursors.IBeam;
            txt_fecha.Cursor = Cursors.IBeam;
        }
        //--ASIGNACION DE LOS CURSORES DEPENDIENDO DEL ESTADO DEL CAMPO DE TEXTO--//
        public void cursor() {
            if (txt_avance.ReadOnly==true&&txt_desc.ReadOnly==true&&txt_marco.ReadOnly==true&&txt_observa.ReadOnly==true&&txt_nombre.ReadOnly==true&&txt_fecha.ReadOnly==true) {
                cursor_no();
            }
            else {
                cursor_editar();   
            }
        }
        //--COLOR DE LOS BOTONES--//
        public void color_pic(String editar,String guardar) {
            
            switch (editar) {
                case"r":
                    pic_editar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\editar_r.png");
                    break;
                case "v":
                    pic_editar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\editar_v.png");
                    break;
                default:
                    pic_editar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\editar.png");
                    break;
            }
            switch (guardar) {
                case"r":
                    pic_guardar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\guardar_r.png");
                    break;
                case "v":
                    pic_guardar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\guardar_v.png");
                    break;
                default:
                    pic_guardar.Image = System.Drawing.Image.FromFile(@"\\192.168.1.180\informes\TIC'S\guardar.png");
                    break;
            }
            

        }
        //--SOPORTES--//
        public void soportes() {
            String ruta;
            switch (cmb_itemest.SelectedItem)
            {
                case "1.1.3 Asignacion ...":
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.3Asignación\Soportes";
                    clase.soportes(ruta);
                    break;
                case "1.1.5 Pago ...":
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.5Pago\Soportes";
                    clase.soportes(ruta);
                    break;
                case "1.1.6 Conformación ...":
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.6Conformacion\Soportes";
                    clase.soportes(ruta);
                    break;
                case "1.1.7 Capacitación ...":
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.7Capacitacion\Soportes";
                    clase.soportes(ruta);
                    break;
                case "1.1.8 Conformación ...":
                    ruta = @"\\192.168.1.180\informes\TIC'S\Src\Ciclo\Recursos(10%)\1.Recursos\1.1.8Conformacion\Soportes";
                    clase.soportes(ruta);
                    break;

                default:
                    MessageBox.Show("Any Document", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


    }
}
