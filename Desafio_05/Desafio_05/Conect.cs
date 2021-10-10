using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Desafio_05
{
    class Conect
    {
        public void Connect_to_Mysql()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=2803");
                connection.Open();
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Sucess");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
