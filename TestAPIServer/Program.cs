using System;
WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");

Bengt bengt = new Bengt();
bengt.Name = "Bengt Cresson";
bengt.Level = 210;
bengt.Alive = true;

app.MapGet("/", Answer);

app.MapGet("/Bengt/", () => 
{
    return bengt;
});

app.MapGet("/Glupp", () => 
{
    return "Glupp Shitto";
});

app.Run();

static string Answer()
{
    return "Jeff Goldblum";
}