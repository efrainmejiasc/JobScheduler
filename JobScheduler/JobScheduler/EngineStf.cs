using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobScheduler
{
    public class EngineStf
    {
        public async Task<List<KactusIntegration.Empleado>> EmpleadoKactusAsync()
        {
            string resultado = string.Empty;
            string userWcf = "intagata";
            string passwordWcf = "KqQ*O3XI*y";
            KactusIntegration.KWsGhst2Client wsGhst2Client = new KactusIntegration.KWsGhst2Client();
            wsGhst2Client.Endpoint.Binding.SendTimeout = new TimeSpan(0, 5, 0);
            List<KactusIntegration.Empleado> KactusEmpleado = new List<KactusIntegration.Empleado>();
            var response = await wsGhst2Client.ConsultarEmpleadosAsync(499, DateTime.Now.AddDays(-20), userWcf, passwordWcf);
            resultado = Newtonsoft.Json.JsonConvert.SerializeObject(response);
            KactusEmpleado = response.ToList();
            EngineDb Metodo = new EngineDb();
            Metodo.InsertKactusEmpleados("Sp_InsertKactusEmpleado", KactusEmpleado);
            return KactusEmpleado;
        }
    }
}
