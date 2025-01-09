using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    
    public float speedIncrease = 0.003f;
    public float moveSpeed = 6;
    public float timeElapsed = 0;
    public float leftRightSpeed = 4.7f;
    public static bool canMove = false;
    public bool isJumping = false;
    public bool comingDown = false;
    public GameObject playerObject;

    
  
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        if (canMove == true)
        {
            timeElapsed += Time.deltaTime;
            moveSpeed = moveSpeed + ((timeElapsed/200) * speedIncrease);
            leftRightSpeed = leftRightSpeed + ((timeElapsed / 4500) * speedIncrease);
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                }
            }
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
                if(isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("attack2");
                    StartCoroutine(JumpSequence());
                }
            } 
        }
        if (isJumping == true)
        {
            if(comingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 3, Space.World);
            }

            if(comingDown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -3, Space.World);

            }
        }

    }


    IEnumerator JumpSequence()
    {
        yield return new WaitForSeconds(0.45f);
        comingDown = true;
        yield return new WaitForSeconds(0.45f);
        isJumping = false;
        comingDown = false;
        playerObject.GetComponent<Animator>().Play("run");

    }
}
