using UnityEngine;
using System.Collections;

public class Footsteps1 : MonoBehaviour
{

    [SerializeField] GameObject player;
    AudioSource audiosource;
    bool isWalking; //true if im walking
    float FootstepDelayTime;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine(PlayFootsteps()); //Starts the coroutine below (basically a function)
    }

    IEnumerator PlayFootsteps()
    {
    Start: //loop

        if (isWalking == true) //check if im walking
        {
            audiosource.Play(); //play footstep sound (sound shouldnt really be longer than a second, just one footstep is enough)
            yield return new WaitForSeconds(FootstepDelayTime); //delay for a period of time
        }

        goto Start; //loop back to checking if im still walking
    }
}

