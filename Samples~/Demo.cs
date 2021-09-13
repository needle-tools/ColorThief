using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ColorThief
{
	public class ColorThiefDemo : MonoBehaviour
	{
		public Texture2D texture;
		public RawImage image;
		public Image dominantColor;
		public Image[] paletteColors;

		public InputField urlField;

		public void Download()
		{
			StartCoroutine(DownloadImage());
		}

		IEnumerator DownloadImage()
		{
			WWW www = new WWW(urlField.text);
			yield return www;
			if(string.IsNullOrEmpty(www.error))
			{
				texture = www.texture;
				image.texture = texture;
				float ratio = 700f/texture.height;
				float w = texture.width * ratio;
				float h = texture.height * ratio;
				image.rectTransform.sizeDelta = new Vector2(w, h);
				var dominant = new ColorThief();
				dominantColor.color = dominant.GetColor(texture).UnityColor;
				
				var palette = new ColorThief();
				List<QuantizedColor> colors = palette.GetPalette(texture, paletteColors.Length);
				for(int i=0; i<colors.Count; i++)
					paletteColors[i].color = colors[i].UnityColor; 
			}
			else
				Debug.Log(www.error);		
		}
	}
}
