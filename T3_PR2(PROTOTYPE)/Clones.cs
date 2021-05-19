using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace T3_PR2_PROTOTYPE_
{
    public class Clones //Clase especialmente para realizar los clones
    {
        //Creacion de os archivos TXT que guardaran
        public static StreamWriter AlumnosTXT = File.AppendText("Alumnos.txt");
        public static StreamWriter PadresTXT = File.AppendText("Padres.txt");


        public void InicioClonesPadres()  //metodo clones de padre
        {
            #region clonesPadres
            Console.WriteLine("----------------PADRE ORIGINAL----------------");
            PadresTXT.WriteLine("----------------PADRE GREYLIN----------------");
            Padres padress = new Padres();  //llamado de la clase de padres
            Console.WriteLine(padress);  //impresion del primer padre original
            PadresTXT.WriteLine(padress);
           
            //clones
            Padres padres1 = (Padres)padress.Clone();
            padres1.NombreP = "Pedro Jose";
            padres1.TrabajoP = "Arquitecto";
            Console.WriteLine("--------------------CLON----------------------");
            PadresTXT.WriteLine("--------------------CLON----------------------");

            Console.WriteLine(padres1);
            PadresTXT.WriteLine(padres1);

            Padres padres2 = (Padres)padress.Clone();
            padres2.CedulaP = "021-4802973-0";
            padres2.TelefonoP = 8493728362;
            Console.WriteLine("--------------------CLON----------------------");
            PadresTXT.WriteLine("--------------------CLON----------------------");
            Console.WriteLine(padres2);
            PadresTXT.WriteLine(padres2);

            Padres padres3 = (Padres)padress.Clone();
            padres3.ApellidoP = "Suarez";
            padres3.EdadP = 35;
            Console.WriteLine("--------------------CLON----------------------");
            PadresTXT.WriteLine("--------------------CLON----------------------");
            Console.WriteLine(padres3);
            PadresTXT.WriteLine(padres3);

            PadresTXT.Close();
            Console.ReadKey();
            Console.Clear();

            #endregion

        }
        public void InicioClonesAlumnos()  //Metodo clones de alumnos
        {
            #region clonesAlumnos
            Console.WriteLine("---------------ALUMNO ORIGINAL---------------");
            AlumnosTXT.WriteLine("---------------ALUMNO ORIGINAL---------------");
            Alumnos alu1 = new Alumnos()  //llamado a la clase de alumnos
            {
                Ppadres = new Padres()  //permitira agregar informacion del padre

            };

            //agregacion del nombre y el telefono
            alu1.Ppadres.NombreP = "Bruno";
            alu1.Ppadres.TelefonoP = 8097888955;
            Console.WriteLine(alu1);  //impresion del alumno registrado original
            AlumnosTXT.WriteLine(alu1);
       
            //clones
            Alumnos clon1 = (Alumnos)alu1.Clone();
            Console.WriteLine("--------------------CLON----------------------");
            AlumnosTXT.WriteLine("--------------------CLON----------------------");
            clon1.NombreA = "Jason";
            clon1.Ppadres.TelefonoP = 8491258722;
            Console.WriteLine(clon1);
            AlumnosTXT.WriteLine(clon1);

            Alumnos clon2 = (Alumnos)alu1.Clone();
            clon2.CarreraA = "Multimedia";
            clon2.Ppadres.NombreP = "Mayra";
            Console.WriteLine("--------------------CLON----------------------");
            AlumnosTXT.WriteLine("--------------------CLON----------------------");
            Console.WriteLine(clon2);
            AlumnosTXT.WriteLine(clon2);

            Alumnos clon3 = (Alumnos)alu1.Clone();
            clon3.NombreA = "Jonathan";
            clon3.MatriculaA = "2019-87795";
            clon3.Ppadres.NombreP = "Fiorenzo";
            Console.WriteLine("--------------------CLON----------------------");
            AlumnosTXT.WriteLine("--------------------CLON----------------------");
            Console.WriteLine(clon3);
            AlumnosTXT.WriteLine(clon3);

            AlumnosTXT.Close();
            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("DATOS REGISTRADOS EXITOSAMENTE EN TXT");
            Console.ReadKey();

            #endregion
        }
        
    }
}
