﻿using Microsoft.Data.SqlClient;

namespace CSharpPerformance.Code;
public class Database : IDisposable
{
    private SqlConnection _connection;
    private readonly string _connectionString;

    public Database(string connectionString)
    {
        _connectionString = connectionString;
    }

    public string GetDate()
    {
        if (_connection == null)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        using (var command = _connection.CreateCommand())
        {
            command.CommandText = "SELECT getdate()";
            return command.ExecuteScalar().ToString();
        }
    }

    public string GetPersonByName(string name)
    {
        if (_connection == null)
        {
            _connection = new SqlConnection(_connectionString);
            _connection.Open();
        }

        using (var command = _connection.CreateCommand())
        {
            command.CommandText = $"select * from Person where name = '{name}'";
            return command.ExecuteScalar().ToString();
        }
    }


    public void Dispose()
    {
        _connection?.Close();
        _connection?.Dispose();
        _connection = null;
    }
}
