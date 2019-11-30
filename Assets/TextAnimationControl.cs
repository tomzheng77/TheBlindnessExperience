using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class TextAnimationControl : MonoBehaviour
{
    public GameObject player;
    public GameObject canvasAct01;
    public GameObject canvasAct02;

    // Update is called once per frame
    void Update() {
        GameObject canvas = canvasAct01;
        if (ActIndicator.isAct02) canvas = canvasAct02;
        Animator a = canvas.GetComponent<Animator>();
        if (a.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.85f)
        {
            Debug.Log("restart level with blindness");
            ActIndicator.isAct02 = true;
            SceneManager.LoadScene("SampleScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject canvas = canvasAct01;
        if (ActIndicator.isAct02) canvas = canvasAct02;
        if (other.gameObject == player)
        {
            Animator a = canvas.GetComponent<Animator>();
            a.speed = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject canvas = canvasAct01;
        if (ActIndicator.isAct02) canvas = canvasAct02;
        if (other.gameObject == player)
        {
            Animator a = canvas.GetComponent<Animator>();
            a.speed = 0;
        }
    }

}
