﻿namespace Observer;

public class Chart : IObserver
{
    public void Update()
    {
        Console.WriteLine("Chart got notified.");
    }
}
