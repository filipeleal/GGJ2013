@script RequireComponent(GUITexture);
@script RequireComponent(AudioSource);

var width: int = 500; // texture width
var height: int = 100; // texture height
var backgroundColor: Color = Color.black;
var waveformColor: Color = Color.green;
var size = 2048; // size of sound segment displayed in texture

private var blank: Color[]; // blank image array
private var texture: Texture2D;
private var samples: float[]; // audio samples array

function Start(){
  // create the samples array
  samples = new float[size];
  // create the texture and assign to the guiTexture:
  texture = new Texture2D(width, height);
  guiTexture.texture = texture;
  // create a 'blank screen' image
  blank = new Color[width * height];
  for (var pixel in blank){
    pixel = backgroundColor;
  }
  // refresh the display each 100mS
  while (true){
    GetCurWave();
    yield WaitForSeconds(0.1);
  }
}

function GetCurWave(){
  // clear the texture
  texture.SetPixels(blank, 0);
  // get samples from channel 0 (left)
  audio.GetOutputData(samples, 0);
  // draw the waveform
  for (i = 0; i < size; i++){
    texture.SetPixel(width * i / size, height * (samples[i]+1f)/2, waveformColor);
  }
  // upload to the graphics card
  texture.Apply();
}
