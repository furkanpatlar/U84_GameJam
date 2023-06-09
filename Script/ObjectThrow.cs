using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectThrow : MonoBehaviour
{
    public float Distance = 5;
    public bool isTaked = false;

    public Image cross;

    public Transform pivot;

    GameObject Item;

    private void Update()
    {

        if (isTaked == true)
        {
            var objComp = Item.GetComponent<T_Object>();
            if (objComp.taken == false)
            {

                isTaked = false;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                objComp.Force();
                isTaked = false;
                objComp.taken = false;



            }

            cross.color = Color.white;



        }

        if (isTaked == false)
        {
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.Raycast(ray, out hit, Distance) && hit.collider.gameObject.tag == "takeAble")
            {
                cross.color = Color.red;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Item = hit.collider.gameObject;
                    Item.GetComponent<T_Object>().hasReseted = false;
                    Item.GetComponent<T_Object>().taken = true;


                    isTaked = true;



                }

            }
            else
            {
                cross.color = Color.white;

            }

        }


    }
}
