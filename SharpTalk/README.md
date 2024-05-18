SharpTalk
=========
https://github.com/whatsecretproject/SharpTalk/

A .NET wrapper for the FonixTalk TTS engine.


This project was inspired by the creative antics of those utilizing Moonbase Alpha's TTS feature. Aeiou.

I searched around exhausively for a decent TTS engine apart from Microsoft's SAPI, which has a .NET implementation. I don't like SAPI because its features are complicated, it depends on having custom voices installed, and SSML generally makes me want to puke.

Eventually, I came across DECtalk and its accompanying SDK, from which I was able to get documentation for its functions. I spent countless hours implementing these in C# using P/Invoke, and I eventually got it working.

After noticing some issues with DECtalk, I migrated the library to its successor, FonixTalk.


Features
-----
* Asynchronous speaking
* Phoneme events for mouth movements in games/animations
* Stream output for exporting voice audio as PCM data
* Sync() method makes it easy to synchronize voice output
* Adjustable voice and speaking rate
* Multiple engines can be independently controlled and talking at the same time
* Voices can be paused/resumed


How to use
------

Using the library is very simple and straightforward. Here is the basic code to make the engine speak:

```cs
var tts = new FonixTalkEngine();
tts.Speak("John Madden!");
```

You can easily change the voice of the engine, too! For example, to use the Frank voice, just add one line:

```cs
var tts = new FonixTalkEngine();
tts.Voice = TTSVoice.Frank;
tts.Speak("Here comes another Chinese earthquake! [brbrbrbrbrbrbrbrbrbrbrbrbrbrbrbrbrbrbr]");
```

Exporting speech audio to memory is just as simple:

```cs
var tts = new FonixTalkEngine();
byte[] audioBytes = tts.SpeakToMemory("Eat your heart out, SAPI!");
// Process audio data here
```

Or if you'd like a WAV file instead, SharpTalk has you covered.
```cs
var tts = new FonixTalkEngine();
tts.SpeakToWAVFile("speech.wav", "[:dv gv 0 br 120][:rate 300]I'm BatMan.");
```
