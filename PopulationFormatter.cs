namespace collection{ 
    class PopulationFormatter
{
    public static string FormatPopulation(int population)
    {
        if(population==0)
        return "unknown";
        int popRounded = RoundPopulation(population);
        return $"{popRounded: ### ### ### ###}".Trim();
        
    }

    private static int RoundPopulation(int population)
    {
        if(population > 1000000)
        {
            population = population/1000000;
            population = population*1000000;

        }
        return population;
    }
}
}