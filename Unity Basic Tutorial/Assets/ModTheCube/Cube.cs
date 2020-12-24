using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector4 changeColorSpeed;
    public Vector3 translationSpeed, translationAmplitude, rotationSpeed;

    private Material material;
    private Vector4 VariableColor;
    private Vector3 initialPosition, VariablePosition;

    void Start()
    {
        transform.position = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
        transform.localScale = Vector3.one * 1.3f;
        
        material = Renderer.material;
        
        material.color = new Color(Random.Range(0f,1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        VariableColor = new Vector4();
        initialPosition = transform.position;
        VariablePosition = new Vector3();
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeed.x * Time.deltaTime, rotationSpeed.y * Time.deltaTime, rotationSpeed.z * Time.deltaTime);

        VariableColor += changeColorSpeed * Time.deltaTime;
        material.color = new Color(Mathf.Abs(Mathf.Sin(VariableColor.x)), Mathf.Abs(Mathf.Sin(VariableColor.y)), Mathf.Abs(Mathf.Sin(VariableColor.z)), Mathf.Abs(Mathf.Sin(VariableColor.w)));

        VariablePosition += translationSpeed * Time.deltaTime;
        transform.position = initialPosition + new Vector3(Mathf.Sin(VariablePosition.x), Mathf.Sin(VariablePosition.y), Mathf.Sin(VariablePosition.z));

    }


 
}
