using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DoorController : MonoBehaviour, IPointerClickHandler
{
    private Animator _animator;

    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger("PicDoor");
    }

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
