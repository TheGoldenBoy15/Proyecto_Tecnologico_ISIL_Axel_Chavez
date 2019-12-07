
using UnityEngine;
using UnityEngine.UI;

public class idioma : MonoBehaviour
{
    private Text tittle;
    private Text textQuechua;
    private Text textAymara;
    private Text textAshaninka;
    private float count;
    private float countTimeButton;

    private void Awake()
    {
        tittle = GameObject.FindGameObjectWithTag("tittle_language").GetComponent<Text>();
        textQuechua = GameObject.FindGameObjectWithTag("button_text_quechua").GetComponent<Text>();
        textAymara = GameObject.FindGameObjectWithTag("button_text_aymara").GetComponent<Text>();
        textAshaninka = GameObject.FindGameObjectWithTag("button_text_ashaninka").GetComponent<Text>();
        count = 0;
        countTimeButton =0;
    }



    public void ShowPanelIdioma()
    {
        GetComponent<RectMove>().moveToZero();
    }


    private void Update()
    {
        count += Time.deltaTime;
        countTimeButton += Time.deltaTime;

        tittle.color = Color.white;
        textQuechua.color = Color.white;
        textAymara.color = Color.white;
        textAshaninka.color = Color.white;

        tittle.text = "Idioma";
        textQuechua.text = "Quechua";
        textAymara.text = "Aymara";
        textAshaninka.text = "Asháninka";

        //Quechua
        if(count > 3)
        {
            tittle.color = Color.yellow;
            tittle.text = "Simi";
        } 

        //Aymara
        if(count > 6)
        {
            
            tittle.color = Color.cyan;
            tittle.text = "Aru";
            
        }

        //Ashaninka
        if(count > 9)
        {
            tittle.color = Color.green;
            tittle.text = "cheraakotaantsi";

        }


        if(count>12)
        {
            count=0;
            return;
        }


            if(countTimeButton > 3)
        {

            textQuechua.color = Color.yellow;
            textQuechua.text = "Qhiswa";

            textAymara.color = Color.cyan;
            textAymara.text = "Aymara";

            textAshaninka.color = Color.green;
            textAshaninka.text = "Asháninka";
 
        } 

           if(countTimeButton>12)
        {
            countTimeButton=0;
            return;
        }


    }

}
