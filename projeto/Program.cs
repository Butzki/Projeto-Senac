//Sistema de Gestão de Alunos - Projeto Final
//Cadastro, Listagem e Alteração de Cadastro

Gerenciador gerenciador = new();
bool executando = true;

while (executando)
{
    Console.WriteLine("O que você quer fazer?");
    Console.WriteLine("[1] Cadastrar novo aluno");
    Console.WriteLine("[2] Listar alunos");
    Console.WriteLine("[3] Alterar cadastro");
    Console.WriteLine("[4] Excluir aluno");
    Console.WriteLine("[0] Sair");
    Console.Write("Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            gerenciador.AdicionarAluno();
            Console.WriteLine("Cadastro de Novo Aluno");
            gerenciador.ColetarNome();
            gerenciador.ColetarIdade();
            gerenciador.ColetarCPF();
            gerenciador.ColetarEndereco();
            Console.WriteLine("Aluno cadastrado com sucesso!");
            break;

        case "2":
            Console.WriteLine("Lista de Alunos");
            gerenciador.ExibirDados();
            break;

        case "3":
            Console.WriteLine("Alterar Cadastro");
            gerenciador.ExibirDados();
            Console.Write("Digite o índice do aluno que deseja alterar: ");
            if (int.TryParse(Console.ReadLine(), out int indiceAlterar))
            {
                gerenciador.SelecionarAlunoPorIndice(indiceAlterar);

                bool alterando = true;
                while (alterando)
                {
                    Console.WriteLine("O que deseja alterar?");
                    Console.WriteLine("[1] Nome");
                    Console.WriteLine("[2] Idade");
                    Console.WriteLine("[3] CPF");
                    Console.WriteLine("[4] Endereço");
                    Console.WriteLine("[0] Voltar");
                    Console.Write("Escolha: ");

                    switch (Console.ReadLine())
                    {
                        case "1": gerenciador.ColetarNome();     break;
                        case "2": gerenciador.ColetarIdade();    break;
                        case "3": gerenciador.ColetarCPF();      break;
                        case "4": gerenciador.ColetarEndereco(); break;
                        case "0": alterando = false;             break;
                        default: Console.WriteLine("Opção inválida."); break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            break;

        case "4":
            Console.WriteLine("Excluir Aluno");
            gerenciador.ExibirDados();
            Console.Write("Digite o índice do aluno que deseja excluir: ");
            if (int.TryParse(Console.ReadLine(), out int indiceExcluir))
            {
                gerenciador.SelecionarAlunoPorIndice(indiceExcluir);
                Console.Write("Tem certeza? (s/n): ");
                if (Console.ReadLine()?.ToLower() == "s")
                {
                    gerenciador.ExcluirCadastro();
                }
                else
                {
                    Console.WriteLine("Exclusão cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Índice inválido.");
            }
            break;

        case "0":
            executando = false;
            Console.WriteLine("Encerrando o sistema. Até logo!");
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}
