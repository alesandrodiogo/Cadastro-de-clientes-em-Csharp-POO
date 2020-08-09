﻿using Calculo;
using Directorio;
using Funcoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tela
{
    class Menu
    {

        public const int SAIDA_PROGRAMA = 0;
        public const int LER_ARQUIVOS = 1;
        public const int TABUADA = 2;
        public const int CALCULO_MEDIA = 3;
        public const int CADASTRAR_CLIENTES = 4;

        public static void Criar()
        {

            //sair do programa
            while (true)
            {
                string mensagem = "Olá usuário, bem vindo ao programa\n" +
                    "\n   Utilizando programação funcional" +
                    "\n\n" +
                    "\n      Digite uma das opções abaixo:" +
                    "\n        0 - Sair do programa" +
                    "\n        1 - Para Ler arquivos" +
                    "\n        2 - Para executar a tabuada" +
                    "\n        3 - Calcular média de aluno"+
                    "\n        4 - Cadastrar clientes";
                Console.WriteLine(mensagem);
                int valor = int.Parse(Console.ReadLine());


                if (valor == SAIDA_PROGRAMA)
                {
                    break;
                }
                else if (valor == LER_ARQUIVOS)
                {
                    Console.WriteLine("================= Opção Ler arquivos =====================");
                    Arquivo.Ler(1);
                    Console.WriteLine("\n================================================\n");
                }
                else if (valor == TABUADA)
                {
                    Console.WriteLine("===================Opção tabuada ===================");
                    Console.WriteLine("Digite o número que deseja na tabuada");
                    int numero = int.Parse(Console.ReadLine());
                    Tabuada.Calcular(numero);
                    Console.WriteLine("\n================================================\n");
                }
                else if (valor == CALCULO_MEDIA)
                {
                    Media.Aluno();
                    Console.WriteLine("\n================================================\n");
                }
                else if (valor == CADASTRAR_CLIENTES)
                {
                    TelaCliente.Chamar();
                    Console.WriteLine("\n================================================\n");
                }
                else
                {
                    Console.WriteLine("Opção inválida digite novamente");
                }
            }
        }
    }
}
