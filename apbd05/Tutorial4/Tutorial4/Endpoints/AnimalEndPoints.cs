using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class AnimalEndPoints
{
    public static void MapAnimalEndpoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            // 200 - Ok
            // 201 - Created
            // 400 - Bad request
            // 401 - Unauthorized
            // 403 - Forbidden
            // 404 - Not Found
            var animals = StaticData.animals;
    
            return Results.Ok(animals);
        });
        app.MapPost("/animals", (Animal animal) =>
        {
            StaticData.animals.Add(animal);
            return Results.Created("", animal);
        });

        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(StaticData.animals.FirstOrDefault(animal => animal.Id == id));
        });
        app.MapPut("/animals/{id}", (int id, Animal animal) =>
        {
            var cos = StaticData.animals.FirstOrDefault(animal => animal.Id == id);
            StaticData.animals.Remove(cos);
            StaticData.animals.Add(animal);
            return TypedResults.Ok(animal);
        });
        app.MapDelete("/animals/{id}", (int id) =>
        {
            var cos = StaticData.animals.FirstOrDefault(animal => animal.Id == id);
            StaticData.animals.Remove(cos);
            return TypedResults.Ok();
        });
    }
}