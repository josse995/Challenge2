using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject dogPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var currentDog = GameObject.Find("Dog(Clone)");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (currentDog == null)
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            else
            {
                var script = (MoveFoward)currentDog.GetComponent(nameof(MoveFoward));
                if (!script.IsReturning)
                {
                    Debug.Log("Coming back!");
                    script.ChangeDirection();
                }
                
            }
        }
    }
}
