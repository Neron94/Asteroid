
public class PlayerMoveModel : BaseModel
{
    public float ThrustPower { get; set; }
    public bool IsThrustStart { get; set; }
    public float CurThrustPower { get; set; }
    public float DefaultScaleFactor { get; set; }

    public PlayerMoveModel(float thrustPower, bool thrustStart, float scaleFactor)
    {
        ThrustPower = thrustPower;
        IsThrustStart = thrustStart;
        DefaultScaleFactor = scaleFactor;
    }
}
