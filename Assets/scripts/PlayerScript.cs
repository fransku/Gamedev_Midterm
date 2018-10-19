using UnityEngine;

public class PlayerScript : MonoBehaviour {

	//usage: put this on a capsule with a rigidbody, mouse look and WASD movement
	public float moveSpeed;

	public Collider PlayerIsLooking;

    //jump stuff
    public bool isGrounded;
    public Vector3 jump;
    public float jumpForce = 10.0f;
    Rigidbody rb;
    //this variable will remember input and pass it to physics
    Vector3 inputVector;

    void Start()
    {//more jump stuff
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    void Update () {
		Ray myRay = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		float maxRayPickUp = 10f; 
		RaycastHit myRayHit = new RaycastHit();
	
		Debug.DrawRay(myRay.origin, myRay.direction * maxRayPickUp, Color.cyan);
		
		if (Physics.Raycast(myRay, out myRayHit, maxRayPickUp))
		{
			Debug.Log("player in distance");
            //raycast is remembering what we are looking at thru playerislooking collider
			PlayerIsLooking = myRayHit.collider;
		}else
		{
            PlayerIsLooking = null; 
		}

		//WASD MOVEMENT 
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		//transform.position += transform.forward * vertical * moveSpeed;
		//transform.position += transform.right * horizontal * moveSpeed; 

		inputVector = transform.forward * vertical;
		inputVector += transform.right * horizontal;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            //   rb.AddForce(jump * jumpForce, ForceMode.Impulse);
              rb.AddForce(jumpForce * transform.up, ForceMode.Impulse);
   
               isGrounded = false;
        }
        

        //grounded stuff
        Ray ray = new Ray(transform.position, Vector3.down);
		
		// step 2: set the raycasts maximum distance
		float maxRaycastDistance = 6f; 
		
		//step 3: optional- visualize the raycast
		Debug.DrawRay(ray.origin, ray.direction * maxRaycastDistance, Color.yellow);
		
		//step 4: actually shoot the raycast
		if (Physics.Raycast(ray, maxRaycastDistance))
		{
			Debug.Log("the grounded raycast hit the floor");
            isGrounded = true;
		}
		else
		{
			//transform.Rotate(0, 5f, 0);
            isGrounded = false;
		}

    }

	//it runs every physics frame 
	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = inputVector * moveSpeed + Physics.gravity * 0.69f;
	}
}
