﻿using Tutorial4.Models;

namespace Tutorial4.Database;

public class MockDB
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public MockDB()
    {
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
        Animals.Add(new Animal());
    }
}