using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseView <M, C>: MonoBehaviour 
       where M : BaseModel 
       where C : BaseController <M>, new()
{
    protected M model;
    protected C controller;
    public BaseMVC.ModuleType ModuleTypeIs;
    
    protected virtual void Awake()
    {
        controller = new C ();
        controller.Setup(model);
    }
}
