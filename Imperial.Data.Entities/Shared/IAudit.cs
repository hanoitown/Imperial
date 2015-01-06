using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imperial.Data.Entities.Shared
{
    public interface IAudit
    {
        DateTime? Created { set; get; }
        DateTime? LastUpdated { set; get; }
    }
}
