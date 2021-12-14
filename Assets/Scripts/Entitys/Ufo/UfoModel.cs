
public class UfoModel : BaseModel
{
    public int Score;
    public float MainWeaponCountDown;
    public float TimeFromLastMainWeaponUse { get; set; }

    public UfoModel(float mainWeaponCountDown, int score)
    {
        MainWeaponCountDown = mainWeaponCountDown;
        Score = score;
    }
}
