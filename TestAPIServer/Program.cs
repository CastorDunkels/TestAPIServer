using System;
WebApplication app = WebApplication.Create();

app.Urls.Add("http://localhost:3000");
app.Urls.Add("http://*:3000");


List<Bengt> dudes = new();
dudes.Add(new(){Name="Bengt Cresson", Level=210, Alive=true});
dudes.Add(new(){Name="Glupp Shitto", Level=10, Alive=true});
dudes.Add(new(){Name="gfds", Level=353, Alive=true});


app.MapGet("/", Answer);

app.MapGet("/Bengt/", () => 
{
    return dudes;
});
app.MapGet("/Bengt/{num}", (int num) => 
{
    if (num >= 0 && num < dudes.Count){
        return Results.Ok(dudes[num]);
    }
    return Results.NotFound();
    
});



app.Run();

static string Answer()
{
    return "Jeff Goldblum";
}