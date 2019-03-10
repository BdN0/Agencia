using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DAL;

namespace POO.Class
{
    public class Cidade
    {
        private int codigo;
        private string nome, uf;
        private int populacao;
        DALMysql dao = new DALMysql();
        
        
        public string Nome { get => nome; set => nome = value; }
        public string Uf { get => uf; set => uf = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public int Populacao { get => populacao; set => populacao = value; }

        public int Cadastrar_Cidade()
        {
            string sql = string.Format("insert into cidade values (null,'{0}','{1}','{2}'", nome, uf, populacao);
            return dao.AlterarDados(sql);
        }
        public void Remover_Cidade()
        {
            dao.AlterarDados("delete from cidade where codigo = " + codigo);
        }

        public DataTable Listar_Cidade()
        {
            return dao.ConsultarDados("Select * from cidade");
        }
        public DataTable Listar_Cidades()
        {
            return dao.ConsultarDados("Select * from cidade where uf = "+ uf);
        }
        public DataTable Visualizar_Cidade()
        {
            return dao.ConsultarDados("Select * from cidade where codigo= " + codigo);
        }
        public DataTable Pesquisar_Cidade()
        {
            if (nome != null && uf!=null)
            {
                return dao.ConsultarDados("Select * from cidade where nome =" + nome + " and uf = " + uf);
            }
            else if (nome != null)
            {
                return dao.ConsultarDados("Select *  from  cidade = " + nome);
            }
            else
            {
                return dao.ConsultarDados("Select *  from  cidade = " + uf);
            }
        }
       
       
        
    }

    
}