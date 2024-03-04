namespace task2;

public class Bird
{

    List<int> BirdCount  = new List<int>();
    public void AddBird(List<int> bird)
    {
        BirdCount=bird;
    }
    public void Week()
    {
        var week=BirdCount.TakeLast(7);
        foreach (var item in BirdCount)
        {
            System.Console.WriteLine(item);
        }
    }
}
