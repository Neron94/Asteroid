
public class GameModel : BaseModel
{
    public int Scores { get; set; }
    public int RoundCount { get; set; }
    public int AsteroidToSpawnCount { get; set; }
    public int StartAsteroidCount { get; set; }
    public float CurTimeToUfo { get; set; }
    public float CurTimeToRound { get; set; }
    public float TimeToNextRound;
    public float TimeToSpawnUfo;
    

    public GameModel(int startAsterCount, float timeToUfo, float timeToNextRound)
    {
        StartAsteroidCount = startAsterCount;
        AsteroidToSpawnCount = StartAsteroidCount;
        TimeToSpawnUfo = timeToUfo;
        TimeToNextRound = timeToNextRound;
    }

}
    