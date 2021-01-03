using UnityEngine;
using System.Collections;

public class MoveFoward : MonoBehaviour
{
    public float speed = 20;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void ChangeDirection()
    {
        IsReturning = true;
        transform.Rotate(Vector3.up, 180);
    }

    public bool IsReturning { get; private set; }
}
