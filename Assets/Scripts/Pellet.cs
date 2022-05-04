using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    //TextMesh theScoreTextMesh;

    //public GameObject scoreText;
    //private int count;

    // Start is called before the first frame update
    void Start()
    {
        //this.theScoreTextMesh = this.scoreText.GetComponent<TextMesh>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.theScoreTextMesh.text = "Score:" + count;
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            {
                //count = count + 1;
                //this.theScoreTextMesh.text = "Score:" + count;
                Destroy(this.gameObject);
                print("I should add");
            }

        }
    }

}
