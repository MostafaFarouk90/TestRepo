using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TossBall : MonoBehaviour
{
    public float forceStep = 0.2f, maxForce = 1.6f;
    public Image forceSlider;
    public Text triesCounterText;

    float currentforce;
    Vector3 initialPosition;
    Rigidbody rb;
    int triesCount;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position;
        forceSlider.fillAmount = 0;
        triesCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            currentforce = 0;
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            transform.position = initialPosition;
            triesCount++;
            triesCounterText.text = "Tries: " + triesCount;
        }
        if (Input.GetMouseButton(0) && currentforce < maxForce)
        {
            currentforce += forceStep * Time.deltaTime;
            forceSlider.fillAmount = currentforce/maxForce;
        }
        if (Input.GetMouseButtonUp(0))
        {
            rb.isKinematic = false;
            rb.AddForce(new Vector3(0f, 2*currentforce, currentforce), ForceMode.Impulse);
            currentforce = 0;
            forceSlider.fillAmount = 0;
        }
    }
}
