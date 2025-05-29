using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference2 = new Reference("Alma", 38,1);
        Reference reference3 = new Reference("Alma", 38, 1,2);

        Scripture scripture1 = new Scripture(reference2, "My son, give ear to my words, for I say unto you, even  as I say unto you, even as I said unto helaman, that inasmuch as ye shall keep the commandments of God ye shall prosper in the Land; and inasmuch as ye will not keep the commandmentsof God ye shall be cut off from his presence");
        Scripture scripture2 = new Scripture(reference3, "1 My son, give ear to my words, for I say unto you, even  as I say unto you, even as I said unto helaman, that inasmuch as ye shall keep the commandments of God ye shall prosper in the Land; and inasmuch as ye will not keep the commandmentsof God ye shall be cut off from his presence.   2 And now, my son, I trust that I shall have great joy in you, because of your steadiness and your faithfulness unto God; for as you have commenced in your youth to look to the Lord your God, even so I hope that you will continue in keeping his commandments, for blessed is he that endureth to the end");

       while (true)
       {
            Console.Clear();
            Console.WriteLine(scripture2.GetDisplayText());
            Console.WriteLine("Please click Enter, or type quit to exit: ");
            //ConsoleKeyInfo Key = Console.ReadKey(true); 
            //var key=Console.ReadKey();
            string user = Console.ReadLine();
            if (user.ToLower() == "quit")
            {
                Console.WriteLine("Please come back later.");
                break;
            }
            //if (key.Key ==ConsoleKey.Enter)
            if(string.IsNullOrEmpty(user))
            {
                scripture2.HideRandomWords(1);

                if (scripture2.isCompletelyHidden())
                {
                    Console.Clear();
                    Console.WriteLine("All the words have been hide.");
                    break;
                }
            }
            
            
            
                       
       }

        
    }
}