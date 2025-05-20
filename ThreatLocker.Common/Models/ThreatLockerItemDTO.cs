using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using ThreatLockerCommon.Constants;
using static System.Collections.Specialized.BitVector32;

namespace ThreatLockerCommon.Models
{
    //TODO: keep *_old classes until there are no services with version 1666 or below
    public class ThreatLockerItemDTO_old : IEquatable<ThreatLockerItemDTO_old>
    {
        public ThreatLockerItemDTO_old() { }

        public ThreatLockerItemDTO_old(ServiceShorthandTLAction action)
        {
            int actionType = ActionType.FindByValue(action.at).Id;
            D = action.t;
            SetAttributeValue(ThreatLockerAttribute_old.FullPath, action.fp, default);
            SetAttributeValue(ThreatLockerAttribute_old.ProcessPath, action.pn, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.PolicyId, action.pyid.ToSafeGuid(), default);
            SetAttributeValue(ThreatLockerAttribute_old.Username, action.u, default);
            SetAttributeValue(ThreatLockerAttribute_old.ActionId, action.a, default);
            SetAttributeValue(ThreatLockerAttribute_old.TLHash, action.h, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.Certificates, action.c, new List<ThreatLockerCert>());
            SetAttributeValue(ThreatLockerAttribute_old.ApplicationId, action.aid.ToSafeGuid(), default);
            SetAttributeValue(ThreatLockerAttribute_old.HarddriveSerialNumber, action.sn, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.DeviceType, action.dt, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.ActionType, actionType);
            SetAttributeValue(ThreatLockerAttribute_old.FileSize, action.s, default);
            SetAttributeValue(ThreatLockerAttribute_old.ProcessID, action.pid, default);
            SetAttributeValue(ThreatLockerAttribute_old.Ringfenced, action.rf, default);
            SetAttributeValue(ThreatLockerAttribute_old.PolicyName, action.p, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.ApplicationName, action.ap, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.EncryptionStatus, action.e, 2);
            SetAttributeValue(ThreatLockerAttribute_old.MonitorOnly, action.mo, default);
            SetAttributeValue(ThreatLockerAttribute_old.Notes, action.n, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.CreatedByProcess, JsonConvert.SerializeObject(action.cb), "[]");
            SetAttributeValue(ThreatLockerAttribute_old.Data, action.d, default);
            SetAttributeValue(ThreatLockerAttribute_old.SHA256, action.s256, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.SHA1, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.MD5Hash, string.Empty);
            SetAttributeValue(ThreatLockerAttribute_old.RemotePresence, action.rp, default);
            SetAttributeValue(ThreatLockerAttribute_old.MaintenanceModeId, action.mid, default);
        }

        // ThreatLockerItemId.
        public long Id { get; set; }
        public DateTime D { get; set; }

        public Dictionary<int, object> A { get; set; } = new Dictionary<int, object>();

        public T GetAttributeValue<T>(AttributeType_old<T> attribute)
        {
            try
            {
                if (A.ContainsKey(attribute.Id))
                {
                    if (A[attribute.Id] == null || typeof(T) == A[attribute.Id].GetType())
                    {
                        return (T)A[attribute.Id];
                    }
                    else
                    {
                        if (typeof(T).IsValueType)
                        {
                            if (typeof(T) == typeof(Guid))
                            {
                                A[attribute.Id] = A[attribute.Id].ToSafeGuid();
                                return (T)A[attribute.Id];
                            }
                            else
                            {
                                A[attribute.Id] = Convert.ChangeType(A[attribute.Id], typeof(T));
                                return (T)A[attribute.Id];
                            }
                        }
                        else if (typeof(T).IsClass)
                        {
                            JToken jToken = JToken.Parse(JsonConvert.SerializeObject(A[attribute.Id]));

                            if (jToken is JArray)
                            {
                                A[attribute.Id] = ((JArray)jToken).ToObject<T>();
                                return (T)A[attribute.Id];
                            }
                            else if (jToken is JObject)
                            {
                                A[attribute.Id] = jToken.ToObject<T>();
                                return (T)A[attribute.Id];
                            }
                        }
                    }
                }
            }
            catch { }

            return default(T);
        }

        /// <summary>
        /// Sets the ThreatLockerAttribute value and adds to the A, Attribute, property
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="attribute">ThreatLockerAttribute we are setting</param>
        /// <param name="value">Value of the ThreatLockerAttribute</param>
        /// <param name="defaultValue">Is only for comparison. If the value is different than the defaultValue then set it to value</param>
        public void SetAttributeValue<T>(ThreatLockerAttribute_old attribute, T value, T defaultValue)
        {
            if (value == null && defaultValue == null)
            {
                return;
            }

            // if setToDefault is true then we will force set to the default value
            if (value == null && defaultValue != null)
            {
                SetAttributeValue(attribute, defaultValue);
            }
            // this handles generic lists
            else if (value != null && value.IsGenericList())
            {
                // if the list is populated, set it
                if ((value as IEnumerable).Cast<object>().Any())
                {
                    SetAttributeValue(attribute, value);
                }
            }
            else if ((defaultValue != null && !defaultValue.Equals(value))
                || defaultValue == null)
            {
                SetAttributeValue(attribute, value);
            }
        }

