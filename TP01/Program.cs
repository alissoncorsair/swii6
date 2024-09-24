using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel;
using TP01;
using TP01.Controller;

// Alisson de Sousa Vieira
// Leonardo de Fontes

var controller = new BookController();

controller.DesmostrarMetodos();

Console.WriteLine("\n\n\n\n");

IWebHost host = new WebHostBuilder()
    .UseKestrel()
    .UseStartup<Startup>()
    .Build();

host.Run();