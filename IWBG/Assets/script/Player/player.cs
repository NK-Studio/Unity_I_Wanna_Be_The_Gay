using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    //새로운 인풋 시스템
    private UIP uip;

    //플레이어 데이터
    public PlayerData PlayerData;

    //총알이 나갈 위치
    public Transform BulletPos;

    [NonSerialized]
    public Rigidbody2D rig;

    //애니메이터
    public Animator anim;

    public BoxCollider2D bodyCollider;

    public BulletPool BulletPool;

    public float downdfsfdsfsd = 1;
    
    //애니메이터 태그
    private static readonly int ID_Ground = Animator.StringToHash("isGround");
    private static readonly int Y_velocity = Animator.StringToHash("Y_velocity");
    private static readonly int Move = Animator.StringToHash("Move");

    private void Awake()
    {
        uip = new UIP();
        uip.player.move.performed += xx => PlayerData.horizontal = xx.ReadValue<float>();
        uip.player.Jump.performed += PressJump;
        uip.player.Jump.canceled += ReleasedJump;
        uip.player.Attack.performed += UpdateAttack;
        uip.player.SelfKill.performed += _ =>
        {
            Debug.Log("죽음");
            //world.instance.kill_player(gameObject);
        };

        rig = GetComponent<Rigidbody2D>();
    }

    private void UpdateAttack(InputAction.CallbackContext obj)
    {
        if (PlayerData.frozen == 0) BulletPool.Shot(PlayerData.horizontal);
    }

    private void ReleasedJump(InputAction.CallbackContext obj)
    {
        if (rig.velocity.y > 0)
            rig.velocity = new Vector2(rig.velocity.x, rig.velocity.y * 0.45f);
    }

    private void PressJump(InputAction.CallbackContext obj)
    {
        if (PlayerData.frozen == 0)
        {
            var Velocity = rig.velocity;
            if (!PlayerData.water_status)
            {
                if (PlayerData.isGround)
                {
                    // GetComponent<AudioSource>().PlayOneShot(world.instance.audio_effect[7]);
                    Velocity = new Vector2(Velocity.x, PlayerData.jumpPower);
                }
                else
                {
                    if (PlayerData.dobleJump)
                    {
                        // GetComponent<AudioSource>().PlayOneShot(world.instance.audio_effect[12]);
                        Velocity = new Vector2(Velocity.x, PlayerData.jumpPower_duble);
                        PlayerData.dobleJump = false;
                    }
                }
            }
            else
            {
                // GetComponent<AudioSource>().PlayOneShot(world.instance.audio_effect[12]);
                Velocity = new Vector2(Velocity.x, PlayerData.jumpPower_duble);
                PlayerData.dobleJump = false;
            }

            rig.velocity = Velocity;
        }
    }

    private void OnEnable() => uip.Enable();

    private void OnDisable() => uip.Disable();

    private void Update()
    {
        anim.SetFloat(Y_velocity, rig.velocity.y);

        //땅 체크
        updateGroundCheck();

        //중력을 다르게 처리
        updateGravitiyScale();
        
        if (PlayerData.enable)
        {
            // if (smoke == 1)
            // {
            //     rig.velocity = Vector2.zero;
            //     rig.velocity = Vector2.up * 5;
            // }

            anim.SetBool(ID_Ground, PlayerData.isGround);

            if (PlayerData.frozen == 0)
            {
                if (PlayerData.L_will_jump == false)
                {
                    if (!Mathf.Approximately(PlayerData.horizontal, 0))
                        transform.GetChild(0).localScale = new Vector2(PlayerData.horizontal, 1); //GFX objetct to Flip
                }
            }
            
            if (PlayerData.frozen == 0)
            {
                //떨어지는 가속도를 일정하게 만듬
                if (rig.velocity.y < -PlayerData.maxFallSpeed)
                    rig.velocity = new Vector2(rig.velocity.x, -PlayerData.maxFallSpeed);
            }
        }
    }

    private void FixedUpdate()
    {
        if (PlayerData.enable)
        {
            //Frozen이 0보다 이상일때 0으로 만들기위해 줄임
            if (PlayerData.frozen > 0) 
                PlayerData.frozen -= 1;

            if (PlayerData.frozen == 0) 
                UpdateMove();
        }
    }

    private void UpdateMove()
    {
        rig.velocity = new Vector2(PlayerData.horizontal * 5.5f, rig.velocity.y);
        anim.SetInteger(Move, (int) Math.Abs(PlayerData.horizontal));
    }
    
    private void updateGroundCheck()
    {
        //플레이어의 콜라이더에서 CenterBottom의 위치를 담습니다.
        var Point = Vector2.zero;
        var bounds = bodyCollider.bounds;
        Point.x = bounds.center.x;
        Point.y = bounds.min.y;

        //땅 체크
        PlayerData.isGround = Physics2D.OverlapCircle(Point, 0.025f, PlayerData.GroundMask);

        if (PlayerData.isGround) PlayerData.dobleJump = true;
        
        //땅 충돌을 실시간으로 애니메이터에 넘긴다.
        anim.SetBool(ID_Ground, PlayerData.isGround);
    }
    private void updateGravitiyScale()
    {
        //디폴트는 1이다.
        rig.gravityScale = 1;

        //위로 상승하면 jump, 하강이면 fall 중력으로 변경한다.
        if (rig.velocity.y > 0.05f)
            rig.gravityScale = PlayerData.JumpGravity;
        else if (rig.velocity.y < -0.05f)
            rig.gravityScale = PlayerData.FallGravity;
    }
}
