using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    // Start is called before the first frame update
    public float initialTimeRemaining = 5;
    private float timeRemaining = 5;

    // Fruit Positions
    private Vector3 fruit1Position;
    private Vector3 fruit2Position;
    private Vector3 fruit3Position;

    // Fruit Objects
    public Rigidbody2D fruit;
    public Rigidbody2D fruit2;    
    public Rigidbody2D fruit3;

    void Start() {
        fruit1Position = fruit.transform.position;
        fruit2Position = fruit2.transform.position;
        fruit3Position = fruit3.transform.position;
    }

    void Update() {
        if (timeRemaining > 0) {
            timeRemaining -= Time.deltaTime;
        } else {
            timeRemaining = initialTimeRemaining;
            fruit.transform.position = fruit1Position;
            fruit2.transform.position = fruit2Position;
            fruit3.transform.position = fruit3Position;
        }
        
    }
}
