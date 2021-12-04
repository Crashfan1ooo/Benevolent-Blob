using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    private CharacterController controller;

    [SerializeField] public float characterSpeed = 12f;

    [SerializeField] public float characterJump = 3f;

    [SerializeField] private float gravity = 8f;

    [SerializeField] private float doubleJumpMultiplier = 0.5f;

    [SerializeField] public float rotationSpeed;

    [SerializeField] private KeyBindScript keybinds;

    //audio stuff

    public AudioSource characterAudio;
    public AudioSource coinAudio;
    public AudioClip jumpSound;
    public AudioClip coinSound;

    //audio stuff 

    private bool alreadyLeft;
    private bool alreadyRight = true;

    public GameObject BlobBoy;

    private float directionY;

    private bool canDoubleJump = false;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        keybinds = GetComponent<KeyBindScript>();
        characterAudio = GetComponent<AudioSource>();
        characterAudio.clip = jumpSound;
        coinAudio.clip = coinSound;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, 0, 0);

        if (controller.isGrounded)
        {
            canDoubleJump = true;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                directionY = characterJump;
                characterAudio.Play();
            }

        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && canDoubleJump)
            {
                directionY = characterJump * doubleJumpMultiplier;
                canDoubleJump = false;
                characterAudio.Play();
            }
        }


        directionY -= gravity * Time.deltaTime;

        direction.y = directionY;

        controller.Move(direction * characterSpeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.A) && alreadyLeft == false)
        {
            BlobBoy.transform.Rotate(0, 180, 0);
            alreadyLeft = true;
            alreadyRight = false;
        }

        if (Input.GetKeyDown(KeyCode.D) && alreadyRight == false)
        {
            BlobBoy.transform.Rotate(0, 180, 0);
            alreadyRight = true;
            alreadyLeft = false;
        }


        
    }

    public void CoinCollected()
    {
        characterAudio.Play();
    }
}
