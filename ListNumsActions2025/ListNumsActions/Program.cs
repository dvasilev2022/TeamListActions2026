namespace ListNumsActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins": int index= int.Parse(cmd[1]);
                        int num = int.Parse(cmd[2]);
                        nums.Insert(index,num);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
<<<<<<< HEAD
                    case "del":

                        
                        
                        break;
                    case "remove":
                        int removeIndex = int.Parse(cmd[1]);
                        nums.RemoveAt(removeIndex);
                        break;

=======

                    case "contains": int element= int.Parse(cmd[1]);
                        if(nums.Contains(element))
                            Console.WriteLine("Yes");
                        else Console.WriteLine("No");
                        break;
                    case "del": element= int.Parse(cmd[1]);
                        nums.Remove(element);
                        break;
                    case "add": int num1= int.Parse(cmd[1]);
                        int num2= int.Parse(cmd[2]);
                        nums.Add(num1+num2);
                        break;

                    //TO DO
>>>>>>> 02a8bec847d4495ab71738c649c6489a4292fc61
                    default:
                        break;
                }
            }
        }
    }
}
