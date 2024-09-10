using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oracle.ManagedDataAccess.Client;

namespace oracle_test;

public class MyDbcontext : DbContext
{
    public DbSet<Person> pepole { set; get; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var tnsAlias = "local"; // TnsName
        var userId = "SWIFTMX";
        var password = "1";

        optionsBuilder.UseOracle($"Data Source={tnsAlias};User ID={userId};Password={password};");

        base.OnConfiguring(optionsBuilder);
    }
}