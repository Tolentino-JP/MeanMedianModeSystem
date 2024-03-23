using MeanMedianModeBusLogic;

Mean mean = new Mean();


Console.WriteLine($"Prelim Mean: {Math.Round(mean.Prelim(), 2)}");
Console.WriteLine($"Midterm Mean: {Math.Round(mean.Midterm(),2)}");
Console.WriteLine($"Finals Mean: {Math.Round(mean.Finals(),2)}");


