using System;
using System.IO;



public class thicong
{
    private string congtrinh;
    private int giaca;
    private int thoigian;
    

    public string Congtrinh
    {
        get { return congtrinh; }
        set { congtrinh = value; }
    }
    public int Giaca
    {
        get { return giaca; }
        set { giaca = value; }
        
    }
    public int Thoigian
    {
        get { return thoigian; }
        set { thoigian = value; }
    }
    
    public void DisplayInformation()
    {
        Console.WriteLine("{0} ", Congtrinh);
        Console.WriteLine("gia ca: {0} VND", Giaca);
        Console.WriteLine("thoi gian thi cong: {0} ngay", Thoigian);
    }
    
    

    public void DisplayArray(int[] Giaca)
    {
        for (int i = 0; i < Giaca.Length; i++)
        {
            Console.WriteLine("{0}", Giaca[i]);
        }
       
    }
    public void BubbleSortArray(int[] Giaca)
    {
        bool swap;
        int temp;
        do
        {
            swap = false;
            for (int i = 0; i < (Giaca.Length - 1); i++)
            {
                if(Giaca[i] > Giaca[i + 1])
                {
                    temp = Giaca[i];
                    Giaca[i] = Giaca[i + 1];
                    Giaca[i + 1] = temp;
                    swap = true;
                }
            }
        } while (swap == true);
    }
 
}






    
