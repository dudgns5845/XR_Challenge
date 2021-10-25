using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSelfTirgger_Rio : MonoBehaviour
{
    void Start()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetTrigger((WorkOutInfoManager_Rio.instance.nowIndex + 1).ToString());
    }
}
