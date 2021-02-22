using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                EmpleadosDataContext DB = new EmpleadosDataContext();

                List<EMPLEADOS> listEmpleados = (from emp in DB.EMPLEADOS select emp).ToList();

                string mando;
                string proxparent = "inicio";
                string nombre;

                Console.WriteLine("Ingresa el nombre");
                nombre = Convert.ToString(Console.ReadLine().ToUpper());

                mando = listEmpleados.Where(x => x.Nombre.Trim() == nombre).First().Parent.Trim()+ ",";
                proxparent = listEmpleados.Where(x => x.Nombre.Trim() == nombre).First().Parent.Trim();

                
                do
                {
                  
                  string n = listEmpleados.Where(x => x.Nombre.Trim() == proxparent).First().Parent.Trim();

                  if (!string.IsNullOrEmpty(n))
                    {
                        mando += n + ",";
                        proxparent = n;
                    }else
                    {

                        break;
                    }
                   

                } while (!string.IsNullOrEmpty(proxparent));

                Console.WriteLine("Mando --> " +mando);
                Console.ReadLine();
            }
            catch(Exception ex)
            {

            }
        }
    }
}
