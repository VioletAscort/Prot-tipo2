using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject painelMenuInicial;
    public GameObject painelOpcoes;

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void VoltarMenu()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }
}
