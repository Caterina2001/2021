using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace DCU__Final
{
    public class Conexion
    {
        private static OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=DBDCU.accdb;");

        public static string[] Nombre;
        public static string[] Cedula;
        public static string[] TipoSangre;
        public static string[] Antecedentes;
        public static string[] Contacto;
        public static string[] Direccion;
        private static byte[] Face;
        public static List<byte[]> Listado = new List<byte[]>();

        public static int TotalFace;

        

        public static bool GuardarImagen(string Nombre, string Cedula, string TipoSangre, string Antecedentes, string Contacto, string Direccion, byte[] Imagen)
        {
            conexion.Close();
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO TablaDCU (Nombre,Cedula,TipoSangre,Antecedentes,Contacto,Direccion,Imagen) Values('" + Nombre + "', '" + Cedula + "', '" + TipoSangre + "', '" + Antecedentes + "', '" + Contacto + "', '" + Direccion + "', ?);", conexion);
            OleDbParameter parImagen = new OleDbParameter("@Imagen", OleDbType.VarBinary, Imagen.Length);
            parImagen.Value = Imagen;
            cmd.Parameters.Add(parImagen);
            int Resultado = cmd.ExecuteNonQuery();
            conexion.Close();

            return Convert.ToBoolean(Resultado);

        }


        public static DataTable Consultar(DataGridView DATA)
        {
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;
            int Cont = dt.Rows.Count;
            Nombre = new string[Cont];
            Cedula = new string[Cont];
            TipoSangre = new string[Cont];
            Antecedentes = new string[Cont];
            Contacto = new string[Cont];
            Direccion = new string[Cont];
            conexion.Close();
            for (int i = 0; i < Cont; i++)
            {
                Nombre[i] = dt.Rows[i]["Nombre"].ToString();
                Cedula[i] = dt.Rows[i]["Cedula"].ToString();
                TipoSangre[i] = dt.Rows[i]["TipoSangre"].ToString();
                Antecedentes[i] = dt.Rows[i]["Antecedentes"].ToString();
                Contacto[i] = dt.Rows[i]["Contacto"].ToString();
                Direccion[i] = dt.Rows[i]["Direccion"].ToString();
                Face = (byte[])dt.Rows[i]["Imagen"];
                Listado.Add(Face);

            }


            try
            {
                DATA.Columns[0].Width = 60;
                DATA.Columns[1].Width = 160;
                DATA.Columns[2].Width = 160;
                DATA.Columns[3].Width = 160;
                DATA.Columns[4].Width = 160;
                DATA.Columns[5].Width = 160;
                DATA.Columns[6].Width = 160;

                for (int i = 0; i < Cont; i++)
                {

                    DATA.Rows[i].Height = 110;
                }
            }
            catch
            {

            }

            TotalFace = Cont;

            return dt;

        }


        ////

        public static byte[] ConvertImgToBinary(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            MemoryStream Memoria = new MemoryStream();
            bmp.Save(Memoria, ImageFormat.Bmp);

            byte[] imagen = Memoria.ToArray();

            return imagen;/// arreglo de Binario de la imagen

        }

        public static Image ConvertBinaryToImg(int C)
        {
            Image Imagen;
            byte[] img = Listado[C];
            MemoryStream Memoria = new MemoryStream(img);
            Imagen = Image.FromStream(Memoria);
            Memoria.Close();
            return Imagen;
        }

    }
}
