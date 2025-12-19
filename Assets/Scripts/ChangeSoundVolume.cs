using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSoundVolume : MonoBehaviour
{
    private AudioSource audioSource;
    public static float SoundValue = 0.5f;

    public Slider SliderSound;

    private void Start()
    {
        // "AudioSource"コンポーネントを取得
        audioSource = gameObject.GetComponent<AudioSource>();
        SliderSound.value = getSoundValue();

    }

    /// <summary>
    /// スライドバー値の変更イベント
    /// </summary>
    /// <param name="newSliderValue">スライドバーの値(自動的に引数に値が入る)</param>
    public void SoundSliderOnValueChange(float newSliderValue)
    {
        SoundValue = newSliderValue;
        // 音楽の音量をスライドバーの値に変更
        audioSource.volume = SoundValue;
    }

    public static float getSoundValue()
    {
        return SoundValue;
    }
}
