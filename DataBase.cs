using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using Dapper;

namespace SlotsGame
{
    internal class DataBase
    {
        private string connectionString = "Data Source = Players_stat.db";

        private void ConnectionDB(string connectionString)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                string query = @"CREATE TABLE IF NOT EXISTS Players (
                                id INTEGER PRIMARY KEY AUTOINCREMENT, 
                                name TEXT NOT NULL, 
                                count INTEGER DEFAULT 0, 
                                lose INTEGER DEFAULT 0
                             );";

                using (var command = new SqliteCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        private void AddPlayer(Player player)
        {
            if(player != null && !string.IsNullOrEmpty(player.Name))
            {
                using(var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Players (name) VALUES(@Name)";
                    conn.Execute(query, player);
                }
            }
            else { throw new ArgumentException("Данные игрока не валидны"); }
        }

        private void UpdatPlayerData(Player player)
        {
            if(ValidInput(player))
            {
                    using (var conn = new SqliteConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE Players SET count = @WinCount, lose = @LoseCount WHERE id = @Id";
                        int affectedRows = conn.Execute(query, player);

                        if (affectedRows == 0)
                        {
                            throw new Exception($"Игрок с ID {player.Id} не найден в базе данных.");
                        }
                }
            }
        }

        private string[] GetAllNames()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT name FROM Players";

                return conn.Query<string>(query).ToArray();
            }
        }

        private int GetScorePlayer(Player player)
        {
            if(ValidInput(player))
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT count FROM Players WHERE id = @Id";
                    return conn.QuerySingleOrDefault<int>(query, player);
                }
            }
            return 0;
        }

        private bool ValidInput(Player player)
        {
            if(player == null)
            {
                throw new ArgumentException("Данные игрока не валидны");
            }
            return true;
        }

        private List<Player> GetTop5Players(int limit = 5)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                string query = @"SELECT id, name, count, lose 
                         FROM Players 
                         ORDER BY count DESC, lose ASC 
                         LIMIT @Limit";

                return conn.Query<Player>(query, new { Limit = limit }).ToList();
            }
        }
    }
}
