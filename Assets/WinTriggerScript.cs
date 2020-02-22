using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTriggerScript : MonoBehaviour
{
    public GameObject ball;
    public GameObject platform;
    public GameObject win_trigger;

    private Transform win_triggertransform;
    private float minx;
    private float maxx;
    private float minz;
    private float maxz;

    private void createBall()
    {
        ball.transform.position = new Vector3(0.0f, 1.0f, 23.1f);
        Instantiate(ball);
    }

    // Start is called before the first frame update
    void Start()
    {
        createBall();
        win_trigger.GetComponent<Renderer>().material.color = new Color(100, 0, 0);
        win_trigger.transform.SetParent(platform.transform);
        win_trigger.transform.localPosition = Vector3.zero;
        maxx = (platform.transform.localScale.x / 2.0f - win_trigger.transform.lossyScale.x / 2.0f)*0.1f;
        minx = (-platform.transform.localScale.x / 2.0f + win_trigger.transform.lossyScale.x / 2.0f)*0.1f;
        maxz = (platform.transform.localScale.z/ 2.0f - win_trigger.transform.lossyScale.z / 2.0f)*0.1f;
        minz = (-platform.transform.localScale.z / 2.0f + win_trigger.transform.lossyScale.z / 2.0f)*0.1f;
    }
   
    //Doesn't work if it is trigger
    private void OnCollisionEnter(Collision collision)
    { 
        Destroy(collision.gameObject);
        win_trigger.transform.localPosition = new Vector3(Random.Range(minx, maxx), 0, Random.Range(minz, maxz));
        createBall();
    }
}
