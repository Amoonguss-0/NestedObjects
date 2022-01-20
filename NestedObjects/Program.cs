using NestedObjects;

Advisor compSciAdvisor = new Advisor()
{
    Email = "Annemarie@cptc.edu",
    FullName = "Annemarie Smith",
    OfficeLocation = "b17 Rm 150"
};

Student stu1 = new Student()
{
    FirstName = "Eric",
    LastName = "Cartman",
    DateOfBirth = new DateOnly(2014, 1, 1),
    AssignedAdvisor = compSciAdvisor,
    PhoneNumber = "3132342321",
    SchoolEmail = "ericcartman@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} {stu1.LastName} has {stu1.AssignedAdvisor.FullName} as their advisor");
Console.ReadKey();