using System;
using System.Data;

namespace ThreatLocker.Shared.Models
{
    public class DatabaseColumnSchema
    {
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public int? Length { get; set; }
        public SqlDbType SqlDbType => (SqlDbType)Enum.Parse(typeof(SqlDbType), this.DataType, true);
    }
}
