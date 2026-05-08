
class Gerenciador : CadastroAluno
{
    public List<CadastroAluno> Alunos = new List<CadastroAluno>();
    public CadastroAluno Aluno = new CadastroAluno();

    public void ExibirDados()
    {
        if (Alunos == null)
        {
            Console.WriteLine("Não existem alunos para serem consultados");
        }
        else
        {
            int i = 0; //Serve para enumerar os alunos, indicando assim suas posições na lista
            foreach (CadastroAluno elemento in Alunos)
            {
                Console.WriteLine(i + elemento.NomeAluno); //Acessar Proteção
                i++;
            } 
        }
    }

    public void ColetarNome()
    {
        Console.WriteLine("Digite o nome do aluno.");
        Alunos.Add(new CadastroAluno());
        Alunos.Last().NomeAluno = Console.ReadLine(); //Acessar Proteção
        Console.WriteLine($"Nome {Alunos.NomeAluno} adiconado!"); //Acessar Proteção
    }  

    public void ColetarIdade()
    {
        Console.WriteLine("Digite a idade do aluno.");
        Alunos.Last().Idade = Console.ReadLine(); //Acessar Proteção
        Console.WriteLine($"Nome {Alunos.NomeAluno} adiconado!"); //Acessar Proteção
    } 

    public void ColetarCpf()
    {
        Console.WriteLine("Digite o nome do aluno.");
        Alunos.Last().Cpf = Console.ReadLine(); //Acessar Proteção
        Console.WriteLine($"Nome {Alunos.NomeAluno} adiconado!"); //Acessar Proteção 
    }

    public void ColetarEndereco()
    {
     
    }
}

//Codigo está montado para adicionar os dados para o aluno mais recente, porém deve ser alterado para adicionar dados ao aluno indexado
//Assim, será possível reutilizar os mesmos métodos seja para adicionar um aluno novo ou editar uma informação ja existente;