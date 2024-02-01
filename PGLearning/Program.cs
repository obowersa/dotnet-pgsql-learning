// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.Hosting;

var builder = Host.CreateDefaultBuilder(args);

builder.ConfigureServices((context, services) =>
{

});

var app = builder.Build();
await app.RunAsync();