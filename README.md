# ToggleMuteForegroundApplication

## About

The goal of this project is to provide a program that can be called silently to mute the foreground application.
It is deseigned to be used as keyboard macro call, so you must have a keybord software that can override keys calls at least.

## Why

You should use it if :

* you are a multitasker person ;
* you sometimes mute a program to listen to another ;
* you play video games ;
* **you want to mute the program without exiting it**

## How to use it

### 1. Compile the cs files

Via command line or create a **Visual Studio Project** from files.

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

## Behavior

Toggle behavior, if the program is muted then calling the program will unmute it and vice-versa.

The purpose of this program is to be completely silent, there is no **success**, **warning** nor **error** notification.
If there is no foreground program, calling this program will have __no effect__.

## Licence

This project is under the MIT Licence, see the **LICENSE** file.