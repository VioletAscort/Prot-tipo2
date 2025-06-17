using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckboxBackMenu : MonoBehaviour
{
    public Sprite checkboxEmpty;
    public Sprite checkboxMarked;
    public string sceneToLoad;

    private Image checkboxImage;
    private bool isChecked = false;

    void Start()
    {
        checkboxImage = GetComponent<Image>();
        SetCheckbox(false);
    }

    public void OnClickPlay()
    {
        if (isChecked || string.IsNullOrEmpty(sceneToLoad)) return;

        SetCheckbox(true);
        Debug.Log("CARREGANDO CENA: " + sceneToLoad);
        SceneManager.LoadScene(sceneToLoad);

    }

    void SetCheckbox(bool marked)
    {
        isChecked = marked;

        if (checkboxImage != null)
            checkboxImage.sprite = marked ? checkboxMarked : checkboxEmpty;
    }
}

