using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;  
 

namespace Wonderland_Private_Server.Tutorials
{
    /*
     * edited 3/4/2015 by rcharnel
     * 
     * Step 1
     *Inherit  RCLibrary.Core.DBConnectInfo
     */
    //public class TempDataBaseDll : RCLibrary.Core.DBConnectInfo
    //{
    //    //return the following information

    //    //MySql/SQl Settings
    // //The following C# Program is used to create a MySqlConnection object, assign the connection string, and open the connection
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn ;
			connetionString = "server=localhost;database=testDB;uid=root;pwd=abc123;";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show ("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}

    //    /// <summary>
    //    /// Username for authencation
    //    /// </summary>
    //    string User { get; }
    //    /// <summary>
    //    /// Pasword for authencation
    //    /// </summary>
    //    string Pass { get; }
    //    /// <summary>
    //    /// The Database we want to use
    //    /// </summary>
    //    string DataBase { get; }
    //    /// <summary>
    //    /// Port we are connecting to
    //    /// </summary>
    //    int Port { get; }
    //    /// <summary>
    //    /// IP Address of the Server
    //    /// </summary>
    //    System.Net.IPAddress ServerIP { get; }
    //    /// <summary>
    //    /// Type of Server we are connecting to
    //    /// </summary>
    //    RCLibrary.Core.DataBaseTypes Server_Type { get; }
    //    /// <summary>
    //    /// Handles Verification
    //    /// 
    //    /// supports mutliple types using the useverify to designate which one to use
    //    /// </summary>
    //    /// <returns>"true if strings match</returns>
    //    bool VerifyPassword(string check, string with, int useverify = 0)
    //    {
    //        //enter code to verify Passwords here
    //        return check == with;
    //    }
    //}
}
