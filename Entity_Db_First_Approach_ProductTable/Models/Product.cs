using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entity_Db_First_Approach.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    public double? Price { get; set; }

    public int? Qty { get; set; }
}
