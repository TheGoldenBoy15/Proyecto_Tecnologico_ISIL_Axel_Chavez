
using UnityEngine;
using UnityEngine.UI;

public class math_grade1_nivel : MonoBehaviour
{
  
    private GameObject _quiz;
    private Text _text_quiz;
    private int _text_quiz_case;
    private int _random_number1;
    private int _random_number2;
    private int _count_points;


    void Start()
    {
        _quiz = GameObject.FindGameObjectWithTag("text_quiz");
        _text_quiz = _quiz.GetComponent<Text>();

        _random_number1 = Random.Range(1,5);
        _random_number2 = Random.Range(0,4);


        _text_quiz_case = Random.Range(1,3);
        print(_text_quiz_case);
        
        _text_quiz.text = "Seleccionar la suma correcta:" + "\n" + "2 + 4";
    }

    
    void Update()
    {
        /*
        switch (_text_quiz_case)
        {
            case 1:
             _text_quiz.text = "Seleccionar el número:" + "\n" + _random_number1.ToString();
            break;

            case 2:
             _text_quiz.text = "Seleccionar la suma correcta:" + "\n" + _random_number1.ToString() + " + " + _random_number2.ToString();
            break;

            case 3:
             _text_quiz.text = "Seleccionar la resta correcta:" + "\n" + _random_number1.ToString() + " + " + _random_number2.ToString();
            break;
        }
        */
    }




}
