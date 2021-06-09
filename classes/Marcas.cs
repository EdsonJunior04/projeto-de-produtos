using System;
using System.Collections.Generic;

namespace projeto_de_produtos.classes
{
    public class marcas
    {
        private int codigo;
        private string marca;

        private DateTime datacadastro;
        public string cadastrar () {

            return ("nike");
        }
       // public marca () {}
        public marcas (int _codigo, string _marca, DateTime _datacadastro) {
            codigo = _codigo;
            marca = _marca;
            datacadastro = _datacadastro;
        }
    }
}