using System;
namespace projeto_de_produtos.classes
{
    public class usuario
    {
        private int codigo { get; set; }
        private string nome { get; set; }
        private string email { get; set; }
        private string senha { get; set; }
        private DateTime datadecadastro { get; set; }


        public void cadastrarusuario() {
            Console.WriteLine("Cadastro");
            Console.WriteLine("Digite o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine ("Digite o seu e-mail:");
            email = Console.ReadLine();
            Console.WriteLine("Insira uma senha:");
            senha = Console.ReadLine();
        }

        public void deletar () {

        }
           
    }

}