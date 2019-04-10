using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
using System.Data;

namespace POO
{
    public class Museu : PontoTuristico
    {
        private int numero_salas;
        DALMysql dao = new DALMysql();

        public int Numero_salas { get => numero_salas; set => numero_salas = value; }

        string table = "museu";

        public int Cadastrar_museu()
        {
            string sql = string.Format("insert into " + table + " values (null,{'0'},{'1'},{'2'},{'3'},{'4'})", Descricao, Endereco, Data,Numero_salas);
            return dao.ExecutarQuery(sql);

        }

        public DataTable Listar_museu()
        {
            return dao.ExecutarConsulta("Select * from " + table);
        }
        public DataTable Listar_museus()
        {
            return dao.ExecutarConsulta("Select * from" + table + " where uf = " + Codigo);
        }

        public DataTable Visualizar_museu()
        {
            return dao.ExecutarConsulta("Select * from " + table + " where codigo= " + Codigo);
        }

        public DataTable Pesquisar_museu()


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
    }
}