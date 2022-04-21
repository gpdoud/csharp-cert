public class Employee {
    public string? Name { get; set; }
    public string? Company { get; set; }
    public int Age { get; set; }

    public Employee() {
        this.Name = string.Empty;
        this.Company = string.Empty;
        this.Age = 0;
    }
}