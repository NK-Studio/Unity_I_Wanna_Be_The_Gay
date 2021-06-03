using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obj_plaform : MonoBehaviour {

    public BoxCollider2D playercollider;

    [SerializeField]
    private BoxCollider2D plaformCollider;
    [SerializeField]
    private BoxCollider2D plafromTrigger;
	// Use this for initialization
	void Start () {
        Physics2D.IgnoreCollision(plaformCollider, plafromTrigger, true);
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "player")
        {
            Physics2D.IgnoreCollision(plaformCollider, playercollider, true);
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            Physics2D.IgnoreCollision(plaformCollider, playercollider, false);
        }
    }
}
