static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
    return speed switch
    {
      0 => 0.0,
      int n when n <= 4 && n >= 1 => 1.0,
      int n when n <= 8 && n >= 5 => 0.9,
      9 => 0.8,
      10 => 0.77,
      _ => 0,
    };
  }
    
    public static double ProductionRatePerHour(int speed)
    {
        return speed * 221 * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
