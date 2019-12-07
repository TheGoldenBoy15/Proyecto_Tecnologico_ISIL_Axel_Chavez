using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BotonCorrecto : MonoBehaviour {
    public GameObject panelGanaste;

    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {

    }

    public void PanelOn(GameObject panel)
    {
        panel.SetActive(true);
    }
}