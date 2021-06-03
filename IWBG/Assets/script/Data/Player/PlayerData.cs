using UnityEngine;

// 에디터에서 쉽게 사용할 수 있도록 메뉴를 만듬
[ CreateAssetMenu( fileName = "Player Data", menuName = "Scriptable Object Asset/Player Data" )]
public class PlayerData : ScriptableObject
{
    private bool up_area = false;

    public bool L_will_jump;
    
    public float horizontal;

    public bool enable = false;
    public bool l_will_jump = false;
    public int frozen = 0;
    public float maxSpeed = 3;
    public float JumpGravity = 1;
    public float FallGravity = 1;
    public float maxFallSpeed = 8f;
    public float jumpPower = 9f;
    public float jumpPower_duble = 3f;
    public bool isGround = false;
    
    public bool dobleJump = false;
    public bool water_status = false;
    public GameObject game_over_msg, blood, smoke_effect;
    public int smoke = 0;

    public LayerMask GroundMask;
    
    public int left_x, down_y, right_x, up_y;
}
