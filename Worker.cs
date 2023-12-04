using Ponto_Eletronico.Service.Interface;

namespace Ponto_Eletronico
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private IConnect _connect;

        public Worker(ILogger<Worker> logger, IConnect connect)
        {
            _logger = logger;
            _connect = connect;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    var dia = DateTime.Now.ToString("dd/MM/yyyy");
                    var atividade = "Teste";
                    var hrs = "08:00";
                    _connect.hr(dia, atividade, hrs);
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
