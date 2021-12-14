using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseController <M>
       where M : BaseModel
{
    protected M model;
    
    public virtual void Setup(M modelToSetup)
    {
        model = modelToSetup; 
    }
}