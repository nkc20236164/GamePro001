using UnityEngine;
using UnityEngine.UI;

public class aaa : MonoBehaviour
{
    public Image timeGauge;
    public float time = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        // Time_gauge��Image�R���|�[�l���g���擾
        timeGauge = GameObject.Find("Time_gauge").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���Ԃ̌�������
        time -= Time.deltaTime;
        this.timeGauge.GetComponent<Image>().fillAmount = time / 100.0f; // �^�C���Q�[�W�̕\�����X�V
    }
}