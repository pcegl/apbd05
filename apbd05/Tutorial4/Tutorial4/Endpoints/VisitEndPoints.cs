using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Endpoints;

public static class VisitEndPoints
{
    public static void MapVisitEndPoints(this WebApplication app)
    {
        app.MapGet("/animals/visits/{id}", (int id) =>
        {
            var visitsOfAnimal = new List<Visit>();
            foreach (var visit in StaticData.visits)
            {
                if (visit.AnimalID == id) visitsOfAnimal.Add(visit);
            }
            return TypedResults.Ok(visitsOfAnimal);
        });
        app.MapPost("/animals/visits", (Visit visit) =>
        {
            StaticData.visits.Add(visit);
            return TypedResults.Ok(StaticData.visits);
        });
    }
}