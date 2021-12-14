using Asteroid2D;

public class PlayerController : BaseController<PlayerModel>
{
    public void InteractionDesicion(ObjectType objType)
    {
        switch(objType)
        {
            case ObjectType.Asteroid:
                PlayerDestroyed();
                break;
            case ObjectType.UFO:
                PlayerDestroyed();
                break;
        }
    }
    public void PlayerDestroyed()
    {
        model.IsGameOver = true;
    }
    public void MainWeaponCountDown(float time)
    {
        model.TimeFromLastMainWeaponUse -= time;
        if (model.TimeFromLastMainWeaponUse < 0) model.TimeFromLastMainWeaponUse = 0;
    }
    public void AltWeaponCountDown(float time)
    {
        model.TimeFromLastAltWeaponUse -= time;
        if (model.TimeFromLastAltWeaponUse < 0) model.TimeFromLastAltWeaponUse = 0;
    }

    public bool IsMainWeaponCanShot()
    {
        if (model.TimeFromLastMainWeaponUse <= 0)
        {
            model.TimeFromLastMainWeaponUse = model.MainWeaponCountDown;
            return true;        
        }
        else return false;
        
    }
    public bool IsAltWeaponCanShot()
    {
        if (model.TimeFromLastAltWeaponUse <= 0)
        {
            model.TimeFromLastAltWeaponUse = model.AltWeaponCountDown;
            return true;
        }
        else return false;
    }
}
