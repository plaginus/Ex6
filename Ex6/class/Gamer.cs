public class Gamer
{
    string name;
    Dice seans;

    public Gamer(string name)
    {
        this.name = name;
        seans = new Dice();
    }

    public int SeanseGame()
    {
        return seans.Random();
    }

    public override string ToString()
    {
        return name;
    }
}