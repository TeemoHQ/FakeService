using DataBaseTables;
using DataModels.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCore
{
    public interface ProcesserBaseInteface
    {
        bool CanProcess(GatewayRequest req);
        GatewayResponse Process(JObject req,MyDBContext context);
    }
}
