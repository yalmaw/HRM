using HRM.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRM.API.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Name = "Md. Mahedee Hasan",
                    Designation = "Head of Software Development",
                    FathersName = "Yeasin Bhuiyan",
                    MothersName = "Moriom Begum",
                    DateOfBirth = new DateTime(1984, 12, 19, 00, 00, 00)

                },

                    new Employee
                    {
                        Name = "Khaleda Islam",
                        Designation = "Software Engineer",
                        FathersName = "Shahidul Islam",
                        MothersName = "Momtaz Begum",
                        DateOfBirth = new DateTime(1990, 10, 29, 00, 00, 00)
                    },

                    new Employee
                    {
                        Name = "Tahiya Hasan Arisha",
                        Designation = "Jr. Software Engineer",
                        FathersName = "Md. Mahedee Hasan",
                        MothersName = "Khaleda Islam",
                        DateOfBirth = new DateTime(2017, 09, 17, 00, 00, 00)
                    },

                    new Employee
                    {
                        Name = "Humaira Hasan",
                        Designation = "Jr. Software Engineer",
                        FathersName = "Md. Mahedee Hasan",
                        MothersName = "Khaleda Islam",
                        DateOfBirth = new DateTime(2021, 03, 17, 00, 00, 00)
                    }
                );
        }
    }
}
