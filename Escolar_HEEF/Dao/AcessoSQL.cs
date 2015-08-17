using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Escolar_HEEF.Dao
{
    class AcessoSQL
    {

              #region "DEIXAR STATICO ACESSO Sql"
        private static readonly AcessoSQL instanciaSql = new AcessoSQL(); // instancia vai dar erro...

        private AcessoSQL() { }    // caso acessar direto nao mostrara nada.
        #endregion

        #region "INSTANCIAR O Sql"
        public static AcessoSQL getInstancia()    //INSTANCIAR BANCO DE DADOS....
        {
            return instanciaSql;
        }
        #endregion

        #region "STRING DE CONEXAO E CONFIGURACAO COM OS DADOS"
        public SqlConnection getConexao()    // string de conexao com o bando de dados pegando do arquivo config...
        {
            string conn = ConfigurationManager.ConnectionStrings["Escolar_HEEF.Properties.Settings.SQLConnectionString"].ToString();
            return new SqlConnection(conn);
        }
        #endregion

 



    }
}
