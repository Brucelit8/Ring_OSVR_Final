using UnityEngine;
using System.Collections;

public class moveBoat : MonoBehaviour {

    float time = 0.0f;
    float timer = 30.0f;
    float speed = 0.01f;
    public GameObject p1, p2;
	// Use this for initialization
	void Start ()
    {
	}

    // Update is called once per frame
    void Update()
    {
        if(time <= timer)
        {
            Vector3 t = new Vector3(Mathf.Lerp(p1.transform.position.x, p2.transform.position.x, time/ timer),
                Mathf.Lerp(p1.transform.position.y, p2.transform.position.y, time/ timer),
                Mathf.Lerp(p1.transform.position.z, p2.transform.position.z, time/ timer));
            transform.position = t;
            time += 0.01f;
        }
        else
        {
            time = 0.0f;
            transform.position = p1.transform.position;
        }

    }
}