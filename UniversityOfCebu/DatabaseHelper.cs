using System;
using System.Data.OleDb;

public static class DatabaseHelper
{
    
    private static string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Mark Jorland Iway\\Desktop\\New folder\\UniversityOfCebu\\Database1.accdb;Persist Security Info=False;";

 
    public static OleDbConnection GetConnection()
    {
        return new OleDbConnection(connString);
    }
}