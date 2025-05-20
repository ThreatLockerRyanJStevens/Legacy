using System.Data.SqlClient;
using System.Data;
using System;

namespace ThreatLockerCommon
{
    public static class SqlCommandExtension
    {
        public static SqlCommand AddDefaultTLSettings(this SqlCommand cmd, CommandType type = CommandType.StoredProcedure, int commandTimeOut = 300)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.CommandType = type;
            cmd.CommandTimeout = commandTimeOut;

            return cmd;
        }

        public static SqlCommand AddNVarCharParameter(this SqlCommand cmd, string parameterName, string value, int size)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.NVarChar, size)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddVarCharParameter(this SqlCommand cmd, string parameterName, string value, int size)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.VarChar, size)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddBitParameter(this SqlCommand cmd, string parameterName, bool value)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.Bit)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddSmallIntParameter(this SqlCommand cmd, string parameterName, short value)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.SmallInt)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddIntParameter(this SqlCommand cmd, string parameterName, int value)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.Int)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddTinyIntParameter(this SqlCommand cmd, string parameterName, byte value)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.TinyInt)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddBigIntParameter(this SqlCommand cmd, string parameterName, long value)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.BigInt)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddDateTimeParameter(this SqlCommand cmd, string parameterName, DateTime value)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.DateTime)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddGuidParameter(this SqlCommand cmd, string parameterName, Guid value)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.UniqueIdentifier)
            {
                Value = value
            });

            return cmd;
        }

        public static SqlCommand AddObjectParameter(this SqlCommand cmd, string parameterName, object value, SqlDbType sqlDbType, int size = 0)
        {
            if (cmd is null)
            {
                return cmd;
            }

            if (sqlDbType == SqlDbType.VarChar || sqlDbType == SqlDbType.NVarChar)
            {
                cmd.Parameters.Add(new SqlParameter(parameterName, sqlDbType, size)
                {
                    Value = value
                });
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter(parameterName, sqlDbType)
                {
                    Value = value
                });
            }

            return cmd;
        }

        public static SqlCommand AddDataTableParameter(this SqlCommand cmd, string parameterName, DataTable dataTable)
        {
            if (cmd is null)
            {
                return cmd;
            }

            cmd.Parameters.Add(new SqlParameter(parameterName, SqlDbType.Structured)
            {
                Value = dataTable
            });

            return cmd;
        }
    }
}
