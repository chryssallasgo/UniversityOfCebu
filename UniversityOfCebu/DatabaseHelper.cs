using System;
using System.Data.OleDb;
using System.IO;

public static class DatabaseHelper
{

    private static string connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={AppDomain.CurrentDomain.BaseDirectory}Database1.accdb;Persist Security Info=False;";


    public static OleDbConnection GetConnection()
    {
        return new OleDbConnection(connString);
    }
}