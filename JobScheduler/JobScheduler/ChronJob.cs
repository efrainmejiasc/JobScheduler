using Microsoft.Extensions.Logging;
using Quartz;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobScheduler
{
    [DisallowConcurrentExecution]
    public class ChronJob : IJob
    {
        private readonly ILogger<ChronJob> _logger;
        public ChronJob(ILogger<ChronJob> logger)
        {
            _logger = logger;
            GetKactusEmpleadoAsync();
        }

        public Task Execute(IJobExecutionContext context)
        { 
            _logger.LogInformation("Ejecutado");
            return Task.CompletedTask;
        }

        private async Task<List<KactusIntegration.Empleado>> GetKactusEmpleadoAsync()
        {
            EngineStf Funcion = new EngineStf();
            List<KactusIntegration.Empleado> empleado = new List<KactusIntegration.Empleado>();
            empleado = await Funcion.EmpleadoKactusAsync();
            return empleado;
        }

    }
}
