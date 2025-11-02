using UnityEngine;

public class LIfeCycle : MonoBehaviour
{
    void Start()
    {
       
    }

    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime, 
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        transform.Translate(vec);
    }
}
