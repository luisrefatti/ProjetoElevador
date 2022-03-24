using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // sistema que simula um elevador de um prédio

            // variáveis do projeto
            int usuario = 1;
            int andarTotal = 5;
            Double atualPessoas = 0;
            int capacidadeDePessoas = 10;
            bool continuar = true;

            // antes de prosseguir com o programa, o usuário deverá informar a quantidade de pessoas no elevador
            Console.WriteLine("Digite a quantidade de pessoas no elevador atualmente: ");
            atualPessoas = Convert.ToDouble(Console.ReadLine());

            // capacidade de pessoas
            if (atualPessoas >= 10)
            {
                // se o número de pessoas no elevador for igual e/ou maior que "10", o código completo não será executado
                Console.WriteLine("O elevador está lotado.");
                return;
            }

            do
            {
                // sistema/menu no qual o usuário poderá visualizar e interagir
                Console.WriteLine(@" 
                                     Seja bem-vindo(a) ao KingElevator!
                                     Digite abaixo para onde você deseja ir:
                                     0 - Térreo
                                     1 - Primeiro andar
                                     2 - Segundo andar
                                     3 - Terceiro andar
                                     4 - Quarto andar
                                     5 - Quinto andar

                                     Para verificar informações adicionais do KingElevator, digite:
                                     6 - Total de andares no prédio
                                     7 - Capacidade total de pessoas no elevador
                                     8 - Número de pessoas no elevador atualmente

                                     Caso queira sair do elevador, digite:
                                     9 - Sair");

                string escolha = Console.ReadLine();
                Console.Clear();

                // visualização da opção escolhida pelo usuário
                switch (escolha)
                {
                    case "0": Console.WriteLine("Agora você está no térreo."); break;
                    case "1": Console.WriteLine("Agora você está no primeiro andar (setor administrativo)."); break;
                    case "2": Console.WriteLine("Agora você está no segundo andar (setor jurídico)."); break;
                    case "3": Console.WriteLine("Agora você está no terceiro andar (setor financeiro)."); break;
                    case "4": Console.WriteLine("Agora você está no quarto andar (setor do marketing)."); break;
                    case "5": Console.WriteLine("Agora você está no melhor andar (setor de TI)."); break;
                    case "6": Console.WriteLine("O prédio possui um total de " + andarTotal + " andares."); break;
                    case "7": Console.WriteLine("A capacidade total do elevador é de " + capacidadeDePessoas + " pessoas simultaneamnte."); break;
                    case "8": Console.WriteLine("O elevador está com " + (atualPessoas + usuario) + " pessoas atualmente."); break;
                    // se o usuário digitar "9", o código acaba
                    case "9": continuar = false; break;
                    // caso o usuário escreva algum valor que não foi aqui atribuido, esta mensagem será exibida:
                    default: Console.WriteLine("A sua escolha não é válida. Digite novamente:"); break;


                }
            }

            while (continuar);


            // that's all folks!

        }

    }
}