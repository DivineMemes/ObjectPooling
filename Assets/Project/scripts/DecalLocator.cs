using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecalLocator : MonoBehaviour
{
    public static DecalLocator instance;
    public ObjectPool pool;


    void Start ()
    {
		if(instance = null)
        {
            instance = this;
        }
        else
        {
            pool = GetComponent<ObjectPool>();
        }
	}
	


	void Update ()
    {
		
	}
}
