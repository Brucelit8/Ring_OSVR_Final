using UnityEngine;
using System.Collections;

public class FootSteps : MonoBehaviour {

    public Transform T;

    private Vector3 pos;
    private bool foot;
    float timeCurrent;
    public AudioSource fs1;
    public  AudioSource fs2;

	// Use this for initialization
	void Start ()
    {
        pos = T.position;
        foot = false;
        timeCurrent = Time.fixedTime;
    }

    // Update is called once per frame
    void Update ()
    {
        if(Time.fixedTime - timeCurrent > 0.4f)
        {
            if (pos != T.position)
            {
                if(foot)
                {
                    Debug.Log("fs1");
                    fs1.Play();
                }
                else
                {
                    Debug.Log("fs2");
                    fs2.Play();
                }
                foot = !foot;
            }
            timeCurrent = Time.fixedTime;
            pos = T.position;
        }
	}
}
