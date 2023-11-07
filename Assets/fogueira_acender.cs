using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fogueira_acender : MonoBehaviour
{
    public GameObject fosforo;
    public GameObject fogueira;
    public GameObject Particle_fire;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("fosforo")) // Verifique se o objeto de colisão tem a tag "Axe" (o machado).
        {
            fosforo.SetActive(false);
            fogueira.SetActive(true);
            Particle_fire.SetActive(true);
        }
    }
}
