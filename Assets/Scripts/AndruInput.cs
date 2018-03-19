using System.Collections;
using UnityEngine;

public class AndruInput : MonoBehaviour
{

    private Animator anim;
    private bool isMoving;
    private Vector2 lastMoving;
    private float moveSpeed = 2;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        isMoving = false;
        if (Input.touchCount == 1) {
            Touch touch = Input.touches[0];
            if (touch.position.x<Screen.width/2 || touch.position.x > Screen.width / 2)
            {
                transform.Translate(new Vector3(touch.position.x * moveSpeed * Time.deltaTime, 0f, 0f));
                isMoving = true;
                lastMoving = new Vector2(touch.position.x, touch.position.y);
            }

            if (touch.position.y < Screen.width / 2 || touch.position.y > Screen.width / 2)
            {
                transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
                isMoving = true;
                lastMoving = new Vector2(touch.position.x, touch.position.y);
            }
            anim.SetFloat("MoveX", touch.position.x);
            anim.SetFloat("MoveY", touch.position.y);
            anim.SetBool("IsMoving", isMoving);
            anim.SetFloat("LastMoveX", lastMoving.x);
            anim.SetFloat("LastMoveY", lastMoving.y);
            }
    }
}
