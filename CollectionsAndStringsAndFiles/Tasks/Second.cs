namespace CollectionsAndStringsAndFiles.Tasks;

public class Second
{
   private readonly int[] _knightsProfits;

   public Second(int amountOfKnights)
   {
      _knightsProfits = new int[amountOfKnights];
   }

   public int[] Solve((int, int, int)[] requests)
   {
      foreach (var request in requests)
      {
         for (int i = request.Item1 - 1; i < request.Item2; i++)
            _knightsProfits[i] += request.Item3;
      }

      return _knightsProfits;
   }
}