﻿namespace AssetScope.Shared.Interfaces;

public interface IWorkflow
{
    int Id { get; set; }
    string Name { get; set; }
    string Description { get; set; }
}