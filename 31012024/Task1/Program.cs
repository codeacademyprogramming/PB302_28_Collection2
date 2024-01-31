Dictionary<string, byte> groups  = new Dictionary<string, byte>();

string opt;
do
{
    Console.WriteLine("1. Add");
    Console.WriteLine("2. Remove");
    Console.WriteLine("3. Show all");
    Console.WriteLine("0. Exit");

    Console.WriteLine("Select: ");
    opt = Console.ReadLine();

    switch (opt)
    {
        case "1":
            Console.WriteLine("GroupNo: ");
            string groupNo = Console.ReadLine();

            if (groups.ContainsKey(groupNo))
            {
                Console.WriteLine("Group already added!");
                break;
            }


            string stdCountStr;
            byte stdCount;
            do
            {
                Console.WriteLine("StudentCount:");
                stdCountStr = Console.ReadLine();

            } while (!byte.TryParse(stdCountStr,out stdCount));


            groups.Add(groupNo, stdCount);

            break;
        case "2":
            Console.WriteLine("GroupNo: ");
            groupNo = Console.ReadLine();

            if (groups.Remove(groupNo))
                Console.WriteLine("Group successfully removed!");
            else
                Console.WriteLine("Group not found!");
            break;
        case "3":
            foreach (var item in groups)
            {
                Console.WriteLine(item.Key+"-"+item.Value);
            }
            break;
        case "0":
            Console.WriteLine("Finished");
            break;
        default:
            Console.WriteLine("Try again!");
            break;
    }
} while (opt!="0");
;