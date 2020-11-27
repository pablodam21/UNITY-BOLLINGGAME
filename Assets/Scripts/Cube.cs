using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public const float yDie = -30.0f;
	
	private static int bollsDestroyed = 0;
	
	private GameObject[] bolls;

	// Start is called before the first frame update
    void Start()
    {
     	bolls = GameObject.FindGameObjectsWithTag("boll"); 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie){
			bollsDestroyed++;
			Destroy(gameObject);
			if(bollsDestroyed == bolls.Length){
				Application.LoadLevel("FinalWin");	
			}
		}
    }
}
