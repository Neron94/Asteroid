
public class AsteroidModel : BaseModel
{
    public int Scores { get; set; }
    public float InvincibleTime;
    public AsteroidModel (int scores, float invinTime)
    {
        Scores = scores;
        InvincibleTime = invinTime;
    }
}
