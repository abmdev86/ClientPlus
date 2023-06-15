// See https://aka.ms/new-console-template for more information



using ClientPlus.Data.Entities;
using ClientPlus.Data.Repositories;

var employeeRepository = new GenericRepository<Employee>();
var organizationRepo = new GenericRepository<Organization>();
employeeRepository.Add(new Employee { FirstName = "Auroiah" });
organizationRepo.Add(new Organization { Name = "Morgan Security" });

employeeRepository.Save();
organizationRepo.Save();
Console.ReadLine();
