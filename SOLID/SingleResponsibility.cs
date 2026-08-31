namespace SOLID.SingleResponsibility;

// SRP: Invoice stores data, InvoiceCalculator calculates, and InvoiceRepository persists.
// Each class therefore has one primary reason to change.
public sealed record Invoice(string Number, decimal Amount);

public sealed class InvoiceCalculator
{
    public decimal CalculateTotal(IEnumerable<decimal> lineItems) => lineItems.Sum();
}

public sealed class InvoiceRepository
{
    public void Save(Invoice invoice) =>
        Console.WriteLine($"SRP: Saved invoice {invoice.Number} for ${invoice.Amount:F2}.");
}

public static class SingleResponsibilityDemo
{
    public static void Run()
    {
        decimal total = new InvoiceCalculator().CalculateTotal([40m, 60m]);
        new InvoiceRepository().Save(new Invoice("INV-1001", total));
    }
}
