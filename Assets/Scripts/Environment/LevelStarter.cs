using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGO;

    public GameObject fadeIn;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(countSequence());
        
    }

    IEnumerator countSequence()
    {
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown2.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown1.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDownGO.SetActive(true);

        PlayerMove.canMove = true;

    }

 
}
