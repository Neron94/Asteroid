
public class PlayerMoveController : BaseController<PlayerMoveModel>
{
    public override void Setup(PlayerMoveModel modelToSetup)
    {
        base.Setup(modelToSetup);
        model.CurThrustPower = 0;
    }

    public void InitMove()
    {
        // Готовим основные переменные перемещения к старту перемещения
        model.CurThrustPower = model.ThrustPower;
        model.IsThrustStart = true;
    }


    //Движение во Вью происходит всегда. 
    //Эффект скольжения обеспечивается постепенным уменьшением скрости
    public void SlowThrust(float timeDeltaTime)
    {
        if (model.IsThrustStart)
        {
            model.CurThrustPower -= timeDeltaTime * model.DefaultScaleFactor;
        }

        if (model.CurThrustPower <= 0)
        {
            model.IsThrustStart = false;
            model.CurThrustPower = 0;
        }
    }
}
