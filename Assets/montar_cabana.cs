using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class montar_cabana : MonoBehaviour
{
    public GameObject martelo;
    public GameObject cabana;
    public GameObject lona;
    public bool inside;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("cabana"))// Verifique se o objeto de colisão tem a tag "Axe" (o machado).
        {
            inside = true;
        }

        if (other.CompareTag("martelo") && inside == true)
        {
            lona.SetActive(false);
            cabana.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("cabana"))
        {
            inside = false;
        }
    }
}
