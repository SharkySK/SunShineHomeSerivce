using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace HomeCare.Database
{
	public class DBConnect
	{
		public void Connect() { 
		SqlConnection mCon = new SqlConnection("user id=root;password=homecare;Address=35.187.185.164;database=sunshineHome;connection timeout=30");
		try 
		{	        
		mCon.Open();
				Console.WriteLine("Opened connection");
		}
		catch (Exception e)
		{
				Console.WriteLine(e.ToString());

				throw;
		}


	}}


}