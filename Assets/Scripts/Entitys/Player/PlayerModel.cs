
public class PlayerModel : BaseModel
{
    public float MainWeaponCountDown;
    public float TimeFromLastMainWeaponUse  { get; set; }
    public bool IsGameOver { get; set; }

    public float AltWeaponCountDown;
    public float TimeFromLastAltWeaponUse { get; set; }

    public PlayerModel(float mainCountDown, float altWeaponCountDown)
    {
        MainWeaponCountDown = mainCountDown;
        AltWeaponCountDown = altWeaponCountDown;
    }
}

