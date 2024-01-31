
using System.Collections;

Queue<string> tasks = new Queue<string>();

string opt;
do
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Show all");
    Console.WriteLine("3. Show next");
    Console.WriteLine("4. Complete");
    Console.WriteLine("0. Exit");

    Console.WriteLine("Select: ");
    opt = Console.ReadLine();
   

    switch (opt)
    {
        case "1":
            string task;
            do
            {
                Console.WriteLine("task: ");
                task = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(task));

            if (tasks.Contains(task))
            {
                Console.WriteLine("Task already added!");
                break;
            }

            tasks.Enqueue(task);
            break;
        case "2":
            Console.WriteLine("\nAll tasks:");
            foreach (var item in tasks)
            {
                Console.WriteLine(item);
            }
            break;
        case "3":
            Console.WriteLine("\nNext task:");
            Console.WriteLine(tasks.Count>0?tasks.Peek():"All tasks are completed!");
            break;
        case "4":
            Console.WriteLine(tasks.Count > 0 ? tasks.Dequeue()+" -  task completed" : "No tasks. All tasks are completed!");
            break;
        case "0":
            Console.WriteLine("Finished");
            break;
        default:
            Console.WriteLine("Try again!");
            break;
    }
} while (opt!="0");


