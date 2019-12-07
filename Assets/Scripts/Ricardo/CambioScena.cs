using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CambioScena : MonoBehaviour {
  // Start is called before the first frame update
  public InputField Usuario;
  public InputField Contraseña;
  void Start () {

  }

  // Update is called once per frame
  void Update () {

  }
  public void changeScene (int x) {
    SceneManager.LoadScene (x);
  }
  public void Aparecer (GameObject objeto) {
    if (objeto.activeInHierarchy == true){
      objeto.SetActive (false);
    }
    else{
    
      objeto.SetActive (true);
    }
  }
  public void InicioAdmi () {
    if (Usuario.text == "Admin" && Contraseña.text == "1234") {
      SceneManager.LoadScene (2);
    }
  }
}