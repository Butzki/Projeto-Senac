public class Gerenciador
{
    private List<CadastroAluno> Alunos { get; set; } = new List<CadastroAluno>();
    public int alunoSelecionado = -1;
    CadastroAluno aluno;

    public void ExibirDados()
    {
        if (Alunos == null)
        {
            Console.WriteLine("Não existem alunos para serem consultados");
        }
        else
        {
            for (int i = 0; i < Alunos.Count; i++)
            {
               Console.WriteLine($"[{i}] - {Alunos[i].NomeAluno}");
            }                   
        }
    }
    public void SelecionarAlunoPorIndice(int indice)
    {
        if (indice >= 0 && indice < Alunos.Count)
        {
            this.alunoSelecionado = indice;
            Console.WriteLine($"Aluno {Alunos[indice].NomeAluno} selecionado para edição.");
        }
    }
    public void AdicionarAluno()
    {
        aluno = new CadastroAluno();
        Alunos.Add(aluno);
        alunoSelecionado = Alunos.Count - 1;
    }
    public void ColetarNome()
    {
        if (alunoSelecionado >= 0 && alunoSelecionado < Alunos.Count)
        {
            Console.WriteLine("Digite o nome:");
            string input = Console.ReadLine();
            Alunos[alunoSelecionado].DefinirNome(input);
        }
        else
        {
            Console.WriteLine("Nenhum aluno selecionado.");
        }
    }
    public void ColetarIdade()
    {
        if (alunoSelecionado >= 0 && alunoSelecionado < Alunos.Count)
        {
            Console.WriteLine("Digite a idade:");
            string input = Console.ReadLine();
            Alunos[alunoSelecionado].DefinirIdade(Convert.ToInt32(input));
        }
        else
        {
            Console.WriteLine("Nenhum aluno selecionado.");
        }
    }
        public void ColetarCPF()
    {
        if (alunoSelecionado >= 0 && alunoSelecionado < Alunos.Count)
        {
            Console.WriteLine("Digite o CPF:");
            string input = Console.ReadLine();
            Alunos[alunoSelecionado].DefinirCPF(input);
        }
        else
        {
            Console.WriteLine("Nenhum aluno selecionado.");
        }
    }
    public void ExcluirCadastro()
    {
        if (alunoSelecionado >= 0 && alunoSelecionado < Alunos.Count)
        {
            Alunos.RemoveAt(alunoSelecionado);
            Console.WriteLine("Aluno removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Nenhum aluno selecionado.");
        }        
    }
public void ColetarEndereco()
    {
        if (alunoSelecionado >= 0 && alunoSelecionado < Alunos.Count)
        {
            Console.WriteLine("Digite o CEP:");
            string cep = Console.ReadLine();
       
            Console.WriteLine("Digite a Cidade:");
            string cidade = Console.ReadLine();
 
            Console.WriteLine("Digite o Bairro:");
            string bairro = Console.ReadLine();
 
            Console.WriteLine("Digite a Rua:");
            string rua = Console.ReadLine();
 
            Console.WriteLine("Digite o Número:");
            string numero = Console.ReadLine();
 
            Console.WriteLine("Digite o Complemento:");
            string complemento = Console.ReadLine();
            
            Alunos[alunoSelecionado].DefinirEndereco(cep, cidade, bairro, rua, numero, complemento);
        }
        else
        {
            Console.WriteLine("Nenhum aluno selecionado.");
        }
    }
}
