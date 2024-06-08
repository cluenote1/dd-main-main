
using UnityEngine.UI;
using UnityEngine;

public class FadeEffect : MonoBehaviour
{
    private Image image;  //���̵� ȿ���� ���Ǵ� ���� ���� �̹���

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        // image�� color ������Ƽ�� a ������ ���� set�� �Ұ��ɿ��� ������ ����
        Color color = image.color;
        
        // ���� ��(a)�� e���� ũ�� ���� �� ����
        if ( color.a > 0)
        {
            color.a -= Time.deltaTime;
        }
        // ���� ��(a)�� 1���� ������ ���� �� ����
        if ( color.a < 1)
        {
            color.a += Time.deltaTime;
        }

        // �ٲ� ���� ������ image.color�� ����
        image.color = color;

    }

}
