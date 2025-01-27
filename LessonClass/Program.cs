using LessonClass;

//CRUD

Rat wolfRat=new Rat();
Rat fancyRat=new Rat();

wolfRat.Name="Wolf Rat";
wolfRat.Number = 1000;
wolfRat.IsRadioactive=false;

fancyRat.Name="Fancy Rat";
fancyRat.Number = 500;
fancyRat.IsRadioactive=false;

//Read
System.Console.WriteLine(wolfRat.Name);
System.Console.WriteLine(fancyRat.Name);

//Update
wolfRat.Name="Updated Wolf Rat";
fancyRat.Name="Updated Fancy Rat";

Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);

//Delete
wolfRat.Name="";
fancyRat.Name="";

Console.WriteLine(wolfRat.Name);
Console.WriteLine(fancyRat.Name);