using System;
using System.Collections.Generic;

namespace ThreatLockerCommon.DTOs
{
    public class ApplicationHash
    {
        private List<Guid> _applicationIds = new List<Guid>();

        public string Hash { get; set; }
        public Guid[] ApplicationIds => _applicationIds.ToArray();

        public void AddApplicationId(Guid? id)
        {
            if (id != null && id != Guid.Empty)
            {
                _applicationIds.Add((Guid)id);
            }
        }
    }
}