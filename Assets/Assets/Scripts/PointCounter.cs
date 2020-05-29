using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PointCounter : MonoBehaviour
{

    public Text pointText;
    private int points = 0;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            points += 1;
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Score: " + points.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
