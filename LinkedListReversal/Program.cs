namespace LinkedListReversal
{
    public class Program
    {
        static void Main(string[] args)
        {
            List myList = new List();
            myList.FillListFirst(10);
            myList.Print();
            myList.ReverList();
            myList.Print();
        }
    }
}