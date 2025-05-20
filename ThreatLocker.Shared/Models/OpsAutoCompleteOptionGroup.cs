using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalApi.DTOs
{
    public class OpsAutoCompleteOptionGroup
    {
        public List<OpsAutoCompleteOption> Options { get; set; } = new List<OpsAutoCompleteOption>();
    }
}
