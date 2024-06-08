
using UnityEngine.UI;
using UnityEngine;

public class FadeEffect : MonoBehaviour
{
    private Image image;  //페이드 효과에 사용되는 검은 바탕 이미지

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Update()
    {
        // image의 color 프로퍼티는 a 변수만 따로 set이 불가능에서 변수에 저장
        Color color = image.color;
        
        // 알파 값(a)이 e보다 크면 알파 값 감소
        if ( color.a > 0)
        {
            color.a -= Time.deltaTime;
        }
        // 알파 값(a)이 1보다 작으면 알파 값 증가
        if ( color.a < 1)
        {
            color.a += Time.deltaTime;
        }

        // 바뀐 색상 정보를 image.color에 저장
        image.color = color;

    }

}
