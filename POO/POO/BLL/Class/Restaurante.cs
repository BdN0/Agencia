using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace POO
{
    public class Restaurante
    {
        private string nome, endereco, tipo;
        private int codigo;
        DALMysql dao = new DALMysql();

        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Codigo { get => codigo; set => codigo = value; }


        public DataTable Listar_Restaurante()
        {
            return dao.ConsultarDados("Select * from cidade");
        }
        public DataTable Listar_Restaurantes()
        {
            return dao.ConsultarDados("Select * from restaurante where uf = " + codigo);
        }
        public DataTable Visualizar_Restaurante()
        {
            return dao.ConsultarDados("Select * from restaurante where codigo= " + codigo);
        }
        public DataTable Pesquisar_Restaurante()
        {
            if (nome != null && codigo != null)
            {
                return dao.ConsultarDados("Select * from cidade where nome =" + nome + " and uf = " + codigo);
            }
            else if (nome != null)
            {
                return dao.ConsultarDados("Select *  from  cidade = " + nome);
            }
            else
            {
                return dao.ConsultarDados("Select *  from  cidade = " + codigo);
            }
        }
    }
}