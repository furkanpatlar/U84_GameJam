using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public float openAngle = -90f; // Kapýnýn açýlabileceði maksimum açý (derece cinsinden)
    public float closeAngle = 0f; // Kapýnýn kapalý konumda olacaðý açý (derece cinsinden)
    public float smooth = 2f; // Kapý açýlýrken ve kapanýrkenki hareketin yumuþaklýðý

    private Quaternion openRotation; // Kapýnýn açýk pozisyonu
    private Quaternion closeRotation; // Kapýnýn kapalý pozisyonu
    private bool isOpen = true; // Kapý açýk mý kapalý mý?

    void Start()
    {
        // Kapýnýn açýk ve kapalý pozisyonlarýnýn hesaplanmasý
        openRotation = Quaternion.Euler(0f, openAngle, 0f) * transform.localRotation;
        closeRotation = Quaternion.Euler(0f, closeAngle, 0f) * transform.localRotation;
    }

    void Update()
    {
        // Kapýnýn açýlýp kapanmasý
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOpen = !isOpen; // Kapýnýn durumunu deðiþtir
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