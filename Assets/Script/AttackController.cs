using UnityEngine;

public class AttackController : MonoBehaviour
{

    private Animator anim;
    private bool isAttacking;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isAttacking) return;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            isAttacking = true;

            anim.SetTrigger("Slash");
        }
    }

    public void EndSlash()
    {
        isAttacking = false;
    }

    void FixedUpdate()
    {
        if(!isAttacking) return;
        Input.ResetInputAxes();
    }
}
