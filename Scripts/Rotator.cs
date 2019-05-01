using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    public float rotx;
    public float roty;
    public float rotz;

	void Update () 
	{

       
            transform.Rotate(new Vector3(rotx, roty, rotz) * Time.deltaTime);
       
	}
}