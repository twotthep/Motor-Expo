using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    enum playerID
    {
        Player1,
        Player2,
        Player3,
        Player4
    }
    [Header("Player ID")]
    [SerializeField]
    playerID ID;

    [Header("Player Controller Axis")]
    [SerializeField]
    string horizontalAxis;
    [SerializeField]
    string verticalAxis;

    [Header("Player Movement Parameter")]
    Rigidbody rigidbody;
    public float movementSpeed;



    // Start is called before the first frame update
    void Start()
    {
        getPlayerController();
    }

    // Update is called once per frame
    void Update()
    {
        setPlayerController(getPlayerID());
        playerMovement();
    }

    string getPlayerID()
    {
        return ID.ToString();
    }
    void setPlayerController(string ID)
    {
        if(ID == "Player1")
        {
            horizontalAxis = "Horizontal1";
            verticalAxis = "Vertical1";
        }
        else if(ID == "Player2")
        {
            horizontalAxis = "Horizontal2";
            verticalAxis = "Vertical2";
        }
        else if (ID == "Player3")
        {
            horizontalAxis = "Horizontal3";
            verticalAxis = "Vertical3";
        }
        else if (ID == "Player4")
        {
            horizontalAxis = "Horizontal4";
            verticalAxis = "Vertical4";
        }
    }
    void getPlayerController()
    {
        setPlayerController(getPlayerID());
        rigidbody = GetComponent<Rigidbody>();
    }

    public void playerMovement()
    {
        if (Input.GetAxis(horizontalAxis) != 0  || Input.GetAxis(verticalAxis) != 0)
        {
            float axisValHorizontal = Input.GetAxis(horizontalAxis);
            float axisValVertical = Input.GetAxis(verticalAxis);
            rigidbody.velocity = new Vector3(movementSpeed * axisValHorizontal, 0, movementSpeed * axisValVertical);
        }
    }
}
