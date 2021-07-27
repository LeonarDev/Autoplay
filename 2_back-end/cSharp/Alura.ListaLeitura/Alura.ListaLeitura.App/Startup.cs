using Alura.ListaLeitura.App.Negocio;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alura.ListaLeitura.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //IServiceCollection services = new blaBLAbla;
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            var roteBuilder = new RouteBuilder(app);
            roteBuilder.MapRoute("Livros/ParaLer", LivrosParaLer);
            roteBuilder.MapRoute("Livros/Lendo", LivrosLendo);
            roteBuilder.MapRoute("Livros/Lidos", NovoLivroParaLer);
            roteBuilder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", NovoLivroParaLer);
            roteBuilder.MapRoute("Livros/Detalhes/{id:int}", ExibirDetalhes);
            var rotas = roteBuilder.Build();

            app.UseRouter(rotas);
            //app.Run(Roteamento);
        }

        public Task ExibirDetalhes(HttpContext context)
        {
            int id = Convert.ToInt32(context.GetRouteValue("id"));
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(item => item.Id == id);
            return context.Response.WriteAsync(livro.Detalhes());
        }

        //public Task Roteamento(HttpContext context)
        //{
        //    var _repo = new LivroRepositorioCSV();
        //    var rotas = new Dictionary<string, RequestDelegate>
        //    {
        //        { "/Livros/ParaLer", LivrosParaLer },
        //        { "/Livros/Lendo", LivrosLendo },
        //        { "/Livros/Lidos", NovoLivroParaLer }
        //    };

        //    if (rotas.ContainsKey(context.Request.Path))
        //    {
        //        var metodo = rotas[context.Request.Path];
        //        return metodo.Invoke(context);
        //    }
        //    context.Response.StatusCode = 404;
        //    return context.Response.WriteAsync("Erro 404: Pagina nao encontrada!");
        //}

        public Task LivrosParaLer(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.ParaLer.ToString());
        }

        public Task LivrosLendo(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lendo.ToString());
        }

        public Task LivrosLidos(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lidos.ToString());
        }

        public Task NovoLivroParaLer(HttpContext context)
        {
            var livro = new Livro()
            {
                Titulo = context.GetRouteValue("nome").ToString(), // captura informação mapeada da rota e converte obj para string
                Autor = Convert.ToString(context.GetRouteValue("autor")) // converte obj para string (outra forma)
            };
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return context.Response.WriteAsync("Livro adicionado com sucesso!");
        }
    }
}