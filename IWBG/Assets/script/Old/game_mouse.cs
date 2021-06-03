using System.Runtime.InteropServices;
using UnityEngine;

public class game_mouse : MonoBehaviour
{
    [HideInInspector]
    public bool sceen_change = false;

    //마우스가 강제적으로 움직일것인 권환을 줌.
    private bool mouse_move = false;

    private Vector2 previous_mouse;

    private int stop_mouse;

    private bool mouse_chek = false;

    public float MoveSpeed = 0.03f;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {//생성
        //사용자가 마우스를 움직이기 전 마우스 좌표.
        previous_mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //플레이어가 마우스를 움직일시 1초 후 움직임을 줄 변수.
        stop_mouse = 0;

        //마우스 좌표로 이동 시킴;
        gameObject.transform.position = previous_mouse;

        //1초 후 움직임.
        Invoke("alarm0", 3f);
    }

    private void alarm0()
    {
        if (sceen_change == false)
        {
            if (mouse_move == false)//마우스가 움직일 권환을 줌
            {
                if (mouse_chek == false)//마우스의 예전 좌표를 입력받을 기회를 줌.
                {
                    previous_mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    mouse_chek = true;
                }
                GameObject player = GameObject.Find("player");

                if (player != null)//플레이어가 있을 경우
                {
                    transform.position = Vector3.MoveTowards(transform.position,player.transform.position,MoveSpeed * Time.deltaTime);
                }
            }
            Invoke("alarm0", 0.02f);
        }
    }

    private void LateUpdate()
    {
        Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition); //실시간 마우스 위치를 받음
        if (sceen_change == false)
        {
            //전에 움직이던 마우스 좌표(x,y)와 현재 위치 좌표(x,y)를 뺌
            Vector2 chek = previous_mouse - mouse;

            float chek_abs_x = Mathf.Abs(chek.x);
            float chek_abs_y = Mathf.Abs(chek.y);

            //플레이어가 마우스를 움직였을시 그 차이가 0.3f 이상 차이가 날경우. 사용자가 마우스를 움직인거임
            if (chek_abs_x > 0.1f)
            {
                previous_mouse = mouse;
                gameObject.transform.position = mouse;
                stop_mouse = 0;//1초후 움직일 수 있는 권환을 리셋시킴.
                mouse_move = true;//마우스가 움직일 권한을 제거함.
            }

            if (chek_abs_y > 0.1f)
            {
                previous_mouse = mouse;
                gameObject.transform.position = mouse;
                stop_mouse = 0;//1초후 움직일 수 있는 권환을 리셋시킴.
                mouse_move = true;//마우스가 움직일 권한을 제거함.
            }

            //만약 마우스가 플레이어에 의해 정지 먹을시.
            if (mouse_move == true)
            {
                GameObject m_chek =  GameObject.Find("RCamera");
                if(m_chek != null)
                {
                Vector3 resultxy = GameObject.Find("RCamera").GetComponent<obj_camera>().result_value;
                float xx = (Input.mousePosition.x) + (resultxy.x * 800);
                float yy = (Input.mousePosition.y) + (resultxy.y * 608);

                Vector2 R_mouse = Camera.main.ScreenToWorldPoint(new Vector3(xx, yy, 0));
                gameObject.transform.position = R_mouse;

                //1초후에 움직일 수 있도록 1프레임씩 증가함.

                if (stop_mouse == 240)
                {/*만일 사용자가 마우스를 움직이고 나서 1초동안 마우스가 움직이지 않았다면*/
                    mouse_chek = false;
                    mouse_move = false;//다시 마우스가 혼자 움직일 수 있도록 권환을 줌.
                }
                else
                {
                    stop_mouse += 1;
                }
            }

                }

            //이 오브젝트를 게임 마우스 처럼 보이기 위해 자신을 마우스에 따라 다니게 함.
            #region
            Cursor.visible = false;//실제 마우스는 안보이게 함
            #endregion
        }
        else
        {
            GameObject temp = GameObject.Find("RCamera");

            if (temp != null)
            {
                Vector3 resultxy = GameObject.Find("RCamera").GetComponent<obj_camera>().result_value;
                float xx = (Input.mousePosition.x) + (resultxy.x * 800);
                float yy = (Input.mousePosition.y) + (resultxy.y * 608);

                Vector2 R_mouse = Camera.main.ScreenToWorldPoint(new Vector3(xx, yy, 0));
                gameObject.transform.position = R_mouse;

                previous_mouse = mouse;
                mouse_move = true;//마우스가 움직일 권한을 제거함.

                stop_mouse = 0;
                sceen_change = false;
            }
        }
    }
}
