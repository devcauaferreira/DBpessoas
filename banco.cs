using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    public class banco
    {
        private string stringConexao = "Data Source=localhost; Initial Catalog=aulaADONET;" + 
            "User ID=USUARIO; password=SENHA123@; language=Portuguese";

        private SqlConnection cn;

        public void conexao()
        {
            cn = new SqlConnection(stringConexao);
        }
        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();
                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }
            public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.ExecuteNonQuery();
                SqlDataAdapter da= new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                fecharConexao();
                fecharConexao();
            }
        }
    }
}
