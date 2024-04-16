using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverLight : MonoBehaviour
{
	public Transform player;
	public Color coldColor = Color.white;
	public Color hotColor = Color.red;
	public float distanceThreshold = 2.0f;

	private Light lt;
	private Transform t;

	void Start()
	{
		lt = GetComponent<Light>();
		t = GetComponent<Transform>();
	}

    // Update is called once per frame
    void Update()
    {
		float dist = Vector3.Distance(t.position, player.position);
		float intensity = (distanceThreshold - dist) / distanceThreshold;
		if (intensity < 0.0f)
		{
			intensity = 0.0f;
		}
        lt.color = Color.Lerp(coldColor, hotColor, intensity);
    }
}
