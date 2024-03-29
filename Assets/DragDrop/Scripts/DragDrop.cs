﻿/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler {

    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
  Vector2 PosInicial;
    public RectTransform posFinal;
 

    private void Awake () {
        rectTransform = GetComponent<RectTransform> ();
        canvasGroup = GetComponent<CanvasGroup> ();
       
     PosInicial=rectTransform.anchoredPosition;
        
    }

    public void OnBeginDrag (PointerEventData eventData) {
        Debug.Log ("OnBeginDrag");
        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag (PointerEventData eventData) {
        //Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag (PointerEventData eventData) {
        Debug.Log ("OnEndDrag");
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        if(rectTransform.anchoredPosition!=posFinal.anchoredPosition)
        rectTransform.anchoredPosition = PosInicial;
    }

    public void OnPointerDown (PointerEventData eventData) 
    {
      
    }

}