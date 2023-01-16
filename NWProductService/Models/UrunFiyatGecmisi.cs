using System;
using System.Collections.Generic;

namespace NWProductService.Models;

public partial class UrunFiyatGecmisi
{
    public int Id { get; set; }

    public int? ProductsId { get; set; }

    public decimal? EskiFiyat { get; set; }

    public decimal? YeniFiyat { get; set; }

    public DateTime? DegistirmeTarihi { get; set; }
}
