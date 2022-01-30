var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var id = 1;

List<Book> books = new();

app.MapGet("/", () => "Hello Kherson!");

app.Run();

record Book(int id, string Title, string Author, int PagesCount, int? VisitorId);
