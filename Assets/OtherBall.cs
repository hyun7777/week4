using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }


    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "My Ball")
            mat.color = new Color(0, 0, 0);
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }

}
