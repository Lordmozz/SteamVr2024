using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
    public Transform orbitPivot;
    public float orbitSpeed;
    public float rotationSpeed;
    public float planetRadius;
    public float distFromStar;
    // Start is called before the first frame update
    void Start()
    {
        // create a random potion along the orbit path
        Vector2 randomPosition = Random.insideUnitCircle;
        transform.position = new Vector3(randomPosition.x, 0f, randomPosition.y) * distFromStar;
        //set the size of the gameobjcet to the planet radius value
        transform.localScale = Vector3.one * planetRadius;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(orbitPivot.position,Vector3.up,orbitSpeed * Time.deltaTime);
        this.transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        // up to 50fps
    }
}
