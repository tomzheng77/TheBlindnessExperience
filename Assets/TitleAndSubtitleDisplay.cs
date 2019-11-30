using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class TitleAndSubtitleDisplay : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject title;
    public GameObject titleImage;
    public GameObject subtitle;
    public GameObject subtitleImage;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 0;
        animator.playbackTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.99)
        {
            animator.speed = 0;
        }
    }

    void ShowMessage(string[] strs)
    {
        title.GetComponent<Text>().text = strs[0];
        subtitle.GetComponent<Text>().text = strs[1];
        animator.speed = 1;
        animator.playbackTime = 0;
    }

}
