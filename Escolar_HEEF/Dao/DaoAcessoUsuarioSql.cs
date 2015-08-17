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
    class DaoAcessoUsuarioSql
    {
        internal static DateTime MySql_GetUsuarioseAdmin(string receberDadosTabela, ClsObjetos.ClsUsuario dadosdatabela, bool Logadonosistema)
        {
            throw new NotImplementedException();
        }

        internal static string MySql_ProcuraDadosadminstrador(string receberDadosTabela, string NomedoTabela)
        {
            throw new NotImplementedException();
        }

        #region "CHAMAR COLUNAS SEPARADAS DOS DADOS Clientes"
        public static DataTable Sql_GetSepararDados(string receberDadosTabela, string colunasdatabela)  //metodo de chamar os dados da classe RECEBER /// cliente/produtos.
        {
            using (SqlConnection conexaoMySql = Dao.AcessoSQL.getInstancia().getConexao())
            {
                try
                {
                    conexaoMySql.Open();                         //abre a conexao...
                    // SELECT `id`, `name`, `grupo` FROM `tbusuario` WHERE 1
                    string mSQL = "Select " + colunasdatabela + " from " + receberDadosTabela;         //seleciona tudo da
                    SqlCommand cmd = new SqlCommand(mSQL, conexaoMySql); // dar um comando dentro do banco...
                    SqlDataAdapter da = new SqlDataAdapter(cmd);         //cria uma instancia "da" para receber os comandos.
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
                catch (SqlException msqlex)
                {
                    switch (msqlex.Number)
                    {
                        case 0:
                            MessageBox.Show("Não é possível conectar ao servidor, por favor, tente novamente", " Contate o administrador");
                            break;

                        case 1045:
                            MessageBox.Show("Nome de usuário / senha inválida , por favor, tente novamente", " Contate o administrador");
                            break;

                        case 1042:
                            MessageBox.Show("Não é possível conectar ao servidor \n por favor,\n Ao inicializar o servidor tente novamente ", " Contate o administrador");
                            break;

                    }
                    //MessageBox.Show(msqlex.Number + " \n Aconteceu um Erro \n SGBD não encontrado \n Favor Verifique o Servidor! ","Espere um pouco ");
                    throw msqlex;
                }
                finally
                {
                    conexaoMySql.Close();
                }
            }
        }
        #endregion


    }
}
