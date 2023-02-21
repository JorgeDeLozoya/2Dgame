using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float Speed;
    public AudioClip Sound;
    private Rigidbody2D Rigidbody2D;
    private Vector3 Direction;//Dirección en la que va avanza la bala

    // Start is called before the first frame update
    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Camera.main.GetComponent<AudioSource>().PlayOneShot(Sound);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector3 direction)
    {
        Direction = direction;
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }

   /* private void OnTriggerEnter2D(Collider2D other)
    {
        GruntScript grunt = other.GetComponent<GruntScript>();
        JohnMovement john = other.GetComponent<JohnMovement>();
        if (grunt != null)
        {
            grunt.Hit();
        }
        if (john != null)
        {
            john.Hit();
        }
        DestroyBullet();
    }*/
}
