using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningAnim : MonoBehaviour
{
    Animator myAnimator;

    const string TIMER_ANIM = "WorkTimerEnd";
    private Timer1 workTimer_script;

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    private void OnWorkTimerEnd()
    {
        myAnimator.SetTrigger("TIMER_ANIM");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnimator.SetTrigger(TIMER_ANIM);
        }
    }
}
