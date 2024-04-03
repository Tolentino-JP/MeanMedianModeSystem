using MeanMedianModeBusLogic;

Mean mean = new Mean();
Median median = new Median();
RangeGrade range = new RangeGrade();
Variance variance = new Variance();
StandardDeviation deviation = new StandardDeviation();
Mode mode = new Mode();
FinalAverage average = new FinalAverage();



Console.WriteLine($"Prelim Mean: {Math.Round(mean.Prelim(), 2)}");
Console.WriteLine($"Midterm Mean: {Math.Round(mean.Midterm(),2)}");
Console.WriteLine($"Finals Mean: {Math.Round(mean.Finals(),2)}\n");

Console.WriteLine($"Prelim Median: {Math.Round(median.Prelim(), 2)}");
Console.WriteLine($"Midterm Median: {Math.Round(median.Midterm(), 2)}");
Console.WriteLine($"Finals Median: {Math.Round(median.Finals(), 2)}\n");

Console.WriteLine($"Prelim Mode: {mode.Prelim()}");
Console.WriteLine($"Midterm Mode: {mode.Midterm()}");
Console.WriteLine($"Finals Mode: {mode.Finals()}\n");

Console.WriteLine($"Prelim Range: {Math.Round(range.Prelim(), 2)}");
Console.WriteLine($"Midterm Range: {Math.Round(range.Midterm(), 2)}");
Console.WriteLine($"Finals Range: {Math.Round(range.Finals(), 2)}\n");

Console.WriteLine($"Prelim Variance: {Math.Round(variance.Prelim(),2)}");
Console.WriteLine($"Midterm Variance: {Math.Round(variance.Midterm(),2)}");
Console.WriteLine($"Finals Variance: {Math.Round(variance.Finals(),2)}\n");

Console.WriteLine($"Prelim Standard Deviation: {Math.Round(deviation.Prelim(),2)}");
Console.WriteLine($"Midterm Standard Deviation: {Math.Round(deviation.Midterm(),2)}");
Console.WriteLine($"Finals Standard Deviation: {Math.Round(deviation.Finals(),2)}\n");

average.Average();

