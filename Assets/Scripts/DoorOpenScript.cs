using UnityEngine;
using System.Collections;

public class DoorOpenScript : MonoBehaviour {

    Animator animator;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("DoorOpening", true);
        }
    }

	// Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("DoorOpening", false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
