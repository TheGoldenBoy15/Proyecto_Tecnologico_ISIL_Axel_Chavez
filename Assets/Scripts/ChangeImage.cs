using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour {
    public Sprite[] imagenes;
    public AudioClip[] Audios;
    public AudioSource audio;
    public Image Imagen;
    int numImagen;
    int numAudio;
    void Start () {
        numImagen = 0;
        numAudio = 0;
    }

    // Update is called once per frame
    void Update () {

    }
    public void cambioSprite (int x) {
        numImagen += x;
        if (numImagen > 17) {
            numImagen = 0;

        }
        if (numImagen < 0) {
            numImagen = 17;
        }
        Imagen.sprite = imagenes[numImagen];
    }
    public void cambioAudios (int x) {

        numAudio += x;
        if (numAudio > 17) {
            numAudio = 0;

        }
        if (numAudio < 0) {
            numAudio = 17;
        }
        audio.clip = Audios[numAudio];

    }
    public void audioc (AudioSource x) {
        x.clip =audio.clip;
        x.Play();
    }
}