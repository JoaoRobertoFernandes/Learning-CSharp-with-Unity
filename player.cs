using UnityEngine;

public class player : MonoBehaviour {

    //speed
    private float spd = 0.02f;
    //camera
    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, spd);//Player run
        camera.transform.position = transform.position + new Vector3(0, 2f, -5f);//Camera follow the Player
        
        /*----------Move to left and right----------*/
        if(Input.GetKey("d")) {
            //Move to right
            transform.position += new Vector3(spd, 0, 0);
        }else if (Input.GetKey("a")) {
            //Move to left
            transform.position += new Vector3(-spd, 0, 0);
        }
        /*----------Move to left and right----------*/
    }

    //When "Player" collides with "Wall", the game will be reloaded! 
    void OnCollisionEnter(Collision obj)
    {
        if (obj.gameObject.tag == "Wall") {
            /*----------Reload Scene---------*/
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex,LoadSceneMode.Single);
            /*----------Reload Scene---------*/
        }
    }
}