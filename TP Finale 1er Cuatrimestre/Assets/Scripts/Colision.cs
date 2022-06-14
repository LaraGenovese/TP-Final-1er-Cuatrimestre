using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colision : MonoBehaviour
{
    public GameObject Panel_perder;
    public PlaneBehaviour planeScript;

    AudioSource fuenteAudio;
    public AudioClip gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Obstaculo")
        {
            Panel_perder.SetActive(true);
            planeScript.movementSpeed = 0;
            fuenteAudio.clip = gameOver;
            fuenteAudio.Play();
            Destroy(gameObject);
        }
    }
}
