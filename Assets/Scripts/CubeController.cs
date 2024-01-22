using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] public Vector3 destiny;
    [SerializeField] public AnimationCurve transition;

    private float _discance;
    

    // Start is called before the first frame update
    void Start()
    {
        _discance = Vector3.Distance(transform.position, destiny);
    }

    // Update is called once per frame
    void Update()
    {
        float normalized = Vector3.Distance(transform.position, destiny) / _discance;
        Debug.Log(normalized);
        transform.position = Vector3.MoveTowards(transform.position, destiny, Time.deltaTime * 1);
        transform.localScale = Vector3.one + Vector3.one * 3.0f * transition.Evaluate(normalized);
    }
}
