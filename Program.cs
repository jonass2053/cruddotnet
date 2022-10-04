using CURD_DOCNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_DOCNET
{
    public class Program
    {

        static void Main (string[] args)
        {

            
            foreach (var item in CrudNota.GetAll())
            {

                Console.WriteLine($" Id: {item.Id}, \n Nombre: {item.Nombre},\n Apellido: {item.Apellido}, \n Matricula: {item.Matricula}, \n Curso: {item.Curso}, \n Nota: {item.nota}");
                Console.WriteLine("************************************");
                

            }


          Nota newnota= CrudNota.GetById(7);
          Console.WriteLine("***************GetById*********************");
          Console.WriteLine($" Id: {newnota.Id}, \n Nombre: {newnota.Nombre},\n Apellido: {newnota.Apellido}, \n Matricula: {newnota.Matricula}, \n Curso: {newnota.Curso}, \n Nota: {newnota.nota}");
          Console.WriteLine("************************************");


            

        }
    }
}
