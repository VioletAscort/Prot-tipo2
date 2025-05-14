using UnityEngine;
using TMPro;

public class HPManager : MonoBehaviour
{
    public TextMeshProUGUI HPText; // Arraste da UI aqui pelo inspetor
    int Life = 3;

    public int GetLife()
    {
        return Life;
    }

    private void Start()
    {
        UpdateHPText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colisão detectada com: " + collision.gameObject.name);

        if (collision.gameObject.CompareTag("vida"))
        {
            ChangeLife(+1);
            Destroy(collision.gameObject); // sempre destrói o item
        }
    }

    public void ChangeLife(int amount)
    {
        if (Life >= 3 && amount > 0)
            return; // não passa de 3 de vida

        Life += amount;

        if (Life > 3)
            Life = 3;

        UpdateHPText();

        if (Life <= 0)
        {
            Debug.Log("Player morreu!");
            GameManager.Instance.TriggerGameOver();
            gameObject.SetActive(false); // desativa o player
        }

    }

    void UpdateHPText()
    {
        if (HPText != null)
        {
            HPText.text = $"HP {Life} ♥";
        }
    }
}
