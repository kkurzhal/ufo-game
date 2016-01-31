using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        // the offset is needed for the Z-axis, since the camera needs to be far out enough to view the game.
        // this is assuming that the X-axis and Y-axis are the same as the game object
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        // the camera will get reset to however far away from the player object that is was when the game started
        transform.position = player.transform.position + offset;

    }
}
