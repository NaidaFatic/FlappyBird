using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour {
    private Rigidbody2D rb;

    AudioSource source;
    public AudioClip point;

    

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-2, 0);
        source = GetComponent<AudioSource>();


    }
	
	// Update is called once per frame
	void Update ()
    {
       if(GameControls.instance.endGame==true)
        {
            rb.velocity = Vector2.zero;
        }
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Cat>()!=null)
        {
            GameControls.instance.Score();
            source.PlayOneShot(point, 1f);
            
        }
    }
}
