using UnityEngine;

public class TrainController : MonoBehaviour
{
    public float speed = 5f; // poyezd tezligi
    private bool isMoving = true; // poyezd harakatdami yoki yo‘qmi

    void Update()
    {
        // Agar poyezd harakatlanayotgan bo‘lsa, chapdan o‘ngga yuradi
        if (isMoving)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    // Bu funksiya tugma bosilganda chaqiriladi
    public void StopTrain()
    {
        isMoving = false;
        Debug.Log("Poyezd to‘xtadi!");
    }
}
