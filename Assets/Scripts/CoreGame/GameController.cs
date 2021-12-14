
public class GameController : BaseController<GameModel>
{
    public override void Setup(GameModel modelToSetup)
    {
        base.Setup(modelToSetup);
        model.CurTimeToUfo = model.TimeToSpawnUfo;
        model.CurTimeToRound = model.TimeToNextRound;
        model.RoundCount++;
    }
    public void AddScoresToModel(int scores)
    {
        model.Scores += scores;
    }
    public bool IsTimeToUfo(float time)
    {
        if(model.CurTimeToUfo >= 0)
        {
            model.CurTimeToUfo -= time;
            return false;
        }
        else
        {
            model.CurTimeToUfo = model.TimeToSpawnUfo;
            return true;
        }
    }
    public bool IsTimeToNewRound(float time)
    {
        if (model.CurTimeToRound >= 0)
        {
            model.CurTimeToRound -= time;
            return false;
        }
        else
        {
            model.CurTimeToRound = model.TimeToNextRound;
            return true;
        }
    }
    public void InitNewRound()
    {
        model.RoundCount++;
        model.AsteroidToSpawnCount++;
    }
}
