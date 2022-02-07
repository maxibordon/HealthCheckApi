using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorServerDemo.HealthChecks
{
    public class RespuestaCheck : IHealthCheck
    {

        Task<HealthCheckResult> IHealthCheck.CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken)
        {
            int latency = 0;  
            return Task.FromResult(HealthCheckResult.Healthy($"Latencia es ok({latency})"));
        }
    }
}
