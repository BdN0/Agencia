using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace POO
{
    public class Igreja : PontoTuristico

    {
        private string estilo;
        DALMysql dao = new DALMysql();

        public string Estilo { get => estilo; set => estilo = value; }

        string table = "igreja";

        public int Cadastrar_igreja()
        {
            string sql = string.Format("insert into " + table + " values (null,{'0'},{'1'},{'2'},{'3'},{'4'})", Descricao, Endereco, Data, Dia_fechamento);
            return dao.ExecutarQuery(sql);

        }

        public DataTable Listar_igreja()
        {
            return dao.ExecutarConsulta("Select * from " + table);
        }
        public DataTable Listar_igrejas()
        {
            return dao.ExecutarConsulta("Select * from" + table + " where uf = " + Codigo);
        }

        public DataTable Visualizar_igreja()
        {
            return dao.ExecutarConsulta("Select * from " + table + " where codigo= " + Codigo);
        }

        public DataTable Pesquisar_igreja()


        {
            if (Endereco == null || Codigo == null)
            {
                if (Endereco != null)
                {
                    return dao.ExecutarConsulta("Select *  from  " + table + " = " + Endereco);
                }
                else
                {
                    return dao.ExecutarConsulta("Select *  from  " + table + " = " + Codigo);
                }
            }
            else
            {
                return dao.ExecutarConsulta("Select * from " + table + " where endereco =" + Endereco + " and codigo = " + Codigo);
            }
        }
        public void Remover_igreja()
        {

            dao.ExecutarQuery("delete from "+table+" where codigo = " + Codigo);

        }

    }
}