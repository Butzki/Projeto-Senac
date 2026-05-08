//ATIVIDADE 08/05 - Sistema de Gestão de Alunos - Projeto Final
//Cadastro, Listagem e Alteração de Cadastro

//Alocações
Gerenciador Cadastro = new Gerenciador();
bool sair = false;
string input;
//Fernando é um gayzão

while (true)
{   
    //Exibe lista de alunos existentes
    Cadastro.ExibirDados();

    //Triagem
    do
    {
        Console.WriteLine("Deseja adicionar(1) um novo aluno ou consultar(2) um aluno existente?");
     input = (Console.ReadLine() ?? "").ToLower();
    } while (input != "1" && input != "2");

    if (input == "1")
    {
        Cadastro.ColetarNome();
        Cadastro.ColetarIdade();
        Cadastro.ColetarCpf();
    }   
    else
    {
        if (Alunos == null)
        {
            Console.WriteLine("Não existem alunos para serem consultados");
        }
        else
        {
            Console.WriteLine("Qual aluno deseja consultar?");

        }
    }
}

