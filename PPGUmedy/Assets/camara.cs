using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{


    [SerializeField] Transform target ;
    [SerializeField] float transitionSpeed = 2;



    private void LateUpdate()
    {  
         




        if (target != null)
        {
            if (target.position != transform.position)
            {
                transform.position = Vector2.Lerp(transform.position, target.position, transitionSpeed * Time.deltaTime);
                 
                target.position= new Vector3(target.position.x, target.position.y, 1f);
                //问题是相机的z轴定死在0，一直这样就只能手动让其他所有物体往深里来一点，但是太过麻烦
            }
        }




    }
}

