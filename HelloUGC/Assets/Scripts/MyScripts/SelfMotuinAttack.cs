using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Items.Actions;

public class SelfMotuinAttack : MonoBehaviour
{
    private Animator animator;
    public GameObject Mybow;
    private ShootableWeapon shootableWeapon;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        shootableWeapon =  Mybow.GetComponent<ShootableWeapon>();
       InvokeRepeating("StrartAttack",2,2);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void StrartAttack()
    {
        StartCoroutine(Attack());

    }

    IEnumerator Attack()
    {
        // 抬手拉弓
        animator.SetInteger("Slot1ItemStateIndex",2);
        animator.SetTrigger("Slot1ItemStateIndexChange");
        yield return new WaitForSeconds(0.5f);
      //  GameObject.Instantiate
        // 放手射箭出去
        shootableWeapon.ProjectileFire(0.5f);
         animator.SetInteger("Slot1ItemSubstateIndex",12);
        yield return new WaitForSeconds(0.2f);

        animator.SetInteger("Slot1ItemSubstateIndex",0);
         // 装载子弹
        animator.SetInteger("Slot1ItemStateIndex",3);
        animator.SetTrigger("Slot1ItemStateIndexChange");
        shootableWeapon.DetermineVisibleProjectile(false);
         //恢复原状

        yield return new WaitForSeconds(0.1f);
        animator.SetInteger("Slot1ItemStateIndex",0);
    //    shootableWeapon.DetermineVisibleProjectile(false);

    }

}
