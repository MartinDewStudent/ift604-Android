﻿namespace BroomitApi.Models;

public class BroomitDatabaseSettings
{
    public string ConnectionString { get; set; } = null!;
    public string DatabaseName { get; set; } = null!;
    public string UsersCollectionName { get; set; } = null!;
    public string LocationsCollectionName { get; set; } = null!;
}