using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>().speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
