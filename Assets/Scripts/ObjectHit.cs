using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer renderer;
    private void Start() {
        renderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision col) 
    {
        if(col.gameObject.tag == "Player") {
            renderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}