namespace Homework3;

public class Rental
{
    public User Borrower { get; set; }
    public Equipment Item { get; set; }
    public DateTime RentalDate { get; set; }
    public DateTime PlannedReturnDate { get; set; }
    public DateTime? ActualReturnDate { get; set; }

    public Rental(User user, Equipment item, int days)
    {
        Borrower = user;
        Item = item;
        RentalDate = DateTime.Now;
        PlannedReturnDate = DateTime.Now.AddDays(days);
    }

    public bool IsOverdue => ActualReturnDate == null 
        ? DateTime.Now > PlannedReturnDate 
        : ActualReturnDate > PlannedReturnDate;
}