using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField] private Animator _animator;
   [SerializeField] private Transform _pelvis;

   private void Update()
   {
      var hor = Input.GetAxis("Horizontal");
      _pelvis.Rotate(0f, -hor, 0f);
      
      if (Input.GetKey(KeyCode.W))
      {
         _animator.enabled = true;
      }
      else
      {
         _animator.enabled = false;
      }
   }
}
