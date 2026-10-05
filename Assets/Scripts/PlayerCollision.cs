using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public string trophyTag;

    public TextMeshProUGUI winText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag(trophyTag))
        {
            winText.gameObject.SetActive(true);
            other.transform.SetParent(this.gameObject.transform);
        }

    }
}
