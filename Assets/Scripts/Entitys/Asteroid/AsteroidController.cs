using Asteroid2D;

public class AsteroidController : BaseController<AsteroidModel>
{
    public bool IsDestroyedOnInteraction(ObjectType objType)
    {
        switch (objType)
        {
            case ObjectType.PlayerShip:
                return true;
            case ObjectType.UFO:
                return true;
        }
        return false;
    }
}
