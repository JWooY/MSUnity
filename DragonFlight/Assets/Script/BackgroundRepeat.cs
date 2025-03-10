using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{
    //��ũ���� �ӵ��� ����� ������ �ݴϴ�.
    public float scrollSpeed = 1.2f;
    private Material thisMaterial;

    void Start()
    {
        //��ü�� ������ �� ���� 1ȸ ȣ��Ǵ� �Լ�
        //���� ��ü�� Component���� ������ Renderer��� ������Ʈ�� Material ������ �޾ƿ´�
        thisMaterial = GetComponent<Renderer>().material;


    }


    void Update()
    {
        //���Ӱ� �������� Offset ��ü�� �����մϴ�.
        Vector2 newOffset = thisMaterial.mainTextureOffset;
        //Y�κп� ���� y���� �ӵ��� ������ �����ؼ� �����ݴϴ�.
        newOffset.Set(0, newOffset.y + (scrollSpeed * Time.deltaTime));
        //���������� offset���� �������ݴϴ�.
        thisMaterial.mainTextureOffset = newOffset;


    }
}
