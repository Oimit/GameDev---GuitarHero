using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTriggerCode : MonoBehaviour
{
    public KeyCode K;
    public Text txt;
    public static int score;

    private void Start()
    {
        score = 0;
    }
    void Update()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<ColliderVars>() != null)
        {
            if (Input.GetKeyDown(K))
            {
                other.GetComponent<ColliderVars>().IsPassed = true;
                AddScore();
                Debug.Log("Work");
                Destroy(other.gameObject);
            }
        }
        Debug.Log("stay");
    }
    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<ColliderVars>() != null)
        {
            if (other.GetComponent<ColliderVars>().IsPassed == false)
            {
                if(score > 0)
                {
                    score = score - 1;
                    txt.text = "Score :  " + score;
                }
                Debug.Log("DownScore");
            }
        }
    }
    public void AddScore()
    {
        score = score + 1;
        txt.text = "Score :  " + score;
    }


}
