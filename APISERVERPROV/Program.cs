using APISERVERPROV;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

app.Urls.Add("http://*:5258");

StudentCollection collection = new();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hello", () => "Goodbye");

app.MapGet("/students/{number}", collection.GetStudent);

app.Run();




