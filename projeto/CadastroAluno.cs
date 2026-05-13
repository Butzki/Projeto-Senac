
using System.Runtime.InteropServices;

public class CadastroAluno
{
 public string NomeAluno { get; private set;}
    public int Idade { get; private set;}
    public string CPF { get; private set;}
    public List<string> Endereco {get; private set;} = new List<string> { "", "", "", "", "", "" };
    public string CEP {get; private set;}
    public string Cidade {get; private set;}
    public string Bairro {get; private set;}
    public string Rua {get; private set;}
    public string Numero {get; private set;}
    public string Complemento {get; private set;}

    public void DefinirNome(string novoNome)
    {
        if (!string.IsNullOrWhiteSpace(novoNome))
        {
            this.NomeAluno = novoNome;
        }
    }
    public void DefinirIdade(int novaIdade)
        {
            if (novaIdade >=16 && novaIdade <120)
            {
                this.Idade = novaIdade;
            }
        }
    public void DefinirCPF(string novoCPF)
        {
            if (!string.IsNullOrWhiteSpace(novoCPF))
            {
                this.CPF = novoCPF;
            }
        }

  public void DefinirEndereco(string novoCEP, string novaCidade, string novoBairro, string novaRua, string novoNumero, string novoComplemento)
        {
            if (!string.IsNullOrWhiteSpace(novoCEP))
            {
                this.Endereco[0] = novoCEP;
            }
 
            if (!string.IsNullOrWhiteSpace(novaCidade))
            {
                this.Endereco[1] = novaCidade;
            }
 
            if (!string.IsNullOrWhiteSpace(novoBairro))
            {
                this.Endereco[2] = novoBairro;
            }
 
            if (!string.IsNullOrWhiteSpace(novaRua))
            {
                this.Endereco[3] = novaRua;
            }
 
            if (!string.IsNullOrWhiteSpace(novoNumero))
            {
                this.Endereco[4] = novoNumero;
            }
 
            if (!string.IsNullOrWhiteSpace(novoComplemento))
            {
                this.Endereco[5] = novoComplemento;
            }
        }

}
