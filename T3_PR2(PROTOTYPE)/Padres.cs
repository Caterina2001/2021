using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_PR2_PROTOTYPE_
{
    public class Padres : ICloneable
    {
        //Declaracion de variables
        public string NombreP { get; set; }
        public string ApellidoP { get; set; }
        public int EdadP { get; set; }
        public string TrabajoP { get; set; }
        public string CedulaP { get; set; }
        public long  TelefonoP { get; set; }

        public Padres()  //Constructor de la clase con datos originales
        {
            NombreP = "Bruno";
            TelefonoP = 8097888955;
            ApellidoP = ("Giannecchini");
            EdadP = 50;
            TrabajoP = ("Analista de Sistema");
            CedulaP = ("001-1235289-7");
        }
     
        //Metodos
        public void Info() 
        {
            #region metodo1
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Informacion del padre registrada correctamente");
            #endregion
        }
        public void Presentacion(Boolean pre)
        {
            #region metodo2
            if (pre == true)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("El padre se ha presentado para asistir al alumno");
            }
            else
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("El padre no se ha presentado en la institucion");
            }
            #endregion

        }
        public void Inscripcion()
        {
            #region metodo3
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("El padre inscribio al alumno en el cuatrimestre");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }

        public object Clone()  //Clonacion
        {
            return this.MemberwiseClone();

        }
        public override string ToString()  //Impresion de los datos 
        {
            return $"Nombre: {this.NombreP}\nApellido: {this.ApellidoP}\nCedula:" +
                $" {this.CedulaP}\nTelefono: {this.TelefonoP}\nTrabajo: {this.TrabajoP}\nEdad: {this.EdadP}";
        }
    }
}
