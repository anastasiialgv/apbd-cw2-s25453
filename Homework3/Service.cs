namespace Homework3;

public class Service
{
    private readonly List<Rental> _rentals = new();
    private readonly decimal _dailyPenalty = 5.0m; 

    public void RentItem(User user, Equipment item)
    {
        if (!item.Available)
            throw new Exception($"Error. Item is not available");

        int activeRentals = _rentals.Count(r => r.Borrower.Id == user.Id && r.ActualReturnDate == null);
        if (activeRentals >= user.MaxRental)
            throw new Exception($"Error! You out of limit");
        
        item.Available = false;
        _rentals.Add(new Rental(user, item, 7)); 
    }

    public void ReturnItem(int equipmentId)
    {
        var rental = _rentals.FirstOrDefault(r => r.Item.Id == equipmentId && r.ActualReturnDate == null);
        
        if (rental == null) 
            throw new Exception("Error");

        rental.ActualReturnDate = DateTime.Now;
        rental.Item.Available = true;

        if (rental.IsOverdue)
        {
            var delay = (rental.ActualReturnDate.Value - rental.PlannedReturnDate).Days;
            if (delay <= 0) delay = 1; 
            decimal penalty = delay * _dailyPenalty;
        }
 
    }

    public List<Rental> GetOverdueRentals() => _rentals.Where(r => r.IsOverdue).ToList();

 
    public void PrintReport()
    {
        Console.WriteLine("\n--- Report ---");
        Console.WriteLine($"Total amount: {_rentals.Count}");
        Console.WriteLine($"Overdue rentals: {GetOverdueRentals().Count}");
    }
}