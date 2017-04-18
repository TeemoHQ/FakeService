using ServiceCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels.Base;
using Newtonsoft.Json.Linq;
using DataBaseTables;

namespace FakeService.Business
{
    public class ProcesserBase : ProcesserBaseInteface
    {
        protected  static string exMsg="[服务端异常]";
        public virtual string Service
        {
            get
            {
                return null;
            }
        }
        public virtual bool CanProcess(GatewayRequest req)
        {
            return req?.service == Service;
        }
        public virtual GatewayResponse Process(JObject req, MyDBContext context)
        {
            throw new NotImplementedException();
        }
    }
}
