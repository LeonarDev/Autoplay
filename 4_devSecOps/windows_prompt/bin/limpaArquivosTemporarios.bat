@echo off
IF EXIST c:\windows\temp\ (
forfiles /p “C:\Windows\Temp” /s /m *.* /D -7 /C “cmd /c del /Q @path”
)
IF EXIST “C:\Users\” (
for /D %%x in (“C:\Users\*”) do (
forfiles /p “%%x\AppData\Local\Temp” /s /m *.* /D -7 /C “cmd /c del /Q @path”
forfiles /p “%%x\AppData\Local\Microsoft\Windows\Temporary Internet Files” /s /m *.* /D -7 /C “cmd /c del /Q @path”
forfiles /p “%%x\AppData\Local\Microsoft\Windows\WER\ReportQueue” /s /m *.* /C “cmd /c del /Q @path”
)
)