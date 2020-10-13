using System;

namespace IMC_Desicao
{
    class Program
    {
        static void Main(string[] args)
        {
            double  pesoUsuario, alturaUsuario, imcUsuario;
            string  pesoTexto, alturaTexto;
            bool pesoValido, alturaValida;

            Console.Clear();
            Console.WriteLine("--- Calcular IMC");

            Console.Write("Digite seu peso em KG...: ");
            pesoTexto = Console.ReadLine();
            Console.Write("Digite sua altura em m..: ");
            alturaTexto = Console.ReadLine();

            pesoValido = Double.TryParse(pesoTexto, out pesoUsuario);
            alturaValida = Double.TryParse(alturaTexto, out alturaUsuario);
            
            imcUsuario = pesoUsuario / (alturaUsuario * alturaUsuario);
            

            if (!pesoValido || !alturaValida)
            {
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Valor(es) informado(s) inválido(s)");
               Console.ResetColor();
            }
            else if (imcUsuario < 17)
            {
               Console.WriteLine($"Seu IMC é {imcUsuario.ToString("F")} kg/m²");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Diagnóstico: Muito abaixo do peso");
               Console.ResetColor();
            }
            else if (imcUsuario >= 17 && imcUsuario <= 18.45)
            {
               Console.WriteLine($"Seu IMC é {imcUsuario} kg/m²");
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("Diagnóstico: Abaixo do peso");
               Console.ResetColor();
            }
            else if (imcUsuario >= 18.50 && imcUsuario <= 24.99)
            {
              Console.WriteLine($"Seu IMC é {imcUsuario} kg/m²");
               Console.ForegroundColor = ConsoleColor.Green;
               Console.WriteLine("Diagnóstico: Peso normal");
               Console.ResetColor();
            }
            else if (imcUsuario >= 25 && imcUsuario <= 29.99)
            {
               Console.WriteLine($"Seu IMC é {imcUsuario} kg/m²");
               Console.ForegroundColor = ConsoleColor.Yellow;
               Console.WriteLine("Diagnóstico: Acima do peso");
               Console.ResetColor();
            }
            else if (imcUsuario >= 30 && imcUsuario <= 34.99)
            {
               Console.WriteLine($"Seu IMC é {imcUsuario} kg/m²");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Diagnóstico: Obesidade grau I");
               Console.ResetColor();
            }
            else if (imcUsuario >= 35 && imcUsuario <= 39.99)
            {
               Console.WriteLine($"Seu IMC é {imcUsuario} kg/m²");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Diagnóstico: Obesidade grau II (severa)");
               Console.ResetColor();
            }
            else if (imcUsuario > 40)
            {
               Console.WriteLine($"Seu IMC é {imcUsuario} kg/m²");
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Diagnóstico: Obesidade grau III (mórbida)");
               Console.ResetColor();
            }

            Console.WriteLine("Obrigado por usar meu programa...");
        }
    }
}
