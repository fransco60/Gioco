using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animazione : MonoBehaviour
{
    [SerializeField] private Animator attore;
    [SerializeField] private string ruggito = "Shout";
    public AudioSource verso;
    
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            attore.Play(ruggito, 0, 0.0f);
            verso.Play();
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }   
}
