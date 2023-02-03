using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Nome { get; set; }   
        public string Sigla { get; set; }

        // Métodos constutores
        public Nivel() { }
        public Nivel(string _nome, string _sigla) 
        {
            Nome = _nome;
            Sigla = _sigla;
        }
        public Nivel(int _id, string _nome, string _sigla)
        {
            Id = _id;
            Nome = _nome;
            Sigla = _sigla;
        }
        // Métodos da classe
        public void Inserir()
        {
            // gravar um novo nivel na tabela niveis
        }
        public static List<Nivel> Listar()
        {
            // entrega uma lista de todos os niveis 
            List<Nivel> lista = new List<Nivel>();
            // lógica que recupera todos os niveis da tabela

            return lista;                
        }
        public static Nivel ObterPorId(int _id)
        {
            Nivel nivel = null;

            return nivel;
        }
        public static void Atualizar(Nivel nivel) 
        { 
            
        }
        public void Excluir(int _id) 
        { 
        
        }

    }
}
