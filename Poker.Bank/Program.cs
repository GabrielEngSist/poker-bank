using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Poker.Core.Models;
using Poker.Bank;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var casa_waguinho = new House
{
    Name = "Waguinho",
    Description = "Casa do Waguinho, Cidade Verde"
};

var casa_luciano = new House
{
    Name = "Luciano",
    Description = "Casa do Luciano, Cidade Verde"
};

var gabrielOliveira = new Player
{
    Id = Guid.NewGuid(),
    Name = "Gabriel Oliveira Silva",
};

var arthur = new Player
{
    Id = Guid.NewGuid(),
    Name = "Arthur"
};

var rodrigo = new Player
{
    Id = Guid.NewGuid(),
    Name = "Rodrigo"
};

var wagner = new Player
{
    Id = Guid.NewGuid(),
    Name = "Wagner"
};

var renato = new Player
{
    Id = Guid.NewGuid(),
    Name = "Renato"
};

var natura = new Player
{
    Id = Guid.NewGuid(),
    Name = "Renato Natura"
};

var dionathan = new Player
{
    Id = Guid.NewGuid(),
    Name = "Dionathan"
};

var alexandre = new Player
{
    Id = Guid.NewGuid(),
    Name = "Alexandre"
};

var fred = new Player
{
    Id = Guid.NewGuid(),
    Name = "Fred"
};

var luciano = new Player
{
    Id = Guid.NewGuid(),
    Name = "Luciano"
};

var diego = new Player
{
    Id = Guid.NewGuid(),
    Name = "Diego"
};

var bani = new Player
{
    Id = Guid.NewGuid(),
    Name = "Bani"
};

var joaoVitor = new Player
{
    Id = Guid.NewGuid(),
    Name = "João Vitor"
};

var senna = new Player
{
    Id = Guid.NewGuid(),
    Name = "Senna"
};

var gabriel = new Player
{
    Id = Guid.NewGuid(),
    Name = "Gabriel"
};

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

await builder.Build().RunAsync();
