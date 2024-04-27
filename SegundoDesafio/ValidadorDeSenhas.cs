﻿using System;

class ValidadorDeSenhas
{
    static string VerificarForcaSenha(string senha)
    {
        int comprimentoMinimo = 8;
        bool temLetraMaiuscula = false;
        bool temLetraMinuscula = false;
        bool temNumero = false;
        bool temCaractereEspecial = false;

        // TODO: Verifique o comprimento da senha
        
			//Verificando o tamanho da senha inserida
        if (senha.Length < comprimentoMinimo) {
			// Se o tamanho da SENHA for MENOR que o tamanho MÍNIMO, retornar SENHA CURTA
          return "	Sua senha e muito curta. Recomenda-se no minimo 8 caracteres.";
        }

        // Verificando se a senha contém letras maiúsculas e minúsculas
        temLetraMaiuscula = senha.Any(char.IsUpper);
        temLetraMinuscula = senha.Any(char.IsLower);

        // Verificando se a senha contém sequências comuns
        string[] sequenciasComuns = { "123456", "abcdef" };
        if (sequenciasComuns.Any(s => senha.Contains(s)))
            return "Sua senha contem uma sequencia comum. Tente uma senha mais complexa.";

        // Verificando se a senha contém palavras comuns
        string[] palavrasComuns = { "password", "123456", "qwerty", "senha" };
        if (palavrasComuns.Contains(senha))
            return "Sua senha e muito comum. Tente uma senha mais complexa.";

        // Verificando se a senha contém números e caracteres especiais
        temNumero = senha.Any(char.IsDigit);
        temCaractereEspecial = senha.Any(c => !char.IsLetterOrDigit(c));

        if (temLetraMinuscula && temLetraMaiuscula && temNumero && temCaractereEspecial)
            return "Sua senha atende aos requisitos de seguranca. Parabens!";
        else
            return "Sua senha nao atende aos requisitos de seguranca.";
    }

    static void Main(string[] args)
    {
        string senha = Console.ReadLine().Trim();

        string resultado = VerificarForcaSenha(senha);

        Console.WriteLine(resultado);
    }
}