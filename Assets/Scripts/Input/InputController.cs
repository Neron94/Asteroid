
public class InputController : BaseController<InputModel>
{
    public bool IsRotate
    {
        set
        {
            model.IsRotate = value;
        }
    }
    public bool IsThrust
    {
        set
        {
            model.IsThrust = value;
        }
    }
}