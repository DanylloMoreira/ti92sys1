using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime Datacad { get; set; }
        public bool Ativo { get; set; }
        public Cliente() { }
        public Cliente(int id, string nome, string cpf, string email, DateTime datacad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, DateTime datacad, bool ativo)
        {            
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }
        public void Inserir() 
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "insert clientes (nome, cpf, email, ativo) " +
                "values ('" + Nome + "','" + Cpf + "','" + Email + "','" + Datacad + ",0)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        public static List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from clientes order by nome asc";
            var dr = cmd.ExecuteNonQuery();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.Getstring(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDatetime(4),
                    dr.GetBoolean(5)
                    )
                );
            }
            return lista;
        }
    }
}
