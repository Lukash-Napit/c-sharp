using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using LukashPortfolio.Models;

namespace LukashPortfolio.Data
{
    public class ContactRepository
    {
        // Connection string pointing to your specific database
        private readonly string _connectionString = "Server=(localdb)\\mssqllocaldb;Database=LukashPortfolioDb;Trusted_Connection=True;TrustServerCertificate=True;";

        // Connection string pointing to the 'master' database (used only for creating new databases)
        private readonly string _masterConnectionString = "Server=(localdb)\\mssqllocaldb;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";

        public void EnsureTableExists()
        {
            // STEP 1: Connect to the 'master' database and create 'LukashPortfolioDb' if it doesn't exist
            string createDbQuery = "IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'LukashPortfolioDb') CREATE DATABASE LukashPortfolioDb;";

            using (SqlConnection masterConnection = new SqlConnection(_masterConnectionString))
            using (SqlCommand createDbCommand = new SqlCommand(createDbQuery, masterConnection))
            {
                masterConnection.Open();
                createDbCommand.ExecuteNonQuery();
            }

            // STEP 2: Now that the database exists, connect to it and create the 'ContactMessages' table
            string createTableQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ContactMessages' and xtype='U')
                CREATE TABLE ContactMessages (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(100),
                    Email NVARCHAR(100),
                    Message NVARCHAR(MAX),
                    SubmittedAt DATETIME
                )";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection))
            {
                connection.Open();
                createTableCommand.ExecuteNonQuery();
            }
        }

        // SAVE a new message to the database
        public void SaveMessage(ContactMessage msg)
        {
            string query = "INSERT INTO ContactMessages (Name, Email, Message, SubmittedAt) VALUES (@Name, @Email, @Message, @SubmittedAt);";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", msg.Name);
                command.Parameters.AddWithValue("@Email", msg.Email);
                command.Parameters.AddWithValue("@Message", msg.Message);
                command.Parameters.AddWithValue("@SubmittedAt", DateTime.Now);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        // RETRIEVE all messages from the database
        public List<ContactMessage> GetAllMessages()
        {
            var messages = new List<ContactMessage>();
            string query = "SELECT Id, Name, Email, Message, SubmittedAt FROM ContactMessages ORDER BY SubmittedAt DESC;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        messages.Add(new ContactMessage
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString(),
                            Email = reader["Email"].ToString(),
                            Message = reader["Message"].ToString(),
                            SubmittedAt = Convert.ToDateTime(reader["SubmittedAt"])
                        });
                    }
                }
            }
            return messages;
        }
        // DELETE a message by its ID
        public void DeleteMessage(int id)
        {
            string query = "DELETE FROM ContactMessages WHERE Id = @Id;";

            using (SqlConnection connection = new SqlConnection(_connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}