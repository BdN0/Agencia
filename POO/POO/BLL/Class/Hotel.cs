using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace POO
{
    public class Hotel
    {
        private int codigo;
        private string nome, endereco, tipo;
        private int categoria, quartos;
        private double diaria;
        DALMysql dao = new DALMysql();

        public int Codigo { get => codigo; set => codigo = value; }

        public string Nome { get => nome; set => nome = value; }

        public string Endereco { get => endereco; set => endereco = value; }

        public string Tipo { get => tipo; set => tipo = value; }

        public int Categoria { get => categoria; set => categoria = value; }

        public int Quartos { get => quartos; set => quartos = value; }

        public double Diaria { get => diaria; set => diaria = value; }

        public int Cadastrar_hotel()
        {
            string sql = string.Format("insert into hotel values (null,'{0}','{1}','{2}','{3}','{4}','{5}')", nome, endereco, tipo, categoria, quartos, diaria);
            return dao.ExecutarQuery(sql);

        }
        public void Remover_hotel()
        {

            dao.ExecutarQuery("delete from hotel where codigo = " + codigo);

        }
        public DataTable Listar_hotel()
        {
            return dao.ExecutarConsulta("Select * from hotel");
        }

        public DataTable Listar_hotel(string endereco)
        {
            return dao.ExecutarConsulta("Select * from hotel where endereco = " + endereco);
        }

        public DataTable Visualizar_hotel(int codigo)
        {
            return dao.ExecutarConsulta("Select * from hotel where codigo = " + codigo);
        }

        public DataTable Pesquisar_hotel(string nome, string endereco)
        {
            if (nome != null && endereco != null)
                return dao.ExecutarConsulta("Select * from hotel where nome = " + nome + " and endereco = " + endereco);
            else if (nome != null)
                return dao.ExecutarConsulta("Select * from hotel where nome = " + nome);
            else
                return dao.ExecutarConsulta("Select * from hotel where endereco = " + endereco);
        }
    }
}