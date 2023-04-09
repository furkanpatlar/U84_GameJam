using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = -90f; // Kap�n�n a��labilece�i maksimum a�� (derece cinsinden)
    public float closeAngle = 0f; // Kap�n�n kapal� konumda olaca�� a�� (derece cinsinden)
    public float smooth = 2f; // Kap� a��l�rken ve kapan�rkenki hareketin yumu�akl���

    private Quaternion openRotation; // Kap�n�n a��k pozisyonu
    private Quaternion closeRotation; // Kap�n�n kapal� pozisyonu
    private bool isOpen = true; // Kap� a��k m� kapal� m�?

    void Start()
    {
        // Kap�n�n a��k ve kapal� pozisyonlar�n�n hesaplanmas�
        openRotation = Quaternion.Euler(0f, openAngle, 0f) * transform.localRotation;
        closeRotation = Quaternion.Euler(0f, closeAngle, 0f) * transform.localRotation;
    }

    void Update()
    {
        // Kap�n�n a��l�p kapanmas�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOpen = !isOpen; // Kap�n�n durumunu de�i�tir
        }

        if (isOpen)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, openRotation, Time.deltaTime * smooth);
        }
        else
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, closeRotation, Time.deltaTime * smooth);
        }
    }
}