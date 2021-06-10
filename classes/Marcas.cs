using System;
using System.Collections.Generic;

namespace projeto_de_produtos.classes
{
    public class Marcas
    {
        private int codigo { get; set; }
        private string nomedamarca { get; set; }

        private DateTime datacadastro { get; set; }
        public Marcas() {

        }

        public Marcas(int _codigo, string _nomeMarca) {
            this.codigo = _codigo;
            this.nomedamarca = _nomeMarca;
            this.datacadastro = DateTime.Now;
        }

        public List<Marcas> listamarcas = new List<Marcas>();
        public string cadastrar (Marcas marca){
            listamarcas.Add (marca);
            return ($" A marca {marca.nomedamarca} foi cadastrada com sucesso!");
        }
        public string DeletarMarca (Marcas marca){
            listamarcas.Remove (marca);
            return ($" A marca {marca.nomedamarca} foi deletada com sucesso!");
        }
          public int RetornarCodigo() {
            return codigo;
        }

        public Marcas MarcaPeloNome(string _nomemarca) {
            return listamarcas.Find(x => x.nomedamarca == _nomemarca);
        }


         public List<Marcas> Listar()
        {
            return listamarcas;
        }

    }
}