using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFChild : MonoBehaviour
{
    public Opdrachten.PathFollower pathf;

    void Update()
    {
        if(pathf.index == 6)
        {
            Destroy(gameObject);
        }
    }
}
