using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleTargetTower : Tower
{

    private GameObject _target;

    override protected void Update()
    {
        base.Update();
        if (collidersInRange.Length > 0)
        {
            print(collidersInRange[0].gameObject);
            //transform.LookAt();
        }
    }

}
