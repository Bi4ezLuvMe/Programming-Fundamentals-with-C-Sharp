using System.Data;

namespace ConsoleApp16
{
    class Box
    {
        public int serialNumber;
        public string item;
        public int itemQuantity;
        public double priceForBox;
        public double totalPrice;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>(); 
            while(command != "end")
            {
                string[] commandAsAnArray = command.Split();
                Box box = new Box();
                box.serialNumber = int.Parse(commandAsAnArray[0]);
                box.item = commandAsAnArray[1];
                box.itemQuantity= int.Parse(commandAsAnArray[2]);
                box.priceForBox = double.Parse(commandAsAnArray[3]);
                box.totalPrice = box.itemQuantity * box.priceForBox;
                boxes.Add(box);
                command = Console.ReadLine();
            }
            List<Box>sorted = boxes.OrderByDescending(boxes => boxes.totalPrice).ToList();
            foreach(Box boxs in sorted)
            {
                Console.WriteLine($"{boxs.serialNumber}");
                Console.WriteLine($"-- {boxs.item} - ${boxs.priceForBox:f2}: {boxs.itemQuantity}");
                Console.WriteLine($"-- ${boxs.totalPrice:f2}");
            }
        }
    }
}