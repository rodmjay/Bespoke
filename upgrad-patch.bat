@echo off
PowerShell -NoProfile -ExecutionPolicy Bypass -File "%~dp0UpdatePatch.ps1" -Folder "%~dp0src"
pause