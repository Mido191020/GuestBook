using System;
using System.Collections.Generic;
using System.Drawing;

namespace Guest_Book;

public static class GuestLogic
{

    public static void Welcome_Messge()
    {
        Console.WriteLine("\t *** Welcome to the Guest Book ***");
        Console.WriteLine();
    }

    public static string Get_Party_Name()
    {
        Console.WriteLine("enter your group name");
        string name = Console.ReadLine();
        return name;
    }

    public static int Get_Party_Size()
    {
        bool is_valid;
        int size;
        do
        {
            Console.WriteLine("enter your group size");
            string party_size = Console.ReadLine();
            is_valid = Int32.TryParse(party_size, out size);
        } while (is_valid == false);

        return size;

    }

    public static bool AskToContinue()
    {
        Console.Write("Are there more guests coming (yes/no): ");
        string continueLooping = Console.ReadLine();
        bool output = (continueLooping.ToLower() == "yes");
        return output;
    }

    public static (List<string> guests, int total) GetAllGusts()
    {
        List<string> gustst = new List<string>();
        int total = 0;

        do
        {
            gustst.Add(Get_Party_Name());
            total += Get_Party_Size();

        } while (AskToContinue());

        return (gustst, total);
    }

    public static void DisplayGyestes(List<string> guests)
    {
        foreach (var guest in guests)
        {
            Console.WriteLine(guest);
         }
    }

    public static void DisplayGuestCount(int totalGuest)
    {
        Console.WriteLine("thank you for everyone who attended. ");
        Console.WriteLine($"the total guest count for this evening was {totalGuest}.");
    }
}