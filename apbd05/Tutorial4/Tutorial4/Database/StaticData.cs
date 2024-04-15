using Tutorial4.Models;

namespace Tutorial4.Database;

public class StaticData
{
    public static List<Animal> animals = new List<Animal>()
    {
        new Animal(1, "Piotrus", "krolik", 10, "szary"),
        new Animal(2, "Rafal", "kon", 500, "brazowy"),
        new Animal(3, "Patrycja", "leniwiec", 1000, "rozowy")
    };

    public static List<Visit> visits = new List<Visit>()
    {
        new Visit("01.01.1900", 3, "lenistwo", 5000),
        new Visit("01.03.2003", 2, "wypadajace zeby", 12),
        new Visit("07.11.2015", 1, "przeslodzenie", 3)
    };
}