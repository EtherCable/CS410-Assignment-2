using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClockTipController : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform playerTf;
    private Transform clockTf;
    public GameObject tooltip;
    
    void Start()
    {
        // grab transforms, hide the msg at the start
        getTransforms();
        tooltip.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // calculate distance from clock to see if we are in range to read
        float distance = Vector3.Distance(playerTf.position, clockTf.position);
        if (distance < 2.5)
        {
            // if close enought to clock, now check if facing the clock
            // Debug.LogFormat("ClockTip Distance: {0}", distance);

            Vector3 playerFwd = playerTf.forward;
            Vector3 clockFwd = clockTf.forward;
            float dir = (playerFwd.x * clockFwd.x) + (playerFwd.y * clockFwd.y) + (playerFwd.z * clockFwd.z);
            
            //float dir = Vector3.Dot(playerFwd, clockFwd);
            // there's an actual dot product function but i did the math by hand
            // Debug.LogFormat("Dot Product: {0}", dir);

            // Debug.LogFormat("Forward of Lemon: {0}, {1}, {2}", playerFwd.x, playerFwd.y, playerFwd.z);

            if ((dir < 0 && dir > -0.7) && (playerTf.position.z < clockTf.position.z))
            {
                // if in front of and facing clock, show tip
                tooltip.SetActive(true);
            } else {
                tooltip.SetActive(false);
            }
        } else {
            // when no longer close enough, hide tip
            tooltip.SetActive(false);
        }
    }

    void getTransforms() 
    {
        // gets transforms from clock and player to use
        GameObject go = GameObject.Find("JohnLemon");
        playerTf = go.GetComponent<Transform>();
        GameObject go2 = GameObject.Find("ClockTip");
        clockTf = go2.GetComponent<Transform>();
    }
}
