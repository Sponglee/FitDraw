
using UnityEngine;

public class EnemyWeapon : WeaponBehaviour
{
    [SerializeField] private EnemyController enemyController;

    private void Start()
    {
        enemyController = transform.parent.parent.GetComponent<EnemyController>(); 
    }

    public override void CollisionInteract(Transform collisionTransform)
    {
        Debug.Log(transform.tag +" <_: " +  collisionTransform.gameObject.tag);
        if(!collisionTransform.CompareTag(transform.tag))
        {
            enemyController.PushBack();
        }
    }

   
}
