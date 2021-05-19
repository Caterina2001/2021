using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_PR2_PROTOTYPE_
{
    public class Alumnos : ICloneable
    {
        //Declaracion de los atributos
        public string NombreA { get; set; }
        public string ApellidoA { get; set; }
        public int EdadA { get; set; }
        public string CarreraA { get; set; }
        public string MatriculaA { get; set; }
        public long TelefonoA { get; set; }
        public Boolean final;
        public Padres Ppadres { get; set; }  //Llamado a la clase padres para tomar valores luego

        public Alumnos()  //Datos originales en el constructor
        {           
            NombreA = "Caterina";
            ApellidoA = "Rosario";
            EdadA = 19;
            CarreraA = "Software";
            MatriculaA = "2019-8106";
            TelefonoA = 8093095630;
        }

        public object Clone()  //Metodo para clonar
        {
            Alumnos al = (Alumnos)this.MemberwiseClone();
            //Tomar el nombre y apellido del padre
            al.Ppadres = new Padres();
            al.Ppadres.NombreP = Ppadres.NombreP;
            al.Ppadres.TelefonoP = Ppadres.TelefonoP;
            return al;
        }

        // Metodos
        public void Finalizacion(Boolean fin)  
        {
            #region metodo1
            if (fin == true)
            {
                final = true;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("El alumno aprobo' el cuatrimestre");
            }
            else
            {
                final = false;
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("No Aprobo' el cuatrimestre");
            }
            #endregion
        }
        public void PagoMensual(Boolean pago)
        {
            #region metodo2
            if (pago == true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("El alumno esta' al dia con el pago");
            }
            else
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("El alumno debe pagar la mensualidad");
            }
            #endregion
        }
        public void Actividad()
        {
            #region metodo3
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Este alumno esta activo en el sistema");
            Console.ReadKey();
            Console.Clear();
            #endregion 
        }

        public override string ToString()
        {
            return $"Nombre: {this.NombreA} \nApellido: { this.ApellidoA} \nMatricula: {this.MatriculaA} " +
                $"\nCarrera: {this.CarreraA} \nTelefono: {this.TelefonoA} \nEdad: {this.EdadA} \nPadre: {this.Ppadres.NombreP}" +
                $"\nTelefono Padre: {this.Ppadres.TelefonoP}";
        }
    }
}
