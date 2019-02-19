using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    private bool isTargeted;
    public float playerHeight = 1.8f;

    public void Teleport()
    {
        if (isTargeted)
        {
            // Player is looking at this target
            // when they clicked their headset.
            GameObject player = GameObject.FindWithTag("Player");
            if (player != null)
            {
                // move the player to the location of the target
                Vector3 newPosition = new Vector3(transform.position.x,
               transform.position.y + playerHeight,
                transform.position.z);
                player.transform.position = newPosition;
            }
        }
    }

    public void SetGazedAt(bool gazedAt) 
    {
        if(gazedAt == true)
        {
            GetComponent<Renderer>().material.EnableKeyword("_EMISSION");

            isTargeted = gazedAt;
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
