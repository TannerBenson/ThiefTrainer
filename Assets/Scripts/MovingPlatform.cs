using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

    public int speed = 2;
    public int StartXPosition, StartYPosition, StartZPosition;
    public int EndXPosition, EndYPosition, EndZPosition;
    public Vector3 startingPosition;
    bool movingleft = true;


    void OnTriggerEnter(Collider other)
    {
        other.transform.SetParent(transform); 
    }

    void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null); 
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        int currentXPosition = (int)(transform.position.x);
        int currentYPosition = (int)(transform.position.y);
        int currentZPosition = (int)(transform.position.z);



        


        if (movingleft)
        {
            transform.localPosition += new Vector3(0f, 0f, speed) * Time.deltaTime;
            if (transform.localPosition.z >= 12.5)
            {
                movingleft = false;
            }
        }
        else if (!movingleft)
        {
          transform.localPosition -= new Vector3(0f, 0f, speed) * Time.deltaTime;

           if (transform.localPosition.z <= -12.5)
           {
                movingleft = true;
            }
        }
    
        Debug.Log(transform.localPosition.z);
        Debug.Log(movingleft);
	
	}
}
