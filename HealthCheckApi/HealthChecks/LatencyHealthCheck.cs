using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace BlazorServerDemo.HealthChecks
{
    public class LatencyHealthCheck : IHealthCheck
    {
        private Random random = new Random();
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            int latency = random.Next(1,20);

            /* Aca llamariamos a los servicios. Una clase HealthCheck por servicio que implemente la interfaz IHealthCheck
            AutoConsultaSfdcSoapClient cliente = new AutoConsultaSfdcSoapClient(AutoConsultaSfdcSoapClient.EndpointConfiguration.AutoConsultaSfdcSoap);
            GetClienteResponse  response=cliente.RetrieveCliente("1789");

            if (response.Body.CodigoResultado=="0")
            {
                return Task.FromResult(HealthCheckResult.Healthy("Recuperacion del cliente OK"));
            } 
            */
 
              
              
             
         

            if (latency<5)
            {
                return Task.FromResult(HealthCheckResult.Healthy($"Latencia es ok({latency})"));
            }
            else if (latency<10)
            {
                return Task.FromResult(HealthCheckResult.Degraded($"Latencia puede mejorar ({latency})"));
            }
            else
            {
                return Task.FromResult(HealthCheckResult.Unhealthy($"Latencia tiene que mejorar ({latency})"));
            }

        }
    }
}
