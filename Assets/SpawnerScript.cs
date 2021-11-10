using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerScript : MonoBehaviour
{

    public GameObject objCubeInst;
    public Material[] mat;
    public Transform[] objVectorTransform;

    public float Timer;
    public float RandomTime;

    void Start()
    {
        Timer = 0f;
    }
    void Update()
    {
        Timer += Time.deltaTime; 
        if(Timer > RandomTime)
        {
            int checkRange = Random.Range(0, 3);

            Debug.Log(checkRange);
           GameObject getGameObj = Instantiate(objCubeInst, objVectorTransform[checkRange].transform.position, Quaternion.identity);
            getGameObj.GetComponent<Renderer>().material = mat[checkRange];
            Timer = 0f;
        }
    }


}
