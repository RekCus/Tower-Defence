using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public Transform Target;
    public Transform Target1;   
    public Transform Target2;
    public Transform Target3;
    public Transform Target4;
    public Transform Target5;
    public Transform Target6;
    private float _arrivalThreshold = 0.5f;
    private float speed = 2.5f;


    private void Start()
    {
        Target = Target1;
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, Target.position) <= _arrivalThreshold)
        {

            if (Target == Target1)
            {
                Target = Target2;
                Debug.Log("Target == Target2");
            }
            else if(Target == Target2)
            {
                Target = Target3;
                Debug.Log("Target == Target3");
            }
            else if (Target == Target3)
            {
                Target = Target4;
                Debug.Log("Target == Target3");
            }
            else if (Target == Target4)
            {
                Target = Target5;
                Debug.Log("Target == Target3");
            }
            else if (Target == Target5)
            {
                Target = Target6;
                Debug.Log("Target == Target3");
            }
            else if (Target == Target6)
            { 
                Debug.Log("HIT");
            }
        }
        else
        {
            transform.LookAt(Target);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        
    }

}





