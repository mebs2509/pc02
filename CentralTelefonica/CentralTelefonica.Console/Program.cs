using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralTelefonica.Entities;
using CentralTelefonica.Context;
using System.Threading;

namespace CentralTelefonica.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            var central = new Central();

            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine("===================CENTRAL TELEFONICA==================");
            System.Console.WriteLine("===================COMPAÑIA EMAC S.A.==================");
            System.Console.WriteLine("=======================================================");
            System.Console.WriteLine("=======================================================\n");
            System.Console.WriteLine("****************Visualizacion de LLamadas**************\n");      

            var fono1 = "4653621";
            var fono2 = "3485078";

            var fono3 = "999468925";
            var fono4 = "987542539";
            var fono5 = "926857423";

            central.Agregar(fono1);
            central.Agregar(fono2);
            central.Agregar(fono3);
            central.Agregar(fono4);
            central.Agregar(fono5);

            central.IniciarLlamada(fono1);
            Thread.Sleep(10000);
            central.FinalizarLlamada(fono1);

            central.IniciarLlamada(fono3);
            Thread.Sleep(2000);
            central.FinalizarLlamada(fono3);

            central.IniciarLlamada(fono4);
            Thread.Sleep(9000);
            central.FinalizarLlamada(fono4);

            central.IniciarLlamada(fono5);
            Thread.Sleep(4000);
            central.FinalizarLlamada(fono5);

            central.IniciarLlamada(fono2);
            Thread.Sleep(3000);
            central.FinalizarLlamada(fono2);

            System.Console.ReadLine();

        }
    }
}
