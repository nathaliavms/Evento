using System;

namespace Evento
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frase1 = Console.ReadLine().Split(" ");
            var dia1 = int.Parse(frase1[1]);

            string[] horarioInicial1 = Console.ReadLine().Split(":");
            var hora1 = int.Parse(horarioInicial1[0]);
            var minuto1 = int.Parse(horarioInicial1[1]);
            var segundo1 = int.Parse(horarioInicial1[2]);

            string[] frase2 = Console.ReadLine().Split(" ");
            var dia2 = int.Parse(frase2[1]);

            string[] horarioInicial2 = Console.ReadLine().Split(":");
            var hora2 = int.Parse(horarioInicial2[0]);
            var minuto2 = int.Parse(horarioInicial2[1]);
            var segundo2 = int.Parse(horarioInicial2[2]);

            var dia = 0;
            var hora = 0;
            if (dia2 - dia1 == 1 && (24 - (hora1 - hora2)) >= 24)
            {
                dia = (dia2 - dia1);
                hora = hora2 - hora1;
            }
            else
            {
                dia = (dia2 - dia1) - 1;
                hora = 24 - (hora1 - hora2);
            }
            var minuto = minuto2 - minuto1;
            var segundo = segundo2 - segundo1;
            Console.WriteLine(dia + " dia(s)");
            Console.WriteLine(hora + " horas(s)");
            Console.WriteLine(minuto + " minuto(s)");
            Console.WriteLine(segundo + " segundo(s)");
        } 
    }
}
