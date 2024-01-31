#region Collection-List
using CollectionLesson;

List<int> numList= new List<int>() { 45,10,3,65};
numList.Add(10);
numList.Add(100);

numList.Remove(45);
numList.RemoveAt(0);
numList.RemoveRange(0, 2);
bool checkValue = numList.Contains(10);
int wantedIndex = numList.IndexOf(45);

var result = wantedIndex == -1 ? "item not found" : "item exist";

var avg = numList.Average();
var sum = numList.Sum();
var min = numList.Min();
var max = numList.Max();    

Console.WriteLine(result);
Console.WriteLine(avg);
Console.WriteLine(sum);
numList.Insert(0, 60);
numList.Sort();
numList.Reverse();
numList.Add(100);
Console.WriteLine("\nItems:");
foreach (var item in numList)
{
    Console.WriteLine(item);
}

numList = numList.Distinct().ToList();



Console.WriteLine("\nItems:");
for (int i = 0; i < numList.Count; i++)
{
    Console.WriteLine(numList[i]);
}
#endregion

#region Collection-Dictionary
Dictionary<string, int> humans = new Dictionary<string, int>();
humans.Add("Hikmet", 55);
humans.Add("Nermin", 65);
humans.Add("Tofiq", 15);
humans.Add("Abbas", 45);

var hasKey = humans.ContainsKey("Tofiq");
Console.WriteLine(hasKey);

var addResult = humans.TryAdd("Nezrin", 55);
Console.WriteLine(addResult);

var keys = humans.Keys;
var values = humans.Values;

Console.WriteLine("Dictionary Values:");
foreach (var item in values)
{
    Console.WriteLine(item);
}

Console.WriteLine("Dictionary Keys:");
foreach (var item in keys)
{
    Console.WriteLine(item);
}

humans.Remove("Hikmet");
int hikmetAge;
humans.TryGetValue("Hikmet", out hikmetAge);

Console.WriteLine("Dictionary Items:");
foreach (var item in humans)
{
    Console.WriteLine(item.Key+": "+item.Value);
}




#endregion

#region Collection-SortedList
SortedList<string, int> namesSortedList = new SortedList<string, int>(humans);

Console.WriteLine("Sorted list items:");
foreach (var item in namesSortedList)
{
    Console.WriteLine(item.Key+": "+item.Value);
}

var sortedItem = namesSortedList["Nermin"];
namesSortedList.RemoveAt(0);
#endregion

#region Collection-Queue
Queue<int> numQueue = new Queue<int>(numList);


numQueue.Enqueue(55);
var removedItem = numQueue.Dequeue();
var nextElement = numQueue.Peek();

Console.WriteLine("Queue items:");
foreach (var item in numQueue)
{
    Console.WriteLine(item);
}

#endregion

#region Collection-Stack
Stack<int> numStack = new Stack<int>(numQueue);


numStack.Push(15);
var removedStackItem = numStack.Pop();
var nextStackItem = numStack.Peek();


Console.WriteLine("\nStack items");
foreach (var item in numStack)
{
    Console.WriteLine(item);
}

var newColection = numStack.Append(40);

Console.WriteLine("\nIEnumarable items:");
foreach (var item in newColection)
{
    Console.WriteLine(item);
}

#endregion

#region Collection-Hashset


Human hmn1 = new Human { Name = "Name1" };
Human hmn2 = new Human { Name = "Name2" };
Human hmn3 = new Human { Name = "Name1" };
Human hmn4 = hmn1;

HashSet<Human> humanSet = new HashSet<Human>();
humanSet.Add(hmn1);
humanSet.Add(hmn2);
humanSet.Add(hmn3);
humanSet.Add(hmn4);

Console.WriteLine("Set items:");
foreach (var item in humanSet)
{
    Console.WriteLine(item.Name);
}

Console.WriteLine(hmn1.Equals(hmn2)); //false
Console.WriteLine(hmn1.Equals(hmn3)); //true
Console.WriteLine(hmn1.Equals(hmn4)); //true

Console.WriteLine(hmn1 == hmn2); //false
Console.WriteLine(hmn1 == hmn3); //false
Console.WriteLine(hmn1 == hmn4); //true

Console.WriteLine("Human1: "+hmn1.Name); //Name1
Console.WriteLine("Human4: " + hmn4.Name);//Name1

hmn4.Name = "Hikmet";

Console.WriteLine("Human1: " + hmn1.Name); //Hikmet
Console.WriteLine("Human4: " + hmn4.Name); //Hikmet

HashSet<int> numSet = new HashSet<int>();
numSet.Add(1);
numSet.Add(1);
numSet.Add(3);
numSet.Add(1);













#endregion
