using System;

class CalculandoDano
{
    static int CalcularDano(int ataque, int defesa)
    {
        //TODO: Implemente a função calcular dano        
        int dano = ataque - defesa;
          //Dano recebe o resultado de ATAQUE - DEFESA

          //Validando o valor do dano
        if (dano < 0) 
        {
            // Se DANO for menor que ZERO, retornar 0
            return 0;
        }
        else 
        {
            //Se DANO for MAIOR que ZERO, retornar o VALOR DANO
            return dano;
        }
    }

    static void Main(string[] args)
    {
			//Fora da plataforma: Console.WriteLine("Informe o valor do ataque: ");
        int ataque = int.Parse(Console.ReadLine());

			//Fora da plataforma: Console.WriteLine("Informe o valor de defesa: ");
        int defesa = int.Parse(Console.ReadLine());

        int danoCausado = CalcularDano(ataque, defesa);
        Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);
    }
}
