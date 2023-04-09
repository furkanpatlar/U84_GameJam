using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Puan : MonoBehaviour
{
    int puan = 0;
    public TMP_Text puanGoster;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "hedef")
        {
            puan++;
            puanGoster.text = "Puanin = " + puan;
        }
        
    }

}
