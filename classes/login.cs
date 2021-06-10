using System;

namespace projeto_de_produtos.classes
{
    public class login
    {
        private bool logado = true;
        // public string nome;
        // public string email;
        // private string senha;
        // private bool logado;
        // public void Login(string _nome, string _email, string _senha){
        //     nome = _nome;
        //     email = _email;
        //     senha = _senha;
        // 
        public void fazerlogin (){
            Console.WriteLine (@"
    ________________________
    │                      │
    │ 1- Fazer login       │
    │ 2- Cadastrar Usuario │
    │ 3- Sair              │
    │______________________│
             ");

        string resposta = Console.ReadLine();  

        switch (resposta)
        {
            case "1":
                Console.WriteLine("Insira o seu email");
                string emaillogin = Console.ReadLine();
                Console.WriteLine("Insira a sua senha");
                string senhalogin = Console.ReadLine();
                break;

            case "2":
                Console.WriteLine("Insira seu nome");
                string nomecadastrar = Console.ReadLine();
                Console.WriteLine("Insira seu email");
                string emailcadastrar = Console.ReadLine();
                Console.WriteLine("Insira uma senha");
                string senhacadastrar = Console.ReadLine();
                break;
                 case "3":
                Console.WriteLine("Saindo...");
                break;
            default:
                break;
        }
          
        }
     }
}