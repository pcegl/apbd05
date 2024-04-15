namespace Tutorial4.Models;

public class Visit
{
    public string Date { get; set; }
    public int AnimalID { get; set; }
    public string VisitDescription { get; set; }
    public double VisitPrice { get; set; }

    public Visit(string date, int animalId, string visitDescription, double visitPrice)
    {
        Date = date;
        AnimalID = animalId;
        VisitDescription = visitDescription;
        VisitPrice = visitPrice;
    }}