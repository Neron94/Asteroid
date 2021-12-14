using Asteroid2D;

public class BulletController : BaseController<BulletModel>
{
    public override void Setup(BulletModel modelToSetup)
    {
        base.Setup(modelToSetup);
    }
    public void Init(float lifeTime)
    {
        model.Lifetime = lifeTime;
        model.LastTime = 0;
    }
    public bool IsLifeTimeOff(float time)
    {
        if (model.LastTime >= model.Lifetime)
        {
            model.LastTime = 0;
            return true;
        }
        else 
        {
            model.LastTime += time;
            return false;
        }
    }
    public bool IsDestroyedOnInteraction(ObjectType objType)
    {
        switch (objType)
        {
            case ObjectType.Asteroid:
                return true;
            case ObjectType.UFO:
                return true;
            case ObjectType.PlayerShip:
                return true;
        }
        return false;
    }
}
