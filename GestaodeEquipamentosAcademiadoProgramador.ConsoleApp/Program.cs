//Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar equipamentos
//• Deve ter um nome com no mínimo 6 caracteres;
//• Deve ter um preço de aquisição;
//• Deve ter um número de série;
//• Deve ter uma data de fabricação;
//• Deve ter uma fabricante;

//Requisito 1.2: Como funcionário, Junior quer ter a possibilidade de visualizar todos os equipamentos
//registrados em seu inventário.
//• Deve mostrar o nome;
//• Deve mostrar o número de série;
//• Deve mostrar a fabricante;

//Requisito 1.3: Como funcionário, Junior quer ter a possibilidade de editar um equipamento, sendo
//que ele possa editar todos os campos.
//• Deve ter os mesmos critérios que o Requisito 1.1

//Requisito 1.4: Como funcionário, Junior quer ter a possibilidade de excluir um equipamento que esteja
//registrado.
//• A lista de equipamentos deve ser atualizada
//• Caso o equipamento esteja vinculado num chamado, não deve permitir a exclusão deste
//equipamento.

using System;

namespace GestaodeEquipamentosAcademiadoProgramador.ConsoleApp
{
    internal class Program
    {
        #region Variaveis

        static string[] nomesequipamentos = new string[10];
        static decimal[] valoresquipamentos = new decimal[10];
        static string[] numerosdeseriesequip = new string[10];
        static string[] datasfabricacaoequip = new string[10];
        static string[] fabricantedoequip = new string[10];

        static string[] titulochamado = new string[10];
        static string[] descchamado = new string[10];
        static string[] nomesequipamentoschamado = new string[10];
        static decimal[] datadeaberturachamado = new decimal[10];

        static int[] numequip = new int[10];
        static int posicaoequip = 0;
        static int posicaochamado = 0;

        #endregion
        static void Main(string[] args)
        {
            while (true)
            {
                string opcao = ApresentarMenuPrincipal();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string opcaoSubMenu = ApresentarMenuEquipamentos();

                    if (opcaoSubMenu == "s")
                        continue;

                    if (opcaoSubMenu == "1")
                        InserirNovoEquipamento();

                    else if (opcaoSubMenu == "2")
                        VisualizarEquipamentos();

                    else if (opcaoSubMenu == "3")
                        EditarEquipamentos();

                    else if (opcaoSubMenu == "4")
                        ExcluirEquipamentos();
                }
                else if (opcao == "2")
                {
                    string opcaoSubMenu = ApresentarMenuChamados();

                    if (opcaoSubMenu == "s")
                        continue;

                    if (opcaoSubMenu == "1")
                        InserirNovoChamado();

                    else if (opcaoSubMenu == "2")
                        VisualizarChamados();

                    else if (opcaoSubMenu == "3")
                        EditarChamados();

                    else if (opcaoSubMenu == "4")
                        ExcluirChamados();
                }

                Console.ReadLine();
            }
        }

        #region Chamados
        private static void ExcluirChamados()
        {
            Console.Clear();

            Console.WriteLine("Excluindo Chamados:\n");

            Console.Write("Digite a posição do chamado que deseja excluir: ");
            int excluir = Convert.ToInt32(Console.ReadLine());

            for (int l = 0; l < titulochamado.Length; l++)
            {
                if (l == excluir)
                {
                    titulochamado[posicaochamado] = null;
                    descchamado[posicaochamado] = null;
                    nomesequipamentoschamado[posicaochamado] = null;
                    datadeaberturachamado[posicaochamado] = -1;
                    posicaoequip = posicaochamado + 1;

                }
            }

            Console.WriteLine("Sucesso! Pressione enter para retornar ao menu");
        }
        private static void EditarChamados()
        {
            Console.Clear();

            int editar;
            Console.Write("Digite a posição do chamado que deseja editar: ");
            editar = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Edite o Titulo do chamado " + editar + ": ");
                titulochamado[editar] = Console.ReadLine();
            } while (titulochamado[editar].Length < 6);

            Console.WriteLine();

