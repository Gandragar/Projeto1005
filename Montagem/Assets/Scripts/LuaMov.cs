using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuaMov : MonoBehaviour
{
    public float speed;
    Vector3 position;
    public float MaxPos = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
    position = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
      position.x += Input.GetAxis ("Horizontal") * speed * Time.deltaTime;

      position.x = Mathf.Clamp (position.x,-7.5f, 7.5f);

      transform.position = position;
    }

    void OnCollisionEnter2D(Collision2D col) {
      if (col.gameObject.tag == "Enemy Asteroide") {
        Destroy (gameObject);
      }
    }
}
