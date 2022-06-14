using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public Text txt_monedas;
    public int monedas;

    public GameObject Panel_ganar;
    public GameObject Panel_perder;

    AudioSource fuenteAudio;
    public AudioClip claps;
    public AudioClip coin;

    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (monedas == 10)
        {
            Panel_ganar.SetActive(true);
            Destroy(Panel_perder);
            fuenteAudio.clip = claps;
            fuenteAudio.Play();
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //other.gameObject.name = "Moneda";

        if (other.gameObject.name == "Moneda")
        {
            Destroy(other.gameObject);
            monedas = monedas + 1;
            fuenteAudio.clip = coin;
            fuenteAudio.Play();
        }
        txt_monedas.text = "Score: " + monedas;
    }
}
