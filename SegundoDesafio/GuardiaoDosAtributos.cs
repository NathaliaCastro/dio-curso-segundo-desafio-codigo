using System;

class GuardiaoDosAtributos
{
    static bool VerificarAtributo(string atributo, int valorMinimo, int valorMaximo, int valorAtributo)
    {
        //TODO: Implemente a função VerificarAtributo
        
          //Validando valor do atributo (ambas as condições tem que ser verdadeira)
        if (valorAtributo >= valorMinimo && valorAtributo < valorMaximo)
        {
            // Se valor do atributo estiver ENTRE o valor MÍNIMO e MÁXIMO, retornar TRUE
          Console.WriteLine("O valor do atributo está dentro do intervalo especificado"); 
          return true;
        }
        else {
            // Se valor do atributo não estiver ENTRE o valor MÍNIMO e MÁXIMO, retornar FALSE
          Console.WriteLine("O valor do atributo está fora do intervalo especificado");
          return false;
        }
    }

    static void Main(string[] args)
    {
        string atributo = Console.ReadLine();

        int valorMinimo = int.Parse(Console.ReadLine());

        int valorMaximo = int.Parse(Console.ReadLine());

        int valorAtributo = int.Parse(Console.ReadLine());

        VerificarAtributo(atributo, valorMinimo, valorMaximo, valorAtributo);
    }
}
