using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

class CadastroAluno
{
    private string NomeAluno { get; set;}
    private int Idade { get; set;}
    private string Cpf { get; set;}
    private List<string> Endereco {get; set;} = new List<string>();
    private string CEP {get; set;}
    private string Cidade {get; set;}
    private string Bairro {get; set;}
    private string Rua {get; set;}
    private string Numero {get; set;}
    private string Complemento {get; set;}

}