using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fundido : MonoBehaviour
{

    public Image fundido;
    public int[] escenas;
   
   private void Awake()
   {
       fundido.enabled = true;
   }
    private void Start()
    {
        fundido.CrossFadeAlpha(0, 0.5f, false);
    }


    public void FadeOut(int s)
    {
        fundido.CrossFadeAlpha(1, 0.5f, false);
        StartCoroutine(CambioEscena(escenas[s]));
        
    }

    IEnumerator CambioEscena(int escena)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(escena);
    }
}
