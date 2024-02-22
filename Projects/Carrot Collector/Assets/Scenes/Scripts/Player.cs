using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

    public FixedJoystick joystick;
    public float moveSpeed;
    public TextMeshProUGUI left;


    float hInput, vInput;

    int score = 0;
    public GameObject winText;

    public int winScore;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        hInput = joystick.Horizontal * moveSpeed;
        vInput = joystick.Vertical * moveSpeed;
        transform.Translate(hInput, vInput, 0);

    }

    void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.tag == "Carrot")
        {
            if (int.Parse(left.text) != 0)
            {
                score++;
                Destroy(other.gameObject);
                left.text = (int.Parse(left.text) - 1).ToString();
            }
        }
        if (score >= winScore)
        {
            winText.SetActive(true);
        }
    }
}
