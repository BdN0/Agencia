using System.Data; //para funcionar o datatable
using MySql.Data.MySqlClient;

namespace DAL
{
    class DALMysql
    {

        MySqlConnection con;
        private void Conectar()
        {
            try
            {
                con = new MySqlConnection("server=localhost;uid=root;pwd=;database=bdteste");
                con.Open();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            
        }

        public int ExecutarQuery(string SQL) //insert, delete e update
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(SQL, con);
                return cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            
        }  
        
        public DataTable ExecutarConsulta(string SQL) //select
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(SQL, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }            
        }
    }
}
