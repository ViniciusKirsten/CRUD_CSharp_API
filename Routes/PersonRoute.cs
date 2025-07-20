using Person.Models;

namespace Person.Routes;

//adcionando um arquivo de controle de rotas, para que eu não seixe o meu Program lotado de informações por metodos
public static class PersonRoute//classe responsavel por ter todos os endpoints
{
    public static void PersonRoutes(this WebApplication app) //com o "this" ele entende que esse metodo é um extensão
    {
        //nesse add.Map eu posso ter varios reursos, como (post, put, delete, patch ...)
        app.MapGet("person", () => new PersonModel("Henrique"));
    }
}