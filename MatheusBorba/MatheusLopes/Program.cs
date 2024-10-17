using MatheusLopes.funcionario;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Funcionario> funcionarios = [
];

List<FolhaPagamento> folhaPagamentos = [
];

app.MapGet("/", () => "ola mundo");


//listpessoa
app.MapGet("/api/produto/listar", () =>
{
    if (funcionarios.Any())
    {
        return Results.Ok(funcionarios);
    }
    return Results.NotFound();
});


//cadastro pessoa
app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionario) =>
{
    funcionarios.Add(funcionario);
    return Results.Created("", funcionario);
});


//list folha
app.MapGet("/api/folha/pagamento/listar", () =>
{
    if (folhaPagamentos.Any())
    {
        return Results.Ok(folhaPagamentos);
    }
    return Results.NotFound();
});


//cadastro folha
app.MapPost("/api/folha/cadastrar", ([FromBody] FolhaPagamento folhaPagamento) =>
{
    folhaPagamentos.Add(folhaPagamento);
    return Results.Created("", folhaPagamento);
});

app.MapGet("/api/folha/buscar/{id}", ([FromRoute] string id) =>
{
    FolhaPagamento? folha = folhaPagamentos.Find(X => X.Id == id);
    if (folha == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(folha);
});

app.Run();
