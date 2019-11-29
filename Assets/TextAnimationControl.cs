using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class TextAnimationControl : MonoBehaviour
{
    public GameObject player;
    public GameObject canvas;

    // Update is called once per frame
    void Update() {
        Animator a = canvas.GetComponent<Animator>();
        if (a.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.85f)
        {
            Debug.Log("restart level with blindness");
            StartBlind.startBlind = true;
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            Animator a = canvas.GetComponent<Animator>();
            a.speed = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            Animator a = canvas.GetComponent<Animator>();
            a.speed = 0;
        }
    }

}
