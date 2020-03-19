using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
  
    void CollisionInteract(Transform collisionTransform);
    void TriggerInteract(Transform triggerTransform);
}
