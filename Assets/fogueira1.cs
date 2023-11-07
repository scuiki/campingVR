using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogueira1 : MonoBehaviour
{
    public GameObject tronco;
    public GameObject pedra;
    public GameObject fogueira;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("tronco")) // Verifique se o objeto de colisão tem a tag "Axe" (o machado).
        {
            tronco.SetActive(false);
            pedra.SetActive(false);
            fogueira.SetActive(true);
        }
    }

}
