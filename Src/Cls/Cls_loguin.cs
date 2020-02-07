namespace App_SG_SST_V1_5.Src.Cls
{
    class Cls_loguin
    {
        public string Loguin(string User, string Pass)
        {

            string Validacion = "";

            //--- SUPERUSUARIO ---//
            string Usuario = "Admin";
            string Contraseña = "Root";

            /*
            --- EL USUARIO2 SE PUEDE MODIFICAR ---
            */

            //--- USUARIO ---//
            string Usuario2 = "TatianaGU";
            string Contraseña2 = "HSEQ";

            //VALIDO LOS USUARIOS
            if (User.Equals(Usuario) || User.Equals(Usuario2))
            {
                //VALIDO LAS CONTRASEÑAS
                if (Pass.Equals(Contraseña) || Pass.Equals(Contraseña2))
                {
                    //ACTUALIZO EL VALOR DE LA VARIABLE
                    Validacion = "OK";
                }
                else
                {
                    //ACTUALIZO EL VALOR DE LA VARIABLE
                    Validacion = "ERROR";
                }
            }
            else
            {
                //ACTUALIZO EL VALOR DE LA VARIABLE
                Validacion = "ERROR";
            }

            //DEVUELVO LA VARIABLE CUANDO EJECUTO EL METODO
            return Validacion;
        }
    }
}
