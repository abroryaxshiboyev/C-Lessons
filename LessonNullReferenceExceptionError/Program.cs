int? value = null;

string? value2 = null;


if (value2 is not null)
{
    System.Console.WriteLine(value2.Length);
}
System.Console.WriteLine(value2 ?? "No value");

System.Console.WriteLine(value2 is not null ? "Has value": "No value");