public class Dice
{
    Random r;

    public Dice()
    {
        r = new Random();
    }

    public int Random()
    {
        int res = r.Next(1, 7);
        return res;
    }
}