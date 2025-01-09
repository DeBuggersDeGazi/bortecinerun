using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashThud;
    public GameObject levelControl;

    void OnTriggerEnter(Collider other)
    {
        this.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent <PlayerMove>().enabled = false;
        charModel.GetComponent<Animator>().Play("die");
        levelControl.GetComponent<LevelDistance>().enabled = false;
        crashThud.Play();
        Transform sackTransform = thePlayer.transform.Find("Wolf_run/Sack");
        if (sackTransform != null)
        {
            Destroy(sackTransform.gameObject);  
        }
        levelControl.GetComponent<EndRunSequence>().enabled = true;
    }
}
