using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsCatalog.Models;

public partial class Good
{

    public decimal Price { get; set; }
    public string? Description { get; set; }
    public string GoodName { get; set; } = null!;


    public int GoodsTypeId { get; set; }
    public GoodsType? GoodsType { get; set; }
    public int GoodsManufactureId { get; set; }
    public GoodsManufacture? GoodsManufacture { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
}
