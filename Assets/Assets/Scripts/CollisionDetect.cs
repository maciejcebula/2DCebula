using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text gameScore;
    public Text endScore;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            endScore.text = gameScore.text;
            gameOverPanel.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
