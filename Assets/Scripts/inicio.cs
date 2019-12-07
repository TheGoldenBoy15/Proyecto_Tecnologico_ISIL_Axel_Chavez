
using UnityEngine;
using UnityEngine.UI;

public class inicio : MonoBehaviour
{
    
    private Text tittle;
    private Text entrar;
    private float contador;

    private void Awake()
    {
        tittle = GameObject.FindGameObjectWithTag("tittle").GetComponent<Text>();
        entrar = GameObject.FindGameObjectWithTag("entrar").GetComponent<Text>();
        contador =0;

    }

    private void Update()
    {
        contador += Time.deltaTime;
        tittle.color = Color.white;
        entrar.color = Color.white;
        tittle.text = "Profesor Inti";
        entrar.text = "Entrar";

        //Quechua
        if(contador > 3)
        {
            tittle.color = Color.yellow;
            entrar.color = Color.yellow;
            tittle.text = "Yachacchip Inti";
            entrar.text = "Yaykuy";
           
        } 

        //Aymara
        if(contador > 6)
        {
            
            tittle.color = Color.cyan;
            entrar.color = Color.cyan;
            tittle.text = "Yachachix Willka";
            entrar.text = "Mantaña";
            
        }

        //Ashaninka
        if(contador > 9)
        {
            tittle.color = Color.green;
            entrar.color = Color.green;
            tittle.text = "Obametantatsiri Oriatsiri";
            entrar.text = "Intsomoe";
        }


        if(contador>12)
        {
            contador=0;
            return;
        }
    }



}
