﻿using System.ComponentModel.DataAnnotations;

namespace Catalog.API.Model;

public class CatalogItem
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

}
