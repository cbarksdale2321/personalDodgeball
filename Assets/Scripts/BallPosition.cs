using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPosition : MonoBehaviour
{
    public bool holdingBall;
    public float ballforce;
    public Transform ballDest;


    void Update()
    {
        if (Input.GetKey("e"))
        {

            holdingBall = true;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = ballDest.position;
            this.transform.parent = GameObject.Find("BallPosition").transform;


        }
        else if (Input.GetMouseButtonUp(0))
        {
            holdingBall = true;
            GetComponent<Rigidbody>().useGravity = false;
            GetComponent<Rigidbody>().AddForce(Vector3.forward * ballforce);
        }

        else
        {
            holdingBall = false;
            this.transform.parent = null;

            GetComponent<Rigidbody>().useGravity = true;




        }







    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Terrain")
        {
            GetComponent<Rigidbody>().Sleep();

        }

    }












    private void OnMouseUp()
    {



        GetComponent<Rigidbody>().AddForce(Vector3.forward);
    }
}
