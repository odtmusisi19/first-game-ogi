using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakanPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public float kecepatan;
    Rigidbody rb;
    Animator anim;

    Transform tes;
    public Transform playerPutaran;
    public Joystick joystick;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); // mengambil komponen yang ada di inspector
        anim = GetComponent<Animator>();
        tes = GetComponent<Transform>();

    }
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }
    void Bergerak()
    {
        if (Input.GetKey("d"))
        {
            // Debug.Log(tes.position);

        }
        // float Gerak = joystick.Horizontal;
        float Gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * Gerak * kecepatan;
        anim.SetFloat("Kecepatan", Mathf.Abs(Gerak), 0.1f, Time.deltaTime);
        playerPutaran.eulerAngles = new Vector3(0, Gerak * 90, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("virus"))
        {
            // Debug.Log("berhasil");
            Time.timeScale = 0;
            Destroy(gameObject);
        }
    }
}
