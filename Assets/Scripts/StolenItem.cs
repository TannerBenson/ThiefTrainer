using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StolenItem : MonoBehaviour
{

    MeshRenderer meshrender;
    bool TimerStarted = false;
    public Text Timer;


    void OnTriggerEnter(Collider other)
    {
        transform.SetParent(other.transform);
        meshrender.enabled = false;
        TimerStarted = true;

    }

    // Use this for initialization
    void Start()
    {
        meshrender = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerStarted == false)
        {
            Timer.text = "";

        }

        if (TimerStarted == true)
        {
            Timer.text = Time.time.ToString();
        }
    }
}
