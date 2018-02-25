# ToggleMuteForegroundApplication

## About

The goal of this project is to provide a program that can be called silently to mute the foreground application.
It is deseigned to be used as keyboard macro call, so you must have a keybord software that can override keys at least.

## Why

If you use multiple display and/or have multiple medias running (ex: a game and a video, etc.) and you want to focus on the video without exiting the game you can simply call the program and it will mute the program, and vice/versa if you call it back.

## How to use it

### 1. Compile the cs files

Via command line or create a Visual Studio Project from files.

```shell
csc -out:ToggleMuteForegroundApplication.exe *.cs
```

### 2. Create a script to call the .exe silently

It is needed so no cmd prompt will show up and therefore change the foreground program !
This is an exemple using a VBS script :

```VBS
Set oShell = CreateObject ("Wscript.Shell")
oShell.Run chr(34) & "PATH_TO_YOUR_.EXE" & chr(34) & " /silent",0,true
```

### 3. Link it to your macro key

Use your own keyboard software to call the vbs script.

## Licence

This project is under the MIT Licence