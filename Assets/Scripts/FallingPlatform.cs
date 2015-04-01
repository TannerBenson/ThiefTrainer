using UnityEngine;
using System.Collections;

public class FallingPlatform : MonoBehaviour {
    private Rigidbody PlatFormRigibody;

	// Use this for initialization


    void OnCollisionEnter (Collision col)
    {
         StartCoroutine(PlatformDrop());
    }
       
        
    

	void Start () {
        PlatFormRigibody = GetComponent<Rigidbody>();
       

	}
	
	// Update is called once per frame
	void Update () {

	
	}

    IEnumerator PlatformDrop()
    {
        yield return new WaitForSeconds(5);
        PlatFormRigibody.isKinematic = false;
        PlatFormRigibody.useGravity = true;
        Debug.Log("PlatFormDrop");

        
    
    }
}
