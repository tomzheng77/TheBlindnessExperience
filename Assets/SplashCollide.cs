﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SplashCollide : MonoBehaviour
{

    public AudioClip m_CollideSound;
    private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.pitch = Random.Range(0.8f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FPSController")
        {
            m_AudioSource.clip = m_CollideSound;
            m_AudioSource.Play();
            //collision.gameObject.SendMessage("SaySorry");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController")
        {
            m_AudioSource.clip = m_CollideSound;
            m_AudioSource.Play();
            //other.gameObject.SendMessage("SaySorry");
        }
    }

}
