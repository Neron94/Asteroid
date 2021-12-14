using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerControll
{

    public void Thrust();
    public void Rotate(float value);
    public void Shoot();
    public void ShootAlternative();
}
