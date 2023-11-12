using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAttachment : MonoBehaviour
{
    void AttachSprite(Sprite baseSprite, Sprite attachedSprite)
    {
        byte[] baseSpritePixelArray = baseSprite.texture.GetRawTextureData();
        byte[] attachedSpritePixelArray = attachedSprite.texture.GetRawTextureData();

        for (int i = 0; i < baseSpritePixelArray.Length; i += 4)
        {
            if (attachedSpritePixelArray[i + 3] == 0)
                continue;
            baseSpritePixelArray[i] = attachedSpritePixelArray[i];
            baseSpritePixelArray[i+1] = attachedSpritePixelArray[i+1];
            baseSpritePixelArray[i+2] = attachedSpritePixelArray[i+2];
        }
        
        baseSprite.texture.LoadRawTextureData(baseSpritePixelArray);
        baseSprite.texture.Apply();
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