        public void SetAttributeValue<T>(ThreatLockerAttribute_old attribute, T value)
        {
            A[attribute.Id] = value;
        }

        public bool Equals(ThreatLockerItemDTO_old other)
        {
            if (other is null)
                return false;

            return this.GetAttributeValue(ThreatLockerAttribute_old.ActionType) == other.GetAttributeValue(ThreatLockerAttribute_old.ActionType)
                && this.GetAttributeValue(ThreatLockerAttribute_old.FullPath) == other.GetAttributeValue(ThreatLockerAttribute_old.FullPath)
                && this.GetAttributeValue(ThreatLockerAttribute_old.Username) == other.GetAttributeValue(ThreatLockerAttribute_old.Username)
                && this.GetAttributeValue(ThreatLockerAttribute_old.ProcessPath) == other.GetAttributeValue(ThreatLockerAttribute_old.ProcessPath)
                && this.GetAttributeValue(ThreatLockerAttribute_old.HarddriveSerialNumber) == other.GetAttributeValue(ThreatLockerAttribute_old.HarddriveSerialNumber)
                && this.GetAttributeValue(ThreatLockerAttribute_old.DeviceType) == other.GetAttributeValue(ThreatLockerAttribute_old.DeviceType)
                && this.GetAttributeValue(ThreatLockerAttribute_old.TLHash) == other.GetAttributeValue(ThreatLockerAttribute_old.TLHash)
                && this.GetAttributeValue(ThreatLockerAttribute_old.ActionId) == other.GetAttributeValue(ThreatLockerAttribute_old.ActionId)
                && this.GetAttributeValue(ThreatLockerAttribute_old.Notes) == other.GetAttributeValue(ThreatLockerAttribute_old.Notes);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public class ThreatLockerItemDTO
    {
        public ThreatLockerItemDTO() { }

        public ThreatLockerItemDTO(ThreatLockerItemDTO dto)
        {
            D = dto.D;
            U = dto.U;
            PID = dto.PID;
            PN = dto.PN;
            AT = dto.AT;
            AID = dto.AID;
            A = new List<KeyValuePair<int, object>>(dto.A);
        }

        public ThreatLockerItemDTO(ServiceShorthandTLAction action)
        {
            D = action.t;
            U = action.u;
            PID = action.pyid.ToSafeNullableGuid();
            PN = action.p;
            AT = ActionType.FindByValue(action.at).Id;
            AID = action.a;

            AddOrUpdateAttributeValue(ThreatLockerAttribute.FullPath, action.fp, default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.ProcessPath, action.pn, string.Empty);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.TLHash, action.h, string.Empty);
            AddOrUpdateAttributeValues(ThreatLockerAttribute.Certificate, action.c, default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.ApplicationId, action.aid.ToSafeGuid(), default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.SerialNumber, action.sn, string.Empty);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.DeviceType, action.dt, string.Empty);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.FileSize, action.s, default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.ProcessID, action.pid, default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.Ringfenced, action.rf, default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.ApplicationName, action.ap, string.Empty);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.EncryptionStatus, action.e, 2);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.MonitorOnly, action.mo, default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.Notes, action.n, string.Empty);

            if (!string.IsNullOrEmpty(action.cb))
            {
                AddOrUpdateAttributeValues(ThreatLockerAttribute.CreatedByProcess, JsonConvert.DeserializeObject<List<string>>(action.cb), default);
            }

            AddOrUpdateAttributeValue(ThreatLockerAttribute.Data, action.d, default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.SHA256, action.s256, string.Empty);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.RemotePresence, action.rp, default);
            AddOrUpdateAttributeValue(ThreatLockerAttribute.MaintenanceModeId, action.mid, default);
        }

        /// <summary>
        /// DateTime
        /// </summary>
        public DateTime D { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// Username
        /// </summary>
        public string U { get; set; }

        /// <summary>
        /// PolicyID
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Guid? PID { get; set; }

        /// <summary>
        /// PolicyName
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PN { get; set; }

        /// <summary>
        /// ActionType
        /// </summary>
        public int AT { get; set; }

        /// <summary>
        /// ActionID
        /// </summary>
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int AID { get; set; }

        /// <summary>
        /// Attributes
        /// </summary>
        public List<KeyValuePair<int, object>> A { get; set; } = new List<KeyValuePair<int, object>>();

        public T[] GetAttributeValues<T>(AttributeType<T> attribute)
        {
            if (attribute.IsArray)
            {
                var items = A.Where(x => x.Key == attribute.Id).Select(y =>
                {
                    if (y.Value == null || typeof(T) == y.Value.GetType())
                    {
                        return (T)y.Value;
                    }
                    else
                    {
                        if (typeof(T).IsClass)
                        {
                            JToken jToken = JToken.Parse(JsonConvert.SerializeObject(y.Value));

                            if (jToken is JObject)
                            {
                                object value = jToken.ToObject<T>();

                                return (T)value;
                            }
                        }
                    }

                    return (T)y.Value;
                }).ToArray();

                object convertedArray = Array.ConvertAll(items, x => x);

                return (T[])convertedArray;
            }
            else
            {
                return null;
            }
        }

        //public T[] GetAttributeValues2<T>(AttributeType<T> attribute)
        //{
        //    if (!attribute.IsArray)
        //    {
        //        return Array.Empty<T>();
        //    }

        //    return A.Where(x => x.Key == attribute.Id).Select(x => (T)x.Value).ToArray();
        //}

        public T GetAttributeValue<T>(AttributeType<T> attribute)
        {
            try
            {
                KeyValuePair<int, object> attrib = A.FirstOrDefault(x => x.Key == attribute.Id);

                if (attrib.Key != 0)
                {
                    if (attrib.Value == null || typeof(T) == attrib.Value.GetType())
                    {
                        return (T)attrib.Value;
                    }
                    else
                    {
                        if (typeof(T).IsValueType)
                        {
                            if (typeof(T) == typeof(Guid))
                            {
                                object value = attrib.Value.ToSafeGuid();

                                return (T)value;
                            }
                            else
                            {
                                object value = Convert.ChangeType(attrib.Value, typeof(T));

                                return (T)value;
                            }
                        }
                        else if (typeof(T).IsClass)
                        {
                            JToken jToken = JToken.Parse(JsonConvert.SerializeObject(attrib.Value));

                            if (jToken is JObject)
                            {
                                object value = jToken.ToObject<T>();

                                return (T)value;
                            }
                        }
                    }
                }
            }
            catch { }

            return default(T);
        }

        /// <summary>
        /// Sets the ThreatLockerAttribute value and adds to the A, Attribute, property
        /// </summary>
        /// <typeparam name="T">Generic type</typeparam>
        /// <param name="attribute">ThreatLockerAttribute we are setting</param>
        /// <param name="value">Value of the ThreatLockerAttribute</param>
        /// <param name="defaultValue">defaultValue is for comparison only. If the value is different than the defaultValue, then set to value</param>
        public void AddOrUpdateAttributeValue<T>(AttributeType<T> attribute, T value, T defaultValue)
        {
            if (value == null && defaultValue == null)
            {
                return;
            }

            if (value == null && defaultValue != null)
            {
                AddOrUpdateAttributeValue(attribute, defaultValue);
            }
            else if ((defaultValue != null && !defaultValue.Equals(value))
                || defaultValue == null)
            {
                AddOrUpdateAttributeValue(attribute, value);
            }
        }

        public void AddOrUpdateAttributeValue<T>(AttributeType<T> attribute, T value)
        {
            if (A.Any(x => x.Key == attribute.Id) && !attribute.IsArray)
            {
                UpdateAttributeValue(attribute, value);
            }
            else
            {
                A.Add(new KeyValuePair<int, object>(attribute.Id, value));
            }
        }

        public void AddOrUpdateAttributeValues<T>(AttributeType<T> attribute, T[] values, T defaultValue)
        {
            for (int i = 0; i < values.Length; i++)
            {
                AddOrUpdateAttributeValue(attribute, values[i], defaultValue);
            }
        }

        public void AddOrUpdateAttributeValues<T>(AttributeType<T> attribute, IEnumerable<T> values, T defaultValue)
        {
            if (values != null)
            {
                AddOrUpdateAttributeValues(attribute, values.ToArray(), defaultValue);
            }
        }

        private void UpdateAttributeValue<T>(AttributeType<T> attribute, T newValue)
        {
            A.Remove(new KeyValuePair<int, object>(attribute.Id, GetAttributeValue(attribute)));
            A.Add(new KeyValuePair<int, object>(attribute.Id, newValue));
        }

        /// <summary>
        /// This method will look up an element in the Attributes collection that matches both key and oldValue, and replace it with the new given value.
        /// Useful for attributes that are included more than once
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="attribute"></param>
        /// <param name="newValue"></param>
        /// <param name="oldValue"></param>
        public void UpdateAttributeValue<T>(AttributeType<T> attribute, T newValue, T oldValue)
        {
            A.Remove(new KeyValuePair<int, object>(attribute.Id, oldValue));
            A.Add(new KeyValuePair<int, object>(attribute.Id, newValue));
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
