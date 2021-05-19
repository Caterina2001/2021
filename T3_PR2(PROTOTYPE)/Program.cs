using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3_PR2_PROTOTYPE_  //CATERINA GIANNECCHINI ROSARIO, 2019-8106, GRUPO 7, TAREA 3, PROGRAMACION II.
{
    class Program
    {
        static void Main(string[] args)
        {    
            //Llamado de cada clase

            Alumnos alumnos = new Alumnos(); 
            alumnos.Finalizacion(true);
            alumnos.PagoMensual(true);
            alumnos.Actividad();

            Padres padres = new Padres();
            padres.Info();
            padres.Presentacion(false);
            padres.Inscripcion();

            Clones clones = new Clones();
            clones.InicioClonesPadres();
            clones.InicioClonesAlumnos();
        }     
    }
}
