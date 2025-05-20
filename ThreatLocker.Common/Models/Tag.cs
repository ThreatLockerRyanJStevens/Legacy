using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;

namespace ThreatLockerCommon.Models
{
    public class Tag
    {
        public static TagItem GetTagById(Guid tagId, string connectionString)
        {
            TagItem item = null;

            if (!tagId.IsEmptyGuid())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("API_TagGetById", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.CommandTimeout = 300;

                        cmd.Parameters.Add(new SqlParameter("@TagId", System.Data.SqlDbType.UniqueIdentifier)
                        {
                            Value = tagId
                        });

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                item = new TagItem
                                {
                                    TagId = tagId,
                                    Name = reader["Name"].ToSafeString(),
                                    OrganizationId = reader["OrganizationId"].ToSafeGuid(),
                                    Active = reader["Active"].ToSafeBool()
                                };
                            }
                        }
                    }
                }

                return item;
            }
            else
            {
                return null;
            }
        }

        public static List<TagItem> GetTagsByPolicyId(Guid policyId, string connectionString, string searchText = "", int pageSize = 1000, int pageNumber = 1)
        {
            List<TagItem> tagItems = new List<TagItem>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("WEBUI_TagItemGetPolicy", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 300;

                    cmd.Parameters.AddWithValue("TagId", policyId);
                    cmd.Parameters.AddWithValue("SearchText", searchText);
                    cmd.Parameters.AddWithValue("PageSize", pageSize);
                    cmd.Parameters.AddWithValue("PageNumber", pageNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = Convert.ToString(reader["Value"]);

                            tagItems.Add(new TagItem
                            {
                                TagItemId = (long)reader["TagItemId"],
                                TagId = policyId,
                                Value = value,
                                StatusId = (int)reader["StatusId"],
                                TransactionTypeId = (int)reader["TransactionTypeId"],
                                RelatedTagItemId = (long)reader["RelatedTagItemId"],
                                OrganizationId = new Guid(Convert.ToString(reader["OrganizationId"]))
                            });
                        }
                    }
                }
            }

            return tagItems;
        }
    }

    [Serializable]
    public class TagItem
    {
        public long TagItemId { get; set; }

        public Guid TagId { get; set; }

        public string Value { get; set; }

        public int StatusId { get; set; }

        public int TransactionTypeId { get; set; }

        public long RelatedTagItemId { get; set; }

        public Guid OrganizationId { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
    }

    public class ServiceTagItem
    {
        public long TagItemId { get; set; }

        public Guid TagId { get; set; }

        public string Value { get; set; }

        public int TransactionTypeId { get; set; }

        public long RelatedTagItemId { get; set; }
    }
}