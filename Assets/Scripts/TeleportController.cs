using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{

    public void SetGazedAt(bool gazedAt) 
    {
        if(gazedAt == true)
        {
            GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        }
        else
        {
            GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        SetGazedAt(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
