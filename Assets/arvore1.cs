using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCollisionScript : MonoBehaviour
{
    public GameObject tronco; // Arraste o Prefab do tronco aqui na Unity.
    public GameObject arvore;
    public GameObject machado;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("oiiiiiiiiiii");

        if (collision.gameObject.CompareTag("machado")) // Verifique se o objeto de colisão tem a tag "Axe" (o machado).
        {
            arvore.SetActive(false);
            tronco.SetActive(true);
        }
    }

}