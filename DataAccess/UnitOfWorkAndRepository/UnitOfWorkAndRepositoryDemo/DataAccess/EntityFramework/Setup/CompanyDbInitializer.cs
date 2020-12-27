using System;
using System.Collections.Generic;
using System.Data.Entity;
using UnitOfWorkAndRepositoryDemo.Models;
using UnitOfWorkAndRepositoryDemo.Models.Enums;

namespace UnitOfWorkAndRepositoryDemo.DataAccess.EntityFramework.Setup
{
    public class CompanyDbInitializer : CreateDatabaseIfNotExists<CompanyDbContext>
    {
        protected override void Seed(CompanyDbContext context)
        {
            var customers = new Customer[]
            {
                new Customer { Age = 24, FirstName = "Adam", LastName = "Park", Gender = Gender.Male, IdentityNumber = "78112344240" },
                new Customer { Age = 68, FirstName = "Jan", LastName = "Stankowski", Gender = Gender.Male, IdentityNumber = "78112344241" },
                new Customer { Age = 17, FirstName = "Ewa", LastName = "Kot", Gender = Gender.Female, IdentityNumber = "78112344242" },
                new Customer { Age = 29, FirstName = "Kinga", LastName = "Mądra", Gender = Gender.Female, IdentityNumber = "92112444243" },
                new Customer { Age = 40, FirstName = "Paweł", LastName = "Szot", Gender = Gender.Male, IdentityNumber = "78112344244" },
                new Customer { Age = 35, FirstName = "Anna", LastName = "Jaroszek", Gender = Gender.Female, IdentityNumber = "78112344245" },
                new Customer { Age = 42, FirstName = "Cezary", LastName = "Kurdej", Gender = Gender.Undefined, IdentityNumber = "78112344246" },
                new Customer { Age = 70, FirstName = "Agata", LastName = "Mąka", Gender = Gender.Female, IdentityNumber = "78112344247" },
            };

            var products = new Product[]
            {
                new Product { ProductCode = "C0001", Name = "CPU INTEL Core i5-10600", UnitPrice = 1166, Category = ProductCategory.CPU },
                new Product { ProductCode = "C0002", Name = "CPU INTEL Core i7-10700", UnitPrice = 1620, Category = ProductCategory.CPU },
                new Product { ProductCode = "C0003", Name = "Intel Processor Xeon Silver 4208", UnitPrice = 2020.50M, Category = ProductCategory.CPU },
                new Product { ProductCode = "C0004", Name = "Processor CPU Intel Core i9-10920 X", UnitPrice = 3439, Category = ProductCategory.CPU },
                new Product { ProductCode = "G0001", Name = "GeForce GT710 1GB GDDR5", UnitPrice = 205.86M, Category = ProductCategory.GPU },
                new Product { ProductCode = "G0002", Name = "GeForce GT730 2GB DDR3", UnitPrice = 322.39M, Category = ProductCategory.GPU },
                new Product { ProductCode = "G0003", Name = "Asus GeForce GT 1030 2GB", UnitPrice = 524, Category = ProductCategory.GPU },
                new Product { ProductCode = "G0004", Name = "Quadro P100v2 4GB DDR5", UnitPrice = 1720, Category = ProductCategory.GPU },
                new Product { ProductCode = "R0001", Name = "RAM 2GB Lenovo IdeaCentre Q200", UnitPrice = 58, Category = ProductCategory.RAM },
                new Product { ProductCode = "R0002", Name = "RAM 4GB Samsung PC3-12800U", UnitPrice = 94, Category = ProductCategory.RAM },
                new Product { ProductCode = "R0003", Name = "Premier DD4 3200 DIMM 8GB", UnitPrice = 151, Category = ProductCategory.RAM },
                new Product { ProductCode = "D0001", Name = "Fuijitsu MHW2080BH 80 GB", UnitPrice = 62, Category = ProductCategory.Drive },
                new Product { ProductCode = "D0002", Name = "HDD SeaGate Barracuda 1 TB", UnitPrice = 172.56M, Category = ProductCategory.Drive },
                new Product { ProductCode = "D0003", Name = "Toshiba HDD P300 2TB", UnitPrice = 272, Category = ProductCategory.Drive },
            };

            var transactions = new Transaction[]
            {
                new Transaction
                {
                    DateTime = new DateTime(2020, 01, 05),
                    Customer = customers[1],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[0], Quantity = 4},
                        new TransactionLine { LineNum = 2, Product = products[7], Quantity = 2}
                    }
                },
                new Transaction
                {
                    DateTime = new DateTime(2020, 03, 09),
                    Customer = customers[3],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[1], Quantity = 1},
                        new TransactionLine { LineNum = 2, Product = products[10], Quantity = 1}
                    }
                },
                new Transaction
                {
                    DateTime = new DateTime(2020, 05, 22),
                    Customer = customers[7],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[1], Quantity = 1},
                        new TransactionLine { LineNum = 2, Product = products[9], Quantity = 2},
                        new TransactionLine { LineNum = 3, Product = products[6], Quantity = 4},
                        new TransactionLine { LineNum = 4, Product = products[3], Quantity = 5}
                    }
                },
                 new Transaction
                {
                    DateTime = new DateTime(2020, 07, 20),
                    Customer = customers[7],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[0], Quantity = 1},
                        new TransactionLine { LineNum = 2, Product = products[4], Quantity = 3},
                        new TransactionLine { LineNum = 3, Product = products[5], Quantity = 2}
                    }
                },
                  new Transaction
                {
                    DateTime = new DateTime(2020, 09, 01),
                    Customer = customers[2],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[1], Quantity = 1},
                        new TransactionLine { LineNum = 2, Product = products[3], Quantity = 3},
                        new TransactionLine { LineNum = 3, Product = products[7], Quantity = 2}
                    }
                },
                   new Transaction
                {
                    DateTime = new DateTime(2020, 09, 20),
                    Customer = customers[4],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[0], Quantity = 4},
                        new TransactionLine { LineNum = 2, Product = products[7], Quantity = 8},
                    }
                },
                   new Transaction
                {
                    DateTime = new DateTime(2020, 10, 07),
                    Customer = customers[5],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[2], Quantity = 1},
                        new TransactionLine { LineNum = 2, Product = products[6], Quantity = 1},
                        new TransactionLine { LineNum = 3, Product = products[4], Quantity = 2},
                    }
                },
                   new Transaction
                {
                    DateTime = new DateTime(2020, 11, 03),
                    Customer = customers[4],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[0], Quantity = 1},
                        new TransactionLine { LineNum = 2, Product = products[7], Quantity = 3},
                        new TransactionLine { LineNum = 3, Product = products[2], Quantity = 2}
                    }
                },
                     new Transaction
                {
                    DateTime = new DateTime(2020, 12, 01),
                    Customer = customers[0],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[5], Quantity = 4}
                    }
                },
                      new Transaction
                {
                    DateTime = new DateTime(2020, 12, 13),
                    Customer = customers[6],
                    Lines = new List<TransactionLine>
                    {
                        new TransactionLine { LineNum = 1, Product = products[2], Quantity = 1},
                        new TransactionLine { LineNum = 2, Product = products[7], Quantity = 3}
                    }
                }
            };

            context.Customers.AddRange(customers);
            context.Products.AddRange(products);
            context.Transactions.AddRange(transactions);

            base.Seed(context);
        }
    }
}
