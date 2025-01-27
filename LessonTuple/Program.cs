var values=("t",2,"p");
System.Console.WriteLine(values.Item1);
System.Console.WriteLine(values.Item2);
System.Console.WriteLine(values.Item3);

var valuesWithName=(First:"t",Second:2,Third:"p");

System.Console.WriteLine(valuesWithName.First);
System.Console.WriteLine(valuesWithName.Second);
System.Console.WriteLine(valuesWithName.Third);

(int a,string b,bool c) ReturnTheseValues()
{
    return (10,"Hello",true);
}

(int a,string b,bool c)=ReturnTheseValues();

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);