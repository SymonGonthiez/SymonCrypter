# Symon Crypt 

This is a crypter coded in VB.Net and Autoit3 in order to crypt ".exe" files and make them undetected by antivirus.

This Project was Coded for SECURITY Purpose. Use it only to  Protect your Files Against Reverse Engineering | I don't take any responsibility for any other abuse you conduct with this Software ~

## Installation

Compile it using Visual Studio ~

## Features

 - Scantime / Runtime encrption
 - Various encryption algorithms 
 - Injection (notepad, mstc, itself or custom)
 - Melt file
 - Hidden Start-up
 - Icon changer
 - Binder (memory running and runonce function)
 
Scan feature is coming.

## Stub

Basically the crypter is going to take the content of an infected file then encrypt it in order to bypass signature detection. It will place that content at the bottom of a virus-free file, this file is the stub. 

Your stub file will then extract the encrypted data from itself, decrypt it, then extract and run it in memory (to bypass heuristic detection).
