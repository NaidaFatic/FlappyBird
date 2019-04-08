using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cat : MonoBehaviour {

    private Rigidbody2D rb;
    private bool isDead = false;

    public GameObject taill;

    AudioSource source;
    public AudioClip live;
   


    // Use this for initialization
    void Start ()
    {
      rb = GetComponent<Rigidbody2D>();
        source = GetComponent<AudioSource>();
        source.loop = true;
        source.clip = live;
        source.volume = 0.2f;
        source.Play();

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (isDead==false && Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, 200));
            

        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
       isDead = true;
        GameControls.instance.CatDied();
        taill.SetActive(false);

        source.Stop();     
    }
}
