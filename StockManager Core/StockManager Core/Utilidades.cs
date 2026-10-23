using System;
using System.Collections.Generic;
using System.Text;

namespace StockManager_Core
{
    internal class Utilidades
    {
        /*Funcion para MOSTRAR LOS ERRORES*/
        public static void MostrarError(Exception ex)
        {
            MessageBox.Show("Ocurrio un error:\n\n" + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


    }
}
