

using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using oracle_test;

var db = new MyDbcontext();

//db.Add(new Person()
//{
//    Id = 11,
//    Name = "معین"
//});

//await db.SaveChangesAsync();
var result = await db.pepole.ToListAsync();

Console.WriteLine(JsonSerializer.Serialize(result , new JsonSerializerOptions(){WriteIndented = true}));