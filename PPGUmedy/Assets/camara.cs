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
                //�����������z�ᶨ����0��һֱ������ֻ���ֶ�����������������������һ�㣬����̫���鷳
            }
        }




    }
}

