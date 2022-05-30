using System;
using System.IO;
public class congtyxaydung
{
    public static void Main(string[] args)
    {

        
        thicong[] objthicong = new thicong[1];
        int choice;
        do
        {
            Console.WriteLine("Make a choice from 1 to 3");
            Console.WriteLine("Press 1: Load data");
            Console.WriteLine("Press 2: Show all data");
            Console.WriteLine("Press 3: Exit");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    LoadData(ref objthicong);
                    break;
                case 2:
                    DisplayAllCongtrinh(objthicong);
                    break;
                default:
                    break;
            }
            Console.Clear();
        }

        while (choice != 3);



    }
    public static void LoadData(ref thicong[] objthicong)
    {
        StreamReader reader = new StreamReader("huyanhdeptrai1.txt");


        int size = Convert.ToInt32(reader.ReadLine());
        objthicong = new thicong[size];

        for (int i = 0; i < objthicong.Length; i++)
        {
            objthicong[i] = new thicong();
            objthicong[i].Congtrinh = reader.ReadLine();
            objthicong[i].Giaca = Convert.ToInt32(reader.ReadLine());
            objthicong[i].Thoigian = Convert.ToInt32(reader.ReadLine());

        }
        
        
        reader.Close();
    }
    




        public static void DisplayAllCongtrinh(thicong[] objthicong)
    { 
        Console.Clear();
        for (int i = 0; i < objthicong.Length; i++)
        {
            objthicong[i].DisplayInformation();
        }
        Console.ReadKey();

    }
    

}