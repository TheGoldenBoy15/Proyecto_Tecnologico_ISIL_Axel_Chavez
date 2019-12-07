using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class RectMove : MonoBehaviour
{
    private const int WIDTH = 1440;
    private const int HEIGHT = 1900;

    private float current;
    private float velocity;
    private RectTransform Rt;
    private Vector2 Resolution;

    public enum POSITION
    {
        LEFT = -1,
        MIDDLE = 0,
        RIGHT = 1
    }


    [SerializeField]
    private POSITION InitPos = POSITION.MIDDLE;

    private void Awake()
    {
        Rt = GetComponent<RectTransform>();
        Resolution = GetComponentInParent<CanvasScaler>().referenceResolution;

    }

    private void Start()
    {
        velocity = Resolution.x / 2;
        Rt.anchoredPosition = Vector3.right * (int)InitPos * Resolution.x;
    }


    public delegate void Callback();

    public void moveToZero()
    {
        moveToZero(null);
    }


    public void moveToZero(Callback callback)
    {
        StopAllCoroutines();
        StartCoroutine(Move(Vector2.zero, callback));
    }

    public void moveToRight()
    {
        moveToRight(null);
    }

    public void moveToRight(Callback callback)
    {
        StopAllCoroutines();
        StartCoroutine(Move(Vector2.right * Resolution.x, callback));
    }


    IEnumerator Move(Vector2 target, Callback callback)
    {
        current = 0;
        Vector2 origin = Rt.anchoredPosition;
        float duration = Vector2.Distance(origin, target) / velocity;

        while (current <= duration)
        {
            yield return null;
            current += Time.deltaTime;
            float percent = current / duration;
            Rt.anchoredPosition = Vector2.LerpUnclamped(origin, target, percent);
        }

        if (callback != null)
        {
            callback();
        }
    }

}
