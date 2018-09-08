/*
 * Created by SharpDevelop.
 * User: ivan
 * Date: 8/9/2018
 * Time: 17:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using MySql.Data.MySqlClient;

namespace ABMStock
{
	/// <summary>
	/// Description of ConexionBBDD.
	/// </summary>
	public class ConexionBBDD
	{
	    private MySqlConnection connection;
	    private string server;
	    private string database;
	    private string uid;
	    private string password;
	    
		public ConexionBBDD()
		{
		    Initialize();
		}

	    //Initialize values
	    private void Initialize()
	    {
	        server = "localhost";
	        database = "mydb";
	        uid = "root";
	        password = "root";
	        string connectionString;
	        connectionString = "SERVER=" + server + ";" + "DATABASE=" + 
			database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
	
	        connection = new MySqlConnection(connectionString);
	    }
	
		//open connection to database
		public bool OpenConnection()
		{
		    try
		    {
		        connection.Open();
		        Debug.Print("true");
		        return true;
		    }
		    catch (MySqlException ex)
		    {
		    	Debug.Print("excepcion:" + ex.Number);
		        //When handling errors, you can your application's response based 
		        //on the error number.
		        //The two most common error numbers when connecting are as follows:
		        //0: Cannot connect to server.
		        //1045: Invalid user name and/or password.
		        /*
		        switch (ex.Number)
		        {
		            case 0:
		                MessageBox.Show("Cannot connect to server.  Contact administrator");
		                break;
		
		            case 1045:
		                MessageBox.Show("Invalid username/password, please try again");
		                break;
		        }
		        */
		        return false;
		    }
		}
		
		//Close connection
		public bool CloseConnection()
		{
		    try
		    {
		        connection.Close();
		        return true;
		    }
		    catch (MySqlException ex)
		    {
		        //MessageBox.Show(ex.Message);
		        return false;
		    }
		}
		
		public bool IsConnectionOpen(){
			try{
				return connection.Ping();
			}	
			catch (MySqlException ex)
		    {
		        //MessageBox.Show(ex.Message);
		        return false;
		    }
		}
	
	    //Insert statement
	    public void Insert()
	    {
	    }
	
	    //Update statement
	    public void Update()
	    {
	    }
	
	    //Delete statement
	    public void Delete()
	    {
	    }
	/*
	    //Select statement
	    public List <string> [] Select()
	    {
	    }
	
	    //Count statement
	    public int Count()
	    {
	    }
	*/
	    //Backup
	    public void Backup()
	    {
	    }
	
	    //Restore
	    public void Restore()
	    {
	    }
	}
}
