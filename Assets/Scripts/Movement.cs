using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    NavMeshAgent pinkGhostAgent;
    TextMesh theScoreTextMesh;

    public GameObject scoreText;
    public float speed = 20.0f;
    public GameObject pinkGhost;
    private int score = 0;

    //private bool goForward = false;
    //private bool goBackward = false;
    //private bool goRight = false;
    //private bool goLeft = false;

    void Awake()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
        pinkGhostAgent = this.pinkGhost.GetComponent<NavMeshAgent>();
        pinkGhostAgent.speed = 2.0f;
        this.theScoreTextMesh = this.scoreText.GetComponent<TextMesh>();
    }

    // Start is called before the first frame update
    void Start()
    {
        this.theScoreTextMesh.text = "Score" + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Pellet"))
        {
            score++;
            this.theScoreTextMesh.text = "Score" + score;
         }
        else if(other.gameObject.tag.Equals("RightTP"))
        {
            this.gameObject.transform.position = new Vector3(-8.0f, .15f, .5f);
        }
        else if (other.gameObject.tag.Equals("LeftTP"))
        {
            this.gameObject.transform.position = new Vector3(8.0f, .15f, .5f);
        }
    }

    // Update is called once per frame

    void Update()
    {
        this.pinkGhostAgent.SetDestination(this.gameObject.transform.position);

        if (Input.GetKeyDown("w"))
        {
            rb.velocity = Vector3.forward * speed;
        }
        else if (Input.GetKeyDown("s"))
        {
            rb.velocity = Vector3.back * speed;
        }
        else if (Input.GetKeyDown("a"))
        {
            rb.velocity = Vector3.left * speed;
        }
        else if (Input.GetKeyDown("d"))
        {
            rb.velocity = Vector3.right * speed;
        }
        /*
        if (Input.GetKeyDown("w"))
        {
            this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.up);
            goForward = true;
            goBackward = false;
            goRight = false;
            goLeft = false;

        }
        else if (Input.GetKeyDown("s"))
        {
            this.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.up);

            goForward = false;
            goBackward = true;
            goRight = false;
            goLeft = false;

        }
        else if (Input.GetKeyDown("a"))
        {
            this.transform.rotation = Quaternion.LookRotation(-Camera.main.transform.right);

            goForward = false;
            goBackward = false;
            goRight = false;
            goLeft = true;

        }
        else if (Input.GetKeyDown("d"))
        {
            this.transform.rotation = Quaternion.LookRotation(Camera.main.transform.right);

            goForward = false;
            goBackward = false;
            goRight = true;
            goLeft = false;

        }
        */
    }
}