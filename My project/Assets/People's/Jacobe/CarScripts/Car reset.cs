using UnityEngine;

public class Carreset : MonoBehaviour
{
    public Rigidbody carRb;
    public Transform CenterCheck;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
                transform.position = Vector3.zero;
                transform.position = new Vector3(CenterCheck.position.x + 140f, CenterCheck.position.y + 2f, CenterCheck.position.z + 287f);
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
