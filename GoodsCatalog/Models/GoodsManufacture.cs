using GoodsCatalog.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoodsCatalog.Models;

public partial class GoodsManufacture
{
    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public List<Good> Goods { get; set; } = new();
}
