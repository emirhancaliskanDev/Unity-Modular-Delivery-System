using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    Vector3 movementDirection;
    Rigidbody playerRigidbody;

    [SerializeField]Camera fpsCamera;
    Vector3 cameraForward;
    Vector3 cameraRight;
    [SerializeField]float movementSpeed;
    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void Start()
    {
        playerRigidbody.freezeRotation = true;
    }

    void Update()
    {
        cameraForward = fpsCamera.transform.forward;
        cameraRight = fpsCamera.transform.right;
        
        movementDirection = PlayerInputs.Instance.GetMovementInput.y * cameraForward + PlayerInputs.Instance.GetMovementInput.x * cameraRight;
        movementDirection.y = 0;
    }


    void FixedUpdate()
    {
        
        playerRigidbody.AddForce(movementDirection * movementSpeed,ForceMode.Force);
    }
}
