
public class MoveController : BaseController<MoveModel>
{
    public override void Setup(MoveModel modelToSetup)
    {
        base.Setup(modelToSetup);
        model.CurThrustPower = 0;
    }
    
    public void InitMove() 
    {
        // ������� �������� ���������� ����������� � ������ �����������
        model.CurThrustPower = model.ThrustPower;
        model.IsThrustStart = true;
    }
}