            Console.Write("Edite a descrição do chamado " + editar + ": ");
            descchamado[editar] = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Edite o nome do Equipamento do chamado " + editar + ": ");
            nomesequipamentoschamado[editar] = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Edite a data de Abertura do chamado " + editar + ": ");
            datadeaberturachamado[editar] = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Sucesso! Pressione enter para retornar ao menu");
        }
        private static void VisualizarChamados()
        {
            Console.Clear();

            Console.WriteLine("Visualizando Chamados:\n");

            for (int posicao = 0; posicao < 10; posicao++)
            {
                if (titulochamado[posicao] != null)
                {
                    Console.WriteLine("Titulo do Chamado: " + titulochamado[posicao]);
                    Console.WriteLine("Descrição do Chamado: " + descchamado[posicao]);
                    Console.WriteLine("Nome Equipamento do Chamado: " + nomesequipamentoschamado[posicao]);
                    Console.WriteLine("Data de Abertura do Chamado: " + datadeaberturachamado[posicao]);
                    Console.WriteLine();
                }
            }
        }
        private static void InserirNovoChamado()
        {
            Console.Clear();

            Console.Write("Digite o Titulo do Chamado: ");
            string tituloc = Console.ReadLine();
            titulochamado[posicaochamado] = tituloc;

            Console.Write("Digite a descrição do Chamado: ");
            string desc = Console.ReadLine();
            descchamado[posicaochamado] = desc;

            Console.Write("Digite o nome do Equipamento do chamado: ");
            string nomequip = Console.ReadLine();
            nomesequipamentoschamado[posicaochamado] = nomequip;

            Console.Write("Digite a data de abertura do Chamado: ");
            decimal data = Convert.ToDecimal(Console.ReadLine());
            datadeaberturachamado[posicaochamado] = data;

            Console.WriteLine("Sucesso! Pressione enter para retornar ao menu");

            posicaochamado++;
        }

        #endregion

        #region Equipamentos
        private static void ExcluirEquipamentos()
        {
            Console.Clear();

            Console.WriteLine("Excluindo Equipamentos:\n");

            Console.Write("Digite a posição do equipamento que deseja excluir: ");
            int excluir = Convert.ToInt32(Console.ReadLine());

            for (int l = 0; l < nomesequipamentos.Length; l++)
            {
                if (l == excluir)
                {
                    nomesequipamentos[posicaoequip] = null;
                    valoresquipamentos[posicaoequip] = -1;
                    numerosdeseriesequip[posicaoequip] = null;
                    datasfabricacaoequip[posicaoequip] = null;
                    fabricantedoequip[posicaoequip] = null;
                    posicaoequip = posicaoequip + 1;
                }
            }

            Console.WriteLine("Sucesso! Pressione enter para retornar ao menu");
        }
        private static void EditarEquipamentos()
        {
            Console.Clear();

            int editar;
            Console.Write("Digite a posição do Equipamento que deseja editar: ");
            editar = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.Write("Edite o nome do equipamento " + editar + ": ");
                nomesequipamentos[editar] = Console.ReadLine();
            } while (nomesequipamentos[editar].Length < 6);

            Console.WriteLine();

            Console.Write("Edite o preço de aquisição do equipamento " + editar + ": ");
            valoresquipamentos[editar] = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Edite o numero de série do equipamento " + editar + ": ");
            numerosdeseriesequip[editar] = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Edite o dia de fabricação do equipamento " + editar + ": ");
            datasfabricacaoequip[editar] = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Edite o nome do fabricante " + editar + ": ");
            fabricantedoequip[editar] = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Sucesso! Pressione enter para retornar ao menu");
        }
        static void VisualizarEquipamentos()
        {
            Console.Clear();

            Console.WriteLine("Visualizando Equipamentos:\n");

            for (int posicao = 0; posicao < 10; posicao++)
            {
                if (nomesequipamentos[posicao] != null)
                {
                    Console.WriteLine("Nome: " + nomesequipamentos[posicao]);
                    Console.WriteLine("Preço: " + valoresquipamentos[posicao]);
                    Console.WriteLine("Número de Série: " + numerosdeseriesequip[posicao]);
                    Console.WriteLine("Data Fabricação: " + datasfabricacaoequip[posicao]);
                    Console.WriteLine("Fabricante: " + fabricantedoequip[posicao]);
                    Console.WriteLine();
                }
            }
        }
        static void InserirNovoEquipamento()
        {
            Console.Clear();

            Console.Write("Digite o nome do Equipamento: ");
            string nome = Console.ReadLine();
            nomesequipamentos[posicaoequip] = nome;

            Console.Write("Digite o preço do Equipamento: ");
            decimal preco = Convert.ToDecimal(Console.ReadLine());
            valoresquipamentos[posicaoequip] = preco;

            Console.Write("Digite o número de série do Equipamento: ");
            string numeroSerie = Console.ReadLine();
            numerosdeseriesequip[posicaoequip] = numeroSerie;

            Console.Write("Digite a data de fabricação do Equipamento: ");
            string data = Console.ReadLine();
            datasfabricacaoequip[posicaoequip] = data;

            Console.Write("Digite o fabricante do Equipamento: ");
            string fabricante = Console.ReadLine();
            fabricantedoequip[posicaoequip] = fabricante;

            Console.WriteLine("Sucesso! Pressione enter para retornar ao menu");

            posicaoequip++;
        }
        #endregion
        static string ApresentarMenuEquipamentos()
        {
            Console.Clear();

            Console.WriteLine("Digite 1 para Inserir novo Equipamento");
            Console.WriteLine("Digite 2 para Visualizar Equipamentos");
            Console.WriteLine("Digite 3 para Editar um Equipamento");
            Console.WriteLine("Digite 4 para Exluir um Equipamento");

            Console.WriteLine("Digite s para Sair");

            string opcaoSubMenu = Console.ReadLine();

            return opcaoSubMenu;
        }
        private static string ApresentarMenuChamados()
        {
            Console.Clear();

            Console.WriteLine("Digite 1 para Inserir novo Chamado");
            Console.WriteLine("Digite 2 para Visualizar Chamados");
            Console.WriteLine("Digite 3 para Editar um Chamado");
            Console.WriteLine("Digite 4 para Exluir um Chamado");

            Console.WriteLine("Digite s para Sair");

            string opcaoSubMenu = Console.ReadLine();

            return opcaoSubMenu;
        }
        static string ApresentarMenuPrincipal()
        {
            Console.Clear();

            Console.WriteLine("Digite 1 para Cadastro de Equipamentos");
            Console.WriteLine("Digite 2 para Controle de Chamados");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

    }
}