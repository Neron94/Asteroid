
public class MoveModel : BaseModel
{
    public float ThrustPower { get; set; }
    public bool IsThrustStart { get; set; }
    public float CurThrustPower { get; set; }
    public float DefaultScaleFactor { get; set; }

    public MoveModel(float thrustPower, bool thrustStart, float scaleFactor)
    {
        ThrustPower = thrustPower;
        IsThrustStart = thrustStart;
        DefaultScaleFactor = scaleFactor;
    }
}
