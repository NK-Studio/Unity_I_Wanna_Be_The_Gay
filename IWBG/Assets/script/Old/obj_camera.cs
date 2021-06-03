using UnityEngine;

public class obj_camera : MonoBehaviour
{
    public Camera mycam;

    public Camera parent_cam;

    public Vector2 result_xy;
    public Vector3 result_value;

    public int right_size,up_size;

    void Update()
    {
        GameObject player = GameObject.Find("player");

        if (player == null)
        {
            return;
        }
            Vector3 came_position = gameObject.transform.position;
                Vector2 pl_position = parent_cam.WorldToScreenPoint(player.transform.position);
                      Vector2 pl_position_sup = mycam.WorldToScreenPoint(player.transform.position);

         if (pl_position_sup.x < 0 || pl_position_sup.x > 800 || pl_position_sup.y < 0 || pl_position_sup.y > 608)
        {
            GameObject temp = GameObject.Find("obj_mouse");
            if(temp != null)
            {
                temp.GetComponent<game_mouse>().sceen_change = true;
            }
        }
        
        if (pl_position.x > 0 && pl_position.x < right_size && pl_position.y > 0 && pl_position.y < up_size)
        {
            came_position.x = Mathf.Floor((pl_position.x / 800));

            came_position.y = Mathf.Floor((pl_position.y / 608));

            came_position.z = 0;
            result_value = came_position;

            came_position.z = -10;

            float xx = came_position.x * 8;
            float yy = came_position.y * 6.08f;
            came_position.x = xx;
            came_position.y = yy;
            result_xy = came_position;

            gameObject.transform.position = came_position;
        }
        //화면 밖으로 나가면 죽음
        if (pl_position.x < -2 || pl_position.x > right_size+2 || pl_position.y < -2 || pl_position.y > up_size + 2)
        {
            world.instance.kill_player(player);
        }

        }


}