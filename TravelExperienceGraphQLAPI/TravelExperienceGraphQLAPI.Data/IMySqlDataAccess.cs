﻿using MySql.Data.MySqlClient;
using System.Data;

namespace TravelExperienceGraphQLAPI.Data
{
    public interface IMySqlDataAccess
    {
        Task<DataTable> ExecuteQueryAsync(string query, MySqlParameter[] parameters);
        Task<object> ExecuteScalarAsync(string query, MySqlParameter[] parameters);
    }
}
