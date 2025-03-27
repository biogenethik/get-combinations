List<object> elements = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20];

DateTime start = DateTime.Now;
IEnumerable<IEnumerable<object>> combinations = elements.GetAllCombinations();
DateTime end = DateTime.Now;

Console.WriteLine($"[{combinations.Count()}] combinations found on [{(end - start).TotalMilliseconds}] milliseconds!");