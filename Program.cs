var companiesDict = new Dictionary<string, List<Employee>>() {
    ["a"] = new List<Employee>() {
        new Employee() { Name = "Alice", Company = "MAX", Age = 25 },
        new Employee() { Name = "Bill", Company = "PG", Age = 32 },
        new Employee() { Name = "Chris", Company = "MS", Age = 41 }
    },
    ["b"] = new List<Employee>() {
        new Employee() { Name = "Dan", Company = "MS", Age = 33 },
        new Employee() { Name = "Ellen", Company = "MAX", Age = 42 },
        new Employee() { Name = "Fred", Company = "PG", Age = 21 }
    },
    ["c"] = new List<Employee>() {
        new Employee() { Name = "Gloria", Company = "PG", Age = 29 },
        new Employee() { Name = "Heath", Company = "MS", Age = 54 },
        new Employee() { Name = "Jan", Company = "MAX", Age = 33 }
    }
};
var employeeList = new List<Employee>();
// get all the value instances (List<Employee>) of Employee
// put all the employee instances in a single List<Employee>
foreach(var key in companiesDict.Keys) {
    var employees = companiesDict[key];
    employeeList.AddRange(employees);
}
// create a dictionary keyed by Employee.company
var employeesDict = new Dictionary<string, List<Employee>>();
// iterate through the employeeList 
// check if the employee.company exists in the dictionary
// if not, add it. Then add the employee to the company key
// in the dictionary
foreach(var employee in employeeList) {
    if(!employeesDict.ContainsKey(employee.Company!)) {
        employeesDict[employee.Company!] = new List<Employee>();
    }
    employeesDict[employee.Company!].Add(employee);
}
// iterate through the employee dictionary
// and for each key, calculate the avg age 
// of employees per company
foreach(var company in employeesDict.Keys) {
    var emplList = employeesDict[company];
    var avgAge = emplList.Average(x => x.Age);
    var count = emplList.Count();
    var oldest = emplList.OrderByDescending(x => x.Age).First();
    Console.WriteLine($"For company {company} :");
    Console.WriteLine($"  -- Average age is {avgAge:n1}");
    Console.WriteLine($"  -- Count is {count}");
    Console.WriteLine($"  -- Oldest employee is {oldest.Name} at age {oldest.Age}");
    Console.WriteLine();
}