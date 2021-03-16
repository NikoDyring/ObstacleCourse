using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,spinSpeed,0);
    }
}
