using UnityEngine;

public class Ground : MonoBehaviour
{
    public string color;
    private BoxCollider2D _bc;

    // Start is called before the first frame update
    void Start()
    {
        _bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _bc.enabled = ColorChanger.colorText == color;
    }
}
