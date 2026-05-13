//Autenticação de Usuário
//Você foi contratado para implementar um módulo de autenticação para um aplicativo de dashboards
//Três tipos de Usuário: Admin; Usuário Comum; Convidado.
//Cada Usuário tem a sua própria forma de autenticação e acesso ao dashboard.
//Implemente os quatro pilares da POO;

// Sistema solicitará dados para acesso:

//Admin > Usuário, Senha e 2FA
// Admin, Admin, 1A2B3C

//User > Usuário, Senha
// User, User

//Convidado > Usuário temporário (fornecido via convite prévio)
// Convidado

List<Access> usuarios = new List<Access> { new Admin(), new User(), new Invited() };
Access usuarioAutenticado = null;     
        
Console.WriteLine("Dashboard Financeira");

while (usuarioAutenticado == null){
Console.WriteLine("Qual seu usuário?");
string inputlogin = Console.ReadLine();
Console.WriteLine("Qual sua senha?");
string inputpass = Console.ReadLine();
foreach (var usuario in usuarios)
    {
        if (usuario.AutenticarAcesso(inputlogin, inputpass))
        {
            usuarioAutenticado = usuario;
            break;
        }
    }

    if (usuarioAutenticado == null)
    {
        Console.WriteLine("Usuário ou senha incorreta.");
    }
}

usuarioAutenticado.AcessarDashboard();