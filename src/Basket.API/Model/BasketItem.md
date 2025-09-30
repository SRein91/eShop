# BasketItem

Die Klasse `BasketItem` repräsentiert einen einzelnen Artikel im Warenkorb eines Benutzers.

## Eigenschaften

- **Id**: Eindeutige ID des Warenkorb-Artikels (Typ: `string`)
- **ProductId**: Produkt-ID (Typ: `int`)
- **ProductName**: Name des Produkts (Typ: `string`)
- **UnitPrice**: Aktueller Einzelpreis des Produkts (Typ: `decimal`)
- **OldUnitPrice**: Vorheriger Einzelpreis des Produkts (Typ: `decimal`)
- **Quantity**: Anzahl des Produkts im Warenkorb (Typ: `int`)
- **PictureUrl**: Bild-URL des Produkts (Typ: `string`)

## Methoden

### Validate

```csharp
public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
```

Validiert die Eigenschaften des Warenkorb-Artikels. Überprüft insbesondere, ob die Menge (`Quantity`) mindestens 1 beträgt.

## Beispiel

```csharp
var item = new BasketItem
{
    Id = "123",
    ProductId = 456,
    ProductName = "Beispielprodukt",
    UnitPrice = 19.99m,
    OldUnitPrice = 24.99m,
    Quantity = 2,
    PictureUrl = "https://example.com/image.jpg"
};
```

## Hinweise

- Die Klasse implementiert das Interface `IValidatableObject`, um die Validierung der Eigenschaften zu ermöglichen.
- Die Validierungsmethode gibt eine Fehlermeldung zurück, wenn die Menge kleiner als 1 ist.
