# MG_TextWithImages - TextWithImages for MonoGame.
This class allows for easy texture placement inside text (each texture will be scaled horizontally to match text line height, while maintaining original proportions).   
Other functionalities are: shadow and simple "writing" animation.
```
textWithImages = new TextWithImages(spriteBatch: _spriteBatch, font: fontFreeSansBold, text: "This is a sample text | | | | .",  
textWithImages.Update();
textWithImages.Draw(position: textPos, color: Color.White, textScale: 1f);
```
#### You can use this class freely, commercial projects included.

# Usage
 
### First, create TextWithImages object:

```
textWithImages = new TextWithImages(spriteBatch: _spriteBatch, font: fontFreeSansBold, text: "This is a sample text | | | | .",  
imageList: new List<Texture2D> { imageUp, imageEnter, imageSpace, imageUp });
```
 
**SpriteBatch**: spriteBatch that will be used to render.  
**Font**: font for text.  
**Text**: text to write. Mark images with "|" character marker (marker count must match image count).  
**ImageList**: list of Texture2D objects. Must match "|" marker count.  
**Animate**: enable "writing" animation effect.  
**FramesPerChar**: how many frames will every character be displayed for. Use with "animate".  
**CharsPerFrame**: how many characters will be displayed for every frame. Use with "animate".  
**TreatImagesAsSquares**: change image proportions to square (squashing them).  
 
### If "animate" option is enabled, then in every Update() you have to use:
```
textWithImages.Update();
```
 
### Finally, draw:  
```
textWithImages.Draw(position: textPos, color: Color.White, textScale: 1f);
```

**Position**: upper-left text corner position.  
**Color**: text color.  
**TextScale**: whole text scale (images included).  
**ImageOpacity**: opacity of images (does not affect text).  
**InflatePercent**: changes the size of every image (in place). Allows for big images, overlapping text.  
 
#### Additional options (for shadow):  
ShadowColor: shadow color.  
ShadowOffset: shadow offset.  
  
### Extras
  
#### TextWithImages object has some useful properties:
  
**TextWidth**: text width. Does not account for "textScale" used in Draw(). Useful for calculating draw position.  
**TextHeight**: text width. Does not account for "textScale" used in Draw(). Useful for calculating draw position.  
**TextOriginal**: original text, that was inserted.  
**Text**: modified text, with markers changed to spaces (to match image width properly).  
**NoOfLines**: text line count.  
**AnimationFinished**: has animation been finished. Always true if "animate" option is disabled.
