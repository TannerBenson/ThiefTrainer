using UnityEngine;
using System.Collections;

public class GetToFinishPlatform : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("You Win");

    }

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
