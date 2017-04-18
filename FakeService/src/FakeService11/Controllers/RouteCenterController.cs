using DataHandler;
using DataModels.Base;
using FakeService.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Runtime.Loader;
using System.Reflection;
using ServiceCore;
using System.Text;
using Newtonsoft.Json.Linq;
using DataBaseTables;
using System.Threading;

namespace FakeService.Controllers
{
    [Route("api/RouteCenter")]
    public class RouteCenterController : Controller
    {
        protected static DBContext _context;
        public RouteCenterController(DBContext context)
        {
            _context = context;
        }
        public string Post(JObject data)
        {
            var req = data.ToObject<GatewayRequest>();
            foreach (var item in SystemStartup._lp)
            {
                if (item.CanProcess(req))
                {
                    return JsonConvert.SerializeObject(item.Process(data, _context));;
                }
            }
            return JsonConvert.SerializeObject(new GatewayResponse { success=false,msg="找不到对应服务" });
        } 
    }
}
