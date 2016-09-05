using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int año;
            int diaAcutal = DateTime.Now.Day;
            int mesActual = DateTime.Now.Month;
            int añoActual = DateTime.Now.Year;
            int contador;
            int acumuladorAño = 0;
            int acumuladorMes = 0;
            int total;

            dia = int.Parse(Console.ReadLine());
            mes = int.Parse(Console.ReadLine());
            año = int.Parse(Console.ReadLine());

            //año = añoActual - año;

            for(contador=año+1; contador<=añoActual;contador++)
            {
                if (contador % 4 == 0)
                    acumuladorAño += 366;
                else if (contador % 100 == 0 && contador % 400 == 0)
                    acumuladorAño += 366;
                else
                    acumuladorAño += 365;
            }

            //mes = (mesActual - mes) * 30;

            if(mesActual<mes)
            {
                for(contador=mesActual+1;contador<mes;contador++)
                {
                    switch(contador)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            acumuladorMes += 31;
                            break;
                        case 2:
                            acumuladorMes += 28;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            acumuladorMes += 30;
                            break;                     
                    }
                }
            }

            if (mes < mesActual)
            {
                for (contador = mes; contador < mesActual; contador--)
                {
                    switch (contador)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            acumuladorMes += 31;
                            break;
                        case 2:
                            acumuladorMes += 28;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            acumuladorMes += 30;
                            break;
                    }
                }
                acumuladorMes = acumuladorMes * (-1);
            }

            dia = diaAcutal - dia;


            total = acumuladorAño + dia + acumuladorMes;

            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
