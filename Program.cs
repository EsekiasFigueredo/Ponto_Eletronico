using Ponto_Eletronico;
using Ponto_Eletronico.Service;
using Ponto_Eletronico.Service.Interface;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddSingleton<IHostedService,Worker>();
builder.Services.AddSingleton<IConnect, SiteConnect>();

var host = builder.Build();
host.Run();
