using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinPosition : MonoBehaviour
{
    private float time;
    private Vector3 originalPos;
    public float Speed = 1;
    public float Amplitude = 0.5f;
    public bool HorizontalTraveling, VerticalTraveling;

    void Start()
    {
        originalPos = transform.position;   
    }

    void Update()
    {
        time += Time.deltaTime * Speed;
        var sin = Mathf.Sin(time) * Amplitude;
        transform.position = originalPos - new Vector3(HorizontalTraveling?sin:0 , VerticalTraveling?sin:0);
    }
}
