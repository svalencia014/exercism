using System.ComponentModel;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return [0, 2, 5, 3, 7, 8, 4];
    }

    public int Today()
    {
       return birdsPerDay.Last();
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++; 
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int day in birdsPerDay)
        {
            if (day == 0)
            {
                return true;
            } 
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;

        for (int i = 0; i < numberOfDays; i++)
        {
            sum += birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    {
       int total = 0;
       foreach (int day in birdsPerDay)
        {
            if (day >= 5)
            {
                total++;
            }
        }

        return total;
    }
}
