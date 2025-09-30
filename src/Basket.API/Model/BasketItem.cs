namespace eShop.Basket.API.Model;

// Repräsentiert einen Artikel im Warenkorb
public class BasketItem : IValidatableObject
{
    // Eindeutige ID des Warenkorb-Artikels
    public string Id { get; set; }
    // Produkt-ID
    public int ProductId { get; set; }
    // Name des Produkts
    public string ProductName { get; set; }
    // Aktueller Einzelpreis
    public decimal UnitPrice { get; set; }
    // Vorheriger Einzelpreis
    public decimal OldUnitPrice { get; set; }
    // Anzahl des Produkts im Warenkorb
    public int Quantity { get; set; }
    // Bild-URL des Produkts
    public string PictureUrl { get; set; }

    // Validiert die Eigenschaften des Warenkorb-Artikels
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();

        // Überprüft, ob die Menge gültig ist
        if (Quantity < 1)
        {
            results.Add(new ValidationResult("Invalid number of units", new[] { "Quantity" }));
        }

        return results;
    }
}
