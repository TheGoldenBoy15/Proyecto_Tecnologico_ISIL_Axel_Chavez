using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ContadorScena : MonoBehaviour
{
    float contador;
    float contador1;
    float contador2;
    float contador3;
    float contador4;
    float contador5;
    float contador6;
    float contador7;
    float contador8;
    float contador9;
    float contador10;
    float contador11;

    public Text[] ContadorEscenasMenu;

   
    void Start()
    {
        contador = 0;
        contador1 = 0;
        contador2 = 0;
        contador3 = 0;
        contador4 =0;
        contador5 =0;
        contador6 =0;
        contador7 = 0;
        contador8 = 0;
        contador9 = 0;
        contador10 = 0;
        contador11 = 0;

    }

   
    void FixedUpdate()

    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {
            contador += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador", contador);
            
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {
            contador1 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador1", contador1);
            
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
        {
            contador2 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador2", contador2);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {
            contador3 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador3", contador3);
        }
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4))
        {
            contador4 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador4", contador4);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(5))
        {
            contador5 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador5", contador5);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(6))
        {
            contador6 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador6", contador6);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(7))
        {
            contador7 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador7", contador7);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(8))
        {
            contador8 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador8", contador6);
        }


        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(9))
        {
            contador9 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador9", contador9);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(10))
        {
            contador10 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador10", contador10);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(11))
        {
            contador11 += Time.deltaTime;
            PlayerPrefs.SetFloat("Contador11", contador11);
        }



        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(13))
        {
            ContadorEscenasMenu[0].text = "Escena 0 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador", contador), 1);
            ContadorEscenasMenu[1].text = "Escena 1 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador1", contador1), 1);
            ContadorEscenasMenu[2].text = "Escena 2 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador2", contador2), 1);
            ContadorEscenasMenu[3].text = "Escena 3 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador3", contador3), 1);
            ContadorEscenasMenu[4].text = "Escena 4 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador4", contador4), 1);
            ContadorEscenasMenu[5].text = "Escena 5 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador5", contador5), 1);
            ContadorEscenasMenu[6].text = "Escena 6 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador6", contador6), 1);
            ContadorEscenasMenu[7].text = "Escena 7 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador7", contador7), 1);
            ContadorEscenasMenu[8].text = "Escena 8 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador8", contador8), 1);
            ContadorEscenasMenu[9].text = "Escena 9 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador9", contador9), 1);
            ContadorEscenasMenu[10].text = "Escena 10 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador10", contador10), 1);
            ContadorEscenasMenu[11].text = "Escena 11 : " + System.Math.Round(PlayerPrefs.GetFloat("Contador11", contador11), 1);
        }

        






    }
  

}