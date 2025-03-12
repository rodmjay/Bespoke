namespace TranslationPro.Domain.Entities;

public class PriceTier
{
    public long? FlatAmount { get; set; }

    public decimal? FlatAmountDecimal { get; set; }

    public long? UnitAmount { get; set; }

    public decimal? UnitAmountDecimal { get; set; }
    public long? UpTo { get; set; }
}