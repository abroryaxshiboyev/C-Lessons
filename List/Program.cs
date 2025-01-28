//CRUD

//Create
List<int> numNums=[1,2,3,4,5,6,7,8,9];

//Read
// foreach (var num in numNums)
// {
//     System.Console.WriteLine(num);
// }

//Update
//This is the fastes
// numNums.Add(0);
//insert
// numNums.Insert(0, 0);

//Delete
var newNum=numNums.Where((i)=>i!=1);

numNums.Remove(2);
numNums.RemoveAt(1);

foreach (var num in numNums)
{
    System.Console.WriteLine(num);
}