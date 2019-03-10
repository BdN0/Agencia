using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using System.Data;
using POO.Class;

namespace POO
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        DALMysql bd = new DALMysql();
        string sql;
        protected void Button1_Click(object sender, EventArgs e)
        {
           

            sql = string.Format("insert into cidade values(null,'{0}','{1}','{2}')", txtnome.Text, txtestado.Text, txtpopulacao.Text);
            bd.AlterarDados(sql);
            
        }
    }
}