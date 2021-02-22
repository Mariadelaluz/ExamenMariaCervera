using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DepositosDataContext DB = new DepositosDataContext();

                List<bank_deposits> listdepositos = (from b in DB.bank_deposits orderby b.amount select b).ToList();
                int depositos=0;
                int sumDep = 0;
                int promDep = 0;
                int DepCinc = 0;
                int SumDepCinc = 0;
                int PromDepCinc = 0;

                foreach (string nombre in listdepositos.Select(x=>x.account_holder).Distinct())
                {
                    Console.WriteLine("Nombre titular --> " + nombre);
                    Console.WriteLine("monto minimo --> " + listdepositos.Where(x => x.account_holder == nombre).First().amount);
                    Console.WriteLine("monto maximo --> " + listdepositos.Where(x => x.account_holder == nombre).Last().amount );
                    Console.WriteLine("Numero de depositos --> " + listdepositos.Where(x => x.account_holder == nombre).Count());

                    if(listdepositos.Where(x => x.account_holder == nombre).Count()>1)
                    {
                        depositos += listdepositos.Where(x => x.account_holder == nombre).Select(x => x.amount).Sum();
                        sumDep += listdepositos.Where(x => x.account_holder == nombre).Count();

                    }
                }

                promDep = depositos / sumDep;
                Console.WriteLine("Promedio usuarios que tuvieron más de un depósito--> " + promDep);

                DepCinc= listdepositos.Where(x => x.amount > 50).Select(x => x.amount).Sum();
                SumDepCinc = listdepositos.Where(x => x.amount > 50).Select(x => x.amount).Count();
                PromDepCinc = DepCinc / SumDepCinc;
                Console.WriteLine("Promedio de depósitos realizados supero los $50--> " + PromDepCinc);


                Console.ReadLine();
                    
            }catch(Exception ex)
            {

            }

        }

    }
}
