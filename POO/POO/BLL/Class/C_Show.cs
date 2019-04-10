using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;
namespace POO
{
    public class C_Show : PontoTuristico
    {
        private DateTime dia_fechamento;
        DALMysql dao = new DALMysql();

        public DateTime Dia_fechamento { get => dia_fechamento; set => dia_fechamento = value; }

        string table = "casa_de_show";

        public int Cadastrar_cshow()
        {
            string sql = string.Format("insert into "+ table + " values (null,{'0'},{'1'},{'2'},{'3'},{'4'})", Descricao, Endereco, Data,Dia_fechamento);
            return dao.ExecutarQuery(sql);

        }

        public DataTable Listar_cshow()
        {
            return dao.ExecutarConsulta("Select * from " + table);
        }
        public DataTable Listar_cshows()
        {
            return dao.ExecutarConsulta("Select * from"+ table +" where uf = " + Codigo);
        }

        public DataTable Visualizar_cshow()
        {
            return dao.ExecutarConsulta("Select * from "+table+" where codigo= " + Codigo);
        }

        public DataTable Pesquisar_cshow()


        {
            if (Endereco == null || Codigo == null)
            {
                if (Endereco != null)
                {
                    return dao.ExecutarConsulta("Select *  from  "+ table +" = " + Endereco);
                }
                else
                {
                    return dao.ExecutarConsulta("Select *  from  "+table+" = " + Codigo);
                }
            }
            else
            {
                return dao.ExecutarConsulta("Select * from "+table+" where endereco =" + Endereco + " and codigo = " + Codigo);
            }
        }
    }
}