using System;

namespace projeto_de_produtos.classes
{
    public class login
    {
        public string nome;
        public string email;
        private string senha;
        private bool logado;
        public void Login(string _nome, string _email, string _senha){
            nome = _nome;
            email = _email;
            senha = _senha;
        }
    }
}