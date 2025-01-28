Person person1=new("Abror","Yakhshiboev");
Person person2=new("Abror","Yakhshiboev");

//Shallow Immutability
// person1.LastName="abror";
// person1.PhoneNumbers[0]="998-590-03-43";

//Equality
//Value - 1. Check the type 2. Check the contents
//Referential - 2. By memory
Console.WriteLine(person1==person2);

//Non-destructive Mutation (Copy)
Person person3=person1 with { LastName="Yakhshiboyev" };
Console.WriteLine(person3.ToString()); // "Yakhshiboev"

public record Person(string FirstName, string LastName);