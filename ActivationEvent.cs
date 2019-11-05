using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationEvent : MonoBehaviour
{
    Animation anim;

    private void Start()
    {
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        if (!anim.isPlaying && Input.GetKey(KeyCode.P))
        {
            anim.Play("movement");
        }
    }
}
