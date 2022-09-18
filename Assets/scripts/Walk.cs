using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rigid;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        speed = 0.1f;
        rigid = GetComponent<Rigidbody2D>();
        rigid.isKinematic = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(horizontal, vertical);

        rigid.MovePosition(rigid.position + movement*speed);
    }
}
