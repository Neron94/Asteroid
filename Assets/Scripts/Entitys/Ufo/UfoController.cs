using Asteroid2D;

public class UfoController : BaseController<UfoModel>
{
    public bool IsDestroyedOnInteraction(ObjectType objType)
    {
        switch (objType)
        {
            case ObjectType.PlayerShip:
                return true;
            case ObjectType.Asteroid:
                return true;
        }
        return false;
    }
    public void MainWeaponCountDown(float time)
    {
        model.TimeFromLastMainWeaponUse -= time;
        if (model.TimeFromLastMainWeaponUse < 0) model.TimeFromLastMainWeaponUse = 0;
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
}
