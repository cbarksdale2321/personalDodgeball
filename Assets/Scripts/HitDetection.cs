using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetection : MonoBehaviour
{
    public GameObject testDummy;
    private void OnCollisionEnter(Collision hit)
    {

        if(hit.collider.tag == "Object")
        {
            Destroy(testDummy);

        }

    }


}
