using Homework3;

var service = new Service();

var student = new Student("Anastasiia", "Ivanova");
var employee = new Employee("Jan", "Kowalski");
var laptop = new Laptop(12.0, "13.6", "Model R", true, "black", "macOS");
var camera = new Camera("RAW", "45MP", "45MPCanon R5", true, "white", "Canon");

Console.WriteLine($"Users: {student.Name} (ID:{student.Id}), {employee.Name} (ID:{employee.Id})");

service.RentItem(student, laptop);

try {
    service.RentItem(student, camera); 
    var projector = new Projector("Epson EB", "black",false,"Epson","4K", "LED");
    service.RentItem(student, projector); 
} catch (Exception ex) {
    Console.WriteLine($"Expected error: {ex.Message}");
}

service.PrintReport();