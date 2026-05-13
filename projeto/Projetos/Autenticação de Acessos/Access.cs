using System.Net.Security;
//Admin > Usuário, Senha e 2FA
// Admin, Admin, 1A2B3C

//User > Usuário, Senha
// User, User

//Convidado > Usuário temporário (fornecido via convite prévio)
// Convidado

//Caso existissem multiplos acessos ao invés de verificar valores fixos, bastaria percorrer pelos valores de uma lista de acessos em cada classe.

public abstract class Access
{

    protected string login { get; private set; }
    protected string password { get; private set; }

    public bool autenticado { get; protected set; } = false;

    public virtual bool AutenticarAcesso(string inputLogin, string inputPass)
    {
        if (inputLogin == login && inputPass == password)
        {
            autenticado = true;
            return true;
        }
        return false;
    }

    public abstract void AcessarDashboard();

}

public class Admin : Access
{
    public string login { get; private set; } = "Admin";
    public string password { get; private set; } = "Admin";
    public string FA2 { get; private set; } = "1A2B3C";

    public override bool AutenticarAcesso(string inputLogin, string inputPass)
    {
        if (inputLogin == login && inputPass == password)
        {
            Console.WriteLine("Qual seu token de 2 fatores?");
            string input2fa = Console.ReadLine();
            if (input2fa == FA2)
            {
                autenticado = true;
                return true;
            }
            return false;
        }
        return false;
    }

    public override void AcessarDashboard() {
        Console.WriteLine("Dashboard ADMIN: visualização e edição completa.");
    }

}

public class User : Access
{
    public string login { get; private set; } = "User";
    public string password { get; private set; } = "User";

    public override bool AutenticarAcesso(string inputLogin, string inputPass)
    {
        if (inputLogin == login && inputPass == password)
        {
            autenticado = true;
            return true;
        }
        return false;
    }

    public override void AcessarDashboard() {
        Console.WriteLine("Dashboard USUARIO: visualização geral.");
    }
}

public class Invited : Access
{
    public string login { get; private set; } = "Convidado";
    public string password { get; private set; } = "";

    public override bool AutenticarAcesso(string inputLogin, string inputPass)
    {
        if (inputLogin == login)
        {
            autenticado = true;
            return true;
        }
        return false;
    }

    public override void AcessarDashboard() {
        Console.WriteLine("Dashboard CONVIDADO: visualização pública com restrições.");
    }

}