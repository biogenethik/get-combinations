internal static class Combinations
{
    internal static IEnumerable<IEnumerable<object>> GetAllCombinations(this IEnumerable<object> elements)
    {
        var response = new List<IEnumerable<object>>();

        for (int combinationSize = 1; combinationSize <= elements.Count(); combinationSize++)
        {
            var combinationAux = new List<object>();

            GetAllCombinations(elements, combinationSize, combinationAux, 0, response);
        }

        return response;
    }

    internal static void GetAllCombinations(IEnumerable<object> elements,
                                           int combinationSize,
                                           List<object> combinationAux,
                                           int index,
                                           List<IEnumerable<object>> combinations)
    {
        if (combinationAux.Count == combinationSize)
        {
            combinations.Add(combinationAux);
            return;
        }

        for (int i = index; i < elements.Count(); i++)
        {
            combinationAux.Add(elements.ElementAt(i));
            GetAllCombinations(elements, combinationSize, combinationAux, i + 1, combinations);
            combinationAux.RemoveAt(combinationAux.Count - 1);
        }
    }
}