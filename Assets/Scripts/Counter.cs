using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;

    private int _count;

    private void Start()
    {
        _count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        _count += 1;
        counterText.text = "Count : " + _count;
    }
}
