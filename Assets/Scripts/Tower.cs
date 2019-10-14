using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField]
    private float _radius = 1;

    [SerializeField]
    private LayerMask _layer;

    protected Collider[] collidersInRange;

    virtual protected void Update()
    {
        collidersInRange = Physics.OverlapSphere(transform.position, _radius, _layer);
        //print(collidersInRange)

      //  for (int i = 0; i < colliders.Length; i++)
       // {
         //   print(colliders[i].gameObject.name);
       // }

      // print(colliders.Length);
    }

    //Shows The radius of the sphere
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _radius);
    }

}
