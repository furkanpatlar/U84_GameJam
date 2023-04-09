using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    //[SerializeField] private int SceneIndex; //manuel unity �zerinden y�nlendirme yap�larak giri� i�in.(Alternatif Y�ntem.)
    private Scene _scene; //scene tan�mlad�m.

    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();//aktif sahneyi cacheliyoruz.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);//mevcut sahneden bir sonraki sahneye ge�i�. 
            //SceneManager.LoadScene(SceneIndex); //edit�r �zerinde mevcut sahneden hangi sahneye ge�ece�ini yaz�yoruz.(Alternatif Y�ntem.)
        }
    }

    public void StartLevel() //ba�lang��taki buton i�in yaz�lm�� blok. ED�T�RDE G�Z�KMES� ���N PUBL�C VERD�K. BUTONA FONKS�YON BA�LIYORUZ.
    {
        SceneManager.LoadScene(_scene.buildIndex + 1);
    }
}
