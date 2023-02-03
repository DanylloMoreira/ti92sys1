using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ti92class
{
    public class Usuario
    {    
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public Nivel Nivel { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        // Métodos constutores
        public Usuario() { }
         
            public Usuario(string _nome, string _email, Nivel _nivel,string _senha, bool _ativo) 
            {
                Nome = _nome;
                Email = _email;
                Nivel = _nivel;
                Senha = _senha;
                Ativo = _ativo;
            }
            public Usuario(int _id, string _nome, string _email, Nivel _nivel, string _senha, bool _ativo) 
            { 
                Id= _id;
                Nome = _nome;
                Email = _email;
                Nivel = _nivel;
                Senha = _senha;
                Ativo = _ativo;
            

            }
    }
}

