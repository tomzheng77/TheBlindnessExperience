using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleAndSubtitleDisplay : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject title;
    public GameObject titleImage;
    public GameObject subtitle;
    public GameObject subtitleImage;
    private int ticks = 0;

    void Start()
    {
        title.SetActive(false);
        subtitle.SetActive(false);
        titleImage.SetActive(false);
        subtitleImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ticks -= 1;
        if (ticks < 0) ticks = 0;
        if (ticks <= 0)
        {
            title.SetActive(false);
            titleImage.SetActive(false);
            subtitle.SetActive(false);
            subtitleImage.SetActive(false);
        }
        else
        {
            float alpha = ticks / 60f;
            if (alpha > 1f) alpha = 1f;
            if (title.activeSelf) title.GetComponent<Text>().color = new Color(0, 0, 0, alpha);
            if (subtitle.activeSelf) subtitle.GetComponent<Text>().color = new Color(0, 0, 0, alpha);
            if (titleImage.activeSelf) titleImage.GetComponent<Image>().color = new Color(.5f, .5f, .5f, alpha/2);
            if (subtitleImage.activeSelf) subtitleImage.GetComponent<Image>().color = new Color(.5f, .5f, .5f, alpha/2);
        }
    }

    void ShowMessage(string[] strs)
    {
        ticks = 480;
        title.SetActive(true);
        subtitle.SetActive(true);
        titleImage.SetActive(true);
        subtitleImage.SetActive(true);
        title.GetComponent<Text>().text = strs[0];
        subtitle.GetComponent<Text>().text = strs[1];
    }

}
