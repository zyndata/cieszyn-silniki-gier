using Invector.vCharacterController;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public vThirdPersonInput playerInput;
    public Animator playerAnimator;


    [ContextMenu("Test animation")]
    public void Test()
    {
        playerAnimator.Play("Cheering");
    }

    public void PauseMovement()
    {
        StartCoroutine(PauseMovementRoutine());
    }

    private IEnumerator PauseMovementRoutine()
    {
        StopMovement();
        yield return new WaitForSeconds(3.0f);
        StartMovement();
    }

    public void StopMovement()
    {
        playerInput.enabled = false;
    }

    public void StartMovement()
    {
        playerInput.enabled = true;
    }
}
