using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.gameStatus)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myRigidbody.linearVelocity = Vector2.up * flapStrength;
            }
        }
        if(myRigidbody.position.y>17 || myRigidbody.position.y<-17)
        {
            logic.gameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
    }
}
