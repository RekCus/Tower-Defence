using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Color currentColor;
    float indexR = 0f;
    float indexB = 0f;
    bool ascending = true;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        currentColor = meshRenderer.material.color;
    }

    // Update is called once per frame
    IEnumerator change(float start,float target,bool blue)
    {
        if (start < 1&&ascending)
        {
            
            start += 0.05f;
        }
        else
        {
            ascending = false;
        }
        if(!ascending&&target<1)
        {
            start -= 0.05f;
            target += 0.05f;
        }


        Color c = meshRenderer.material.color;
        if(!blue)
        c = new Color(start, 0, target);
        else c = new Color(target, 0, start);
        meshRenderer.material.color = c;
        yield return new WaitForEndOfFrame();
        yield return StartCoroutine(change(start,target,blue));
        //}
       
    }
  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(change(indexR,indexB,false));
        }
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(change(indexB, indexR,true));
        }

    }
}
